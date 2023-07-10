using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class frmBenhNhan : Form
    {
        private string cellValue;
        private string connectionString;
        private bool isAdding;
        private DataGridView dgv_BN;
        private RefreshDGV refreshDGV;
        public frmBenhNhan(string cellValue, string connectionString, bool isAdding, DataGridView dgv_BN)
        {
            this.cellValue = cellValue;
            this.isAdding = isAdding;
            this.connectionString = connectionString;
            this.dgv_BN = dgv_BN;
           
            InitializeComponent();

            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        {
            LoadMaBSTD();
            LoadMaBSTN();
            if (string.IsNullOrEmpty(cellValue))
            {
                this.Text = "Thêm mới bệnh nhân";
                //ẨN
                txb_MaBN.Visible = false;
                label7.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật thông tin bệnh nhân";
                cbb_HinhThucKham.Enabled = false;
                LoadData(cellValue);
            }

            // Đặt giá trị chỉ đọc cho textbox Chức vụ
           // txb_HinhThucKham.ReadOnly = isReadOnly;
        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectBenhNhan @MaBN";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaBN", cellValue);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txb_MaBN.Text = reader["Mã BN"].ToString();
                        txb_TenBN.Text = reader["Tên BN"].ToString();

                        DateTime ngSinh = Convert.ToDateTime(reader["Ngày sinh"]);
                        dtp_NgSinhBN.Value = ngSinh;

                        txb_CCCDBN.Text = reader["CCCD"].ToString();
                        cbb_MaBSTD.Text = reader["Mã BSi Theo Dõi"].ToString();
                        cbb__MaBSTN.Text = reader["Mã BSi Tiếp Nhận"].ToString();
     //                   txb_HinhThucKham.Text = reader["Hình thức khám"].ToString();
                        cbb_HinhThucKham.Text = reader["Hình thức khám"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                MessageBox.Show("Không thực thi thành công. \n\nLỗi:" + ex.Message);
                this.Close();
            }
        }

        private void btn_ADBN_Click(object sender, EventArgs e)
        {
            if (txb_TenBN.Text.Trim() == "" || txb_CCCDBN.Text.Trim() == "" || cbb__MaBSTN.Text.Trim() == "" || 
                cbb_MaBSTD.Text.Trim() == "" || cbb_HinhThucKham.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống mục nào", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            // Lấy dữ liệu từ các textbox
            string maBN= txb_MaBN.Text;
            string tenBN = txb_TenBN.Text;
            DateTime ngSinh = dtp_NgSinhBN.Value;
            string cccd = txb_CCCDBN.Text;

            string maBSTD;
            if (cbb_MaBSTD.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedYTa = (KeyValuePair<string, string>)cbb_MaBSTD.SelectedItem;
                maBSTD = selectedYTa.Key;
            }
            else
            {
                maBSTD = cbb_MaBSTD.Text;
            }
           
            //////
            string maBSTN;
            if (cbb__MaBSTN.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedYTa = (KeyValuePair<string, string>)cbb__MaBSTN.SelectedItem;
                maBSTN = selectedYTa.Key;
            }
            else
            {
                maBSTN = cbb__MaBSTN.Text;
            }
           
            string hinhThucKham = cbb_HinhThucKham.Text;

            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemMoiBenhNhan", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TenBN", tenBN);
                        command.Parameters.AddWithValue("@NgSinh", ngSinh);
                        command.Parameters.AddWithValue("@CCCD", cccd);
                        command.Parameters.AddWithValue("@MaBSiTheoDoi", maBSTD);
                        command.Parameters.AddWithValue("@MaBSiTiepNhan", maBSTN);
                        command.Parameters.AddWithValue("@HinhThucKham", hinhThucKham);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới thông tin bệnh nhân thành công.");
                        this.Close();

                        refreshDGV.Refresh_DGV("vw_ThongTinBenhNhanDangDieuTri", dgv_BN);
                       /* SqlCommand currentViews = new SqlCommand("SELECT * FROM vw_ThongTinBenhNhanDangDieuTri", connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(currentViews);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        dgv_BN.DataSource = dataTable;*/
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới thông tin \n\nLỗi: " + ex.Message);
                }
                
            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatThongTinBenhNhan", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaBN", maBN);
                        command.Parameters.AddWithValue("@TenBN", tenBN);
                        command.Parameters.AddWithValue("@NgSinh", ngSinh);
                        command.Parameters.AddWithValue("@CCCD", cccd);
                        command.Parameters.AddWithValue("@MaBSiTheoDoi", maBSTD);
                        command.Parameters.AddWithValue("@MaBSiTiepNhan", maBSTN);
                        command.Parameters.AddWithValue("@HinhThucKham", hinhThucKham);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin bệnh nhân thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_ThongTinBenhNhanDangDieuTri", dgv_BN);
                       /* SqlCommand currentViews = new SqlCommand("SELECT * FROM vw_ThongTinBenhNhanDangDieuTri", connection);
                        SqlDataAdapter adapter = new SqlDataAdapter(currentViews);
                        DataTable dataTable = new DataTable();

                        adapter.Fill(dataTable);
                        dgv_BN.DataSource = dataTable;*/
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message);
                }


            }
            
        }

        private void btn_HuyADBN_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadMaBSTD()
        {
            string query = "Select [Mã Bác Sĩ], [Tên Bác Sĩ] from vw_ThongTinBacSi";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maBSTD = reader["Mã Bác Sĩ"].ToString();
                        string tenBSTD = reader["Tên Bác Sĩ"].ToString();                  
                        cbb_MaBSTD.Items.Add(new KeyValuePair<string, string>(maBSTD, tenBSTD));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ view: " + ex.Message);
            }
        }

        private void LoadMaBSTN()
        {
            string query = "Select [Mã Bác Sĩ], [Tên Bác Sĩ] from vw_ThongTinBacSi";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maBSTN = reader["Mã Bác Sĩ"].ToString();
                        string tenBSTN = reader["Tên Bác Sĩ"].ToString();
                        cbb__MaBSTN.Items.Add(new KeyValuePair<string, string>(maBSTN, tenBSTN));                      
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ view: " + ex.Message);
            }
        }
    }
}

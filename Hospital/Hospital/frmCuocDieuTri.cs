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
    public partial class frmCuocDieuTri : Form
    {
        private string cellValue;
        private string connectionString;
        private bool isAdding;
        private DataGridView dgv_CuocDieuTri;
        private RefreshDGV refreshDGV;

        public frmCuocDieuTri(string cellValue, string connectionString, bool isAdding, DataGridView dgv_CuocDieuTri)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.isAdding = isAdding;
            this.dgv_CuocDieuTri = dgv_CuocDieuTri;
            InitializeComponent();

            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmCuocDieuTri_Load(object sender, EventArgs e)
        {
            LoadMaBN();
            LoadMaBSi();
            LoadMaSCT();
            if (string.IsNullOrEmpty(cellValue))
            {
                this.Text = "Thêm mới CDT";
                //ẨN
                txb_IDCDT.Visible = false;
                label7.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật thông tin CDT";
                LoadData(cellValue);
            }
        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectCuocDieuTri @ID_CDT";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_CDT", cellValue);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txb_IDCDT.Text = reader["ID_CDT"].ToString();
                        cbb_MaBSiDT.Text = reader["Mã bác sĩ"].ToString();
                        cbb_MaBNDT.Text = reader["Mã bệnh nhân"].ToString();
                        cbb_MaSCT_CDT.Text = reader["Mã sự chữa trị"].ToString();
                        txb_ThGianDT.Text = reader["Thời gian điều trị"].ToString();

                        DateTime ngayDT = Convert.ToDateTime(reader["Ngày điều trị"]);
                        dtp_NgayDT.Value = ngayDT;

                        txb_KetQuaCDT.Text = reader["Kết quả"].ToString();
                        
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                MessageBox.Show("Không thực thi thành công hoặc bạn không có quyền thực hiện hành động này. \n\nLỗi:" + ex.Message);
                this.Close();
            }
        }

        private void btn_ADCDT_Click(object sender, EventArgs e)
        {
            if (cbb_MaBSiDT.Text.Trim() == "" || cbb_MaBNDT.Text.Trim() == "" || cbb_MaSCT_CDT.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống Mã Bác sĩ, Mã Bệnh Nhân, Mã SCT", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string idCDT = txb_IDCDT.Text;
            string maBSiDT;
            if (cbb_MaBSiDT.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedBSDT = (KeyValuePair<string, string>)cbb_MaBSiDT.SelectedItem;
                maBSiDT = selectedBSDT.Key;
            }
            else
            {
                maBSiDT = cbb_MaBSiDT.Text;
            }
          
            //////
            string maBNDT;
            if (cbb_MaBNDT.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedBNDT = (KeyValuePair<string, string>)cbb_MaBNDT.SelectedItem;
                maBNDT = selectedBNDT.Key;
            }
            else
            {
                maBNDT = cbb_MaBNDT.Text;
            }
            //--------------
            string maSCT;
            if (cbb_MaSCT_CDT.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedSCT = (KeyValuePair<string, string>)cbb_MaSCT_CDT.SelectedItem;
                maSCT = selectedSCT.Key;
            }
            else
            {
                maSCT = cbb_MaSCT_CDT.Text;
            }


            DateTime ngayDT = dtp_NgayDT.Value;
            string thGianDT = txb_ThGianDT.Text;
            string ketQua = txb_KetQuaCDT.Text;
            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemMoiCuocDieuTri", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaBSi", maBSiDT);
                        command.Parameters.AddWithValue("@MaBN", maBNDT);
                        command.Parameters.AddWithValue("@MaCT", maSCT);
                        command.Parameters.AddWithValue("@ThGian", thGianDT);
                        command.Parameters.AddWithValue("@Ngay", ngayDT);
                        command.Parameters.AddWithValue("@KetQua", ketQua);



                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới CDT thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_CuocDieuTri_All", dgv_CuocDieuTri);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới CDT. \n\nLỗi: " + ex.Message);
                }

            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatCuocDieuTri", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID_CDT", idCDT);
                        command.Parameters.AddWithValue("@MaBSi", maBSiDT);
                        command.Parameters.AddWithValue("@MaBN", maBNDT);
                        command.Parameters.AddWithValue("@MaCT", maSCT);
                        command.Parameters.AddWithValue("@ThGian", thGianDT);
                        command.Parameters.AddWithValue("@Ngay", ngayDT);
                        command.Parameters.AddWithValue("@KetQua", ketQua);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin CDT thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_CuocDieuTri_All", dgv_CuocDieuTri);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin CDT: " + ex.Message);
                }

            }
        }

        private void btn_HuyADCDT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadMaBSi()
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
                        string maBS = reader["Mã Bác Sĩ"].ToString();
                        string tenBS = reader["Tên Bác Sĩ"].ToString();
                        cbb_MaBSiDT.Items.Add(new KeyValuePair<string, string>(maBS, tenBS));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ view: " + ex.Message);
            }
        }


        private void LoadMaBN()
        {
            string query = "Select [Mã BN], [Tên BN] from vw_ThongTinBenhNhanDangDieuTri";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maBN = reader["Mã BN"].ToString();
                        string tenBN = reader["Tên BN"].ToString();
                        cbb_MaBNDT.Items.Add(new KeyValuePair<string, string>(maBN, tenBN));                    
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ view: " + ex.Message);
            }
        }

        private void LoadMaSCT()
        {
            string query = "Select * from vw_SuChuaTri";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maSCT = reader["Mã sự chữa trị"].ToString();
                        string tenSCT = reader["Tên sự chữa trị"].ToString();
                        cbb_MaSCT_CDT.Items.Add(new KeyValuePair<string, string>(maSCT, tenSCT));                  
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

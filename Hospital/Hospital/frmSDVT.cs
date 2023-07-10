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

    public partial class frmSDVT : Form
    {
        private string cellValue;
        private string connectionString;
        private bool isAdding;
        private DataGridView dgv_SDVT;
        private RefreshDGV refreshDGV;

        public frmSDVT(string cellValue, string connectionString, bool isAdding, DataGridView dgv_SDVT)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.isAdding = isAdding;
            this.dgv_SDVT = dgv_SDVT;

            InitializeComponent();
            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmSDVT_Load(object sender, EventArgs e)
        {
            LoadMaBN();
            LoadMaVT();
            if (string.IsNullOrEmpty(cellValue))
            {
                this.Text = "Thêm mới SDVT";
                //ẨN
                txb_IDSDVT.Visible = false;
                label7.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật thông tin SDVT";
                cbb_MaBNSDVT.Enabled = false;
                LoadData(cellValue);
            }

        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectSDVT_All @ID_SDVT";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@ID_SDVT", cellValue);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txb_IDSDVT.Text = reader["ID_SDVT"].ToString();
                        cbb_MaBNSDVT.Text = reader["Mã Bệnh Nhân"].ToString();
                        cbb_MaVTSD.Text = reader["Mã Vật Tư"].ToString();
                       
                        DateTime ngaySD = Convert.ToDateTime(reader["Ngày sử dụng"]);
                        dtp_NgaySD.Value = ngaySD;

                        txb_ThGianSDVT.Text = reader["Thời gian sử dụng"].ToString();
                        txb_SoLuongSDVT.Text = reader["Số lượng"].ToString();

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

        private void btn_ADSDVT_Click(object sender, EventArgs e)
        {
            if (cbb_MaBNSDVT.Text.Trim() == "" || cbb_MaVTSD.Text.Trim() == "" || dtp_NgaySD.Value == null)
            {
                MessageBox.Show("Không được bỏ trống Mã BN, Mã Vật Tư, Ngày SD", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string idSDVT = txb_IDSDVT.Text;
            string maBNSDVT;
            if (cbb_MaBNSDVT.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedYTa = (KeyValuePair<string, string>)cbb_MaBNSDVT.SelectedItem;
                maBNSDVT = selectedYTa.Key;
            }
            else
            {
                maBNSDVT = cbb_MaBNSDVT.Text;
            }

            string maVTSD;
            if (cbb_MaVTSD.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedYTa = (KeyValuePair<string, string>)cbb_MaVTSD.SelectedItem;
                maVTSD = selectedYTa.Key;
            }
            else
            {
                maVTSD = cbb_MaVTSD.Text;
            }       
            DateTime ngaySDVT = dtp_NgaySD.Value;
            string thGianSD = txb_ThGianSDVT.Text;
            string soLuong = txb_SoLuongSDVT.Text;
            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemSuDungVatTu", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaBN", maBNSDVT);
                        command.Parameters.AddWithValue("@MaVT", maVTSD);
                        command.Parameters.AddWithValue("@NgaySD", ngaySDVT);
                        command.Parameters.AddWithValue("@ThGian", thGianSD);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);



                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới SDVT thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_SDVT_All", dgv_SDVT);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới SDVT. \n\nLỗi: " + ex.Message);
                }

            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatSuDungVatTu", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@ID_SDVT", idSDVT);
                        command.Parameters.AddWithValue("@MaBN", maBNSDVT);
                        command.Parameters.AddWithValue("@MaVT", maVTSD);
                        command.Parameters.AddWithValue("@NgaySD", ngaySDVT);
                        command.Parameters.AddWithValue("@ThGian", thGianSD);
                        command.Parameters.AddWithValue("@SoLuong", soLuong);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin SDVT thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_SDVT_All", dgv_SDVT);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin SDVT: " + ex.Message);
                }

            }
        }

        private void btn_HuyADSDVT_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        cbb_MaBNSDVT.Items.Add(new KeyValuePair<string, string>(maBN, tenBN));
                        //cbb_MaBNSDVT.Items.Add(reader["Mã BN"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ view: " + ex.Message);
            }
        }

        private void LoadMaVT()
        {
            string query = "Select [Mã Vật Tư], [Đặc tả vật tư] from vw_VatTuDangDuocSuDung";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maVT = reader["Mã Vật Tư"].ToString();
                        string dacTaVT = reader["Đặc tả vật tư"].ToString();
                        cbb_MaVTSD.Items.Add(new KeyValuePair<string, string>(maVT, dacTaVT));
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

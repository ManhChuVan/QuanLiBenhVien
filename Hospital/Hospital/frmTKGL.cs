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
    public partial class frmTKGL : Form
    {
        private string cellValue;
        private string cellValue2;
        private string connectionString;
        private bool isAdding;
        private DataGridView dgv_TKGL;
        private RefreshDGV refreshDGV;
        public frmTKGL(string cellValue, string cellValue2, string connectionString, bool isAdding, DataGridView dgv_TKGL)
        {
            this.cellValue = cellValue;
            this.cellValue2 = cellValue2;
            this.connectionString = connectionString;
            this.isAdding = isAdding;
            this.dgv_TKGL = dgv_TKGL;

            InitializeComponent();
            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmTKGL_Load(object sender, EventArgs e)
        {
            LoadMaNV();
            LoadMaKhu();
            if (string.IsNullOrEmpty(cellValue) && string.IsNullOrEmpty(cellValue2))
            {
                this.Text = "Thêm mới QLGL";
               
            }
            else
            {
                cbb_MaNV_TKGL.Enabled = false;
                this.Text = "Cập nhật thông tin QLGL";
                LoadData(cellValue, cellValue2);
            }
        }

        private void LoadData(string cellValue, string cellValue2)
        {
            string query = "EXEC sp_SelectTKGL @MaNV, @MaKhu";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNV", cellValue);
                    command.Parameters.AddWithValue("@MaKhu", cellValue2);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        cbb_MaNV_TKGL.Text = reader["MaNV"].ToString();
                        cbb_MaKhu_TKGL.Text = reader["MaKhu"].ToString();
                        txb_SoGioLV.Text = reader["SoGioLV"].ToString();
                       
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

        private void btn_ADTKGL_Click(object sender, EventArgs e)
        {
            if (cbb_MaNV_TKGL.Text.Trim() == "" || cbb_MaKhu_TKGL.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống Mã NV và Mã Khu", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string maNV;
            if (cbb_MaNV_TKGL.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedYTa = (KeyValuePair<string, string>)cbb_MaNV_TKGL.SelectedItem;
                maNV = selectedYTa.Key;
            }
            else
            {
                maNV = cbb_MaNV_TKGL.Text;
            }
          ////////
            string maKhu;
            if (cbb_MaKhu_TKGL.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedKhu = (KeyValuePair<string, string>)cbb_MaKhu_TKGL.SelectedItem;
                maKhu = selectedKhu.Key;
            }
            else
            {
                maKhu = cbb_MaKhu_TKGL.Text;
            }
           
            string soGioLV = txb_SoGioLV.Text;

           
            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemMoiThongKeGioLam", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaNV", maNV);
                        command.Parameters.AddWithValue("@MaKhu", maKhu);
                        command.Parameters.AddWithValue("@SoGioLV", soGioLV);
                       

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới QLGL thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_ThongTinGioLamNV", dgv_TKGL);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới QLGL. \n\nLỗi: " + ex.Message);
                }

            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatThongKeGioLam", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaNV", maNV);
                        command.Parameters.AddWithValue("@MaKhu", maKhu);
                        command.Parameters.AddWithValue("@SoGioLV", soGioLV);
                       
 
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin vào QLGL thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_ThongTinGioLamNV", dgv_TKGL);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message);
                }

            }
        }

        private void btn_HuyADTKGL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadMaNV()
        {
            string query = "Select [Mã Nhân Viên], [Họ tên] from vw_ThongTinNhanVien";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maNV = reader["Mã Nhân Viên"].ToString();
                        string tenNV = reader["Họ tên"].ToString();
                        cbb_MaNV_TKGL.Items.Add(new KeyValuePair<string, string>(maNV, tenNV));
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu từ view: " + ex.Message);
            }
        }

        private void LoadMaKhu()
        {
            string query = "Select [Mã Khu], [Tên Khu Chữa Trị] from vw_ThongTinKhuChuaTri";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maKhu = reader["Mã Khu"].ToString();
                        string tenKhu = reader["Tên Khu Chữa Trị"].ToString();
                        cbb_MaKhu_TKGL.Items.Add(new KeyValuePair<string, string>(maKhu, tenKhu));
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

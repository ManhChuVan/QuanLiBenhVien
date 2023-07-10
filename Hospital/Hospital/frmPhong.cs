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
    public partial class frmPhong : Form
    {
        private string cellValue;
        private string connectionString;
        private bool isReadOnly;
        private bool isAdding;
        private DataGridView dgv_Phong;
        private RefreshDGV refreshDGV;

        public frmPhong(string cellValue, string connectionString, bool isReadOnly, bool isAdding, DataGridView dgv_Phong)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.isReadOnly = isReadOnly;
            this.isAdding = isAdding;
            this.dgv_Phong = dgv_Phong;

            InitializeComponent();
            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmPhong_Load(object sender, EventArgs e)
        {
            LoadMaKhu();
            if (string.IsNullOrEmpty(cellValue))
            {
                this.Text = "Thêm mới phòng";
                //ẨN
                txb_MaPhong.Visible = false;
                label2.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật thông tin phòng";
                LoadData(cellValue);
            }
        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectPhong_CHD @MaPhong";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaPhong", cellValue);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txb_MaPhong.Text = reader["Mã Phòng"].ToString();               
                        cbb_MaKhu_P.Text = reader["Mã Khu chữa trị"].ToString();
                        txb_TenPhong.Text = reader["Tên phòng"].ToString();

                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                MessageBox.Show("Không thực thi thành công hoặc bạn không có quyền thực hiện hành động này. \nLỗi:" + ex.Message);
                this.Close();
            }
        }

        private void btn_ADPhong_Click(object sender, EventArgs e)
        {
            if (txb_TenPhong.Text.Trim() == "" || cbb_MaKhu_P.Text.Trim() == "")
            {
                MessageBox.Show("Mã khu và tên phòng không thể bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string maPhong = txb_MaPhong.Text;

            string maKhuPhong;
            if (cbb_MaKhu_P.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedYTa = (KeyValuePair<string, string>)cbb_MaKhu_P.SelectedItem;
                maKhuPhong = selectedYTa.Key;
            }
            else
            {
                maKhuPhong = cbb_MaKhu_P.Text;
            }
       
            string tenPhong = txb_TenPhong.Text;
            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemMoiPhong", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaKhuCT", maKhuPhong);
                        command.Parameters.AddWithValue("@TenPhong", tenPhong);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới Phòng thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_Phong_ConHoatDong", dgv_Phong);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới phòng. \n\nLỗi: " + ex.Message);
                }

            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatPhong", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@MaKhuCT", maKhuPhong);
                        command.Parameters.AddWithValue("@TenPhong", tenPhong);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin phòng thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_Phong_ConHoatDong", dgv_Phong);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin phòng: " + ex.Message);
                }

            }
        }

        private void btn_HuyADPhong_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        cbb_MaKhu_P.Items.Add(new KeyValuePair<string, string>(maKhu, tenKhu));
                        
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

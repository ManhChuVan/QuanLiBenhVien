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
    public partial class frmGiuong : Form
    {
        private string cellValue;
        private string connectionString;
        private bool isReadOnly;
        private bool isAdding;
        private DataGridView dgv_Giuong;
        private RefreshDGV refreshDGV;

        public frmGiuong(string cellValue, string connectionString, bool isReadOnly, bool isAdding, DataGridView dgv_Giuong)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.isReadOnly = isReadOnly;
            this.isAdding = isAdding;
            this.dgv_Giuong = dgv_Giuong;
            InitializeComponent();

            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmGiuong_Load(object sender, EventArgs e)
        {
            LoadMaPhong();
            LoadMaKhu();
            if (string.IsNullOrEmpty(cellValue))
            {
                this.Text = "Thêm mới giường";
                //ẨN
                txb_MaGiuong.Visible = false;
                label2.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật thông tin giường";
                LoadData(cellValue);
            }
        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectGiuong @MaGiuong";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaGiuong", cellValue);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txb_MaGiuong.Text = reader["Mã Giường"].ToString();
                        cbb_MaPhong_G.Text = reader["Mã Phòng"].ToString();
                        cbb_MaKhu_G.Text = reader["Mã Khu"].ToString();

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

        private void btn_APGiuong_Click(object sender, EventArgs e)
        {
            if (cbb_MaKhu_G.Text.Trim() == "" || cbb_MaPhong_G.Text.Trim() == "")
            {
                MessageBox.Show("Mã khu và mã phòng không thể bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string maGiuong = txb_MaGiuong.Text;

            string maPhong;
            if (cbb_MaPhong_G.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedPhong = (KeyValuePair<string, string>)cbb_MaPhong_G.SelectedItem;
                maPhong = selectedPhong.Key;
            }
            else
            {
                maPhong = cbb_MaPhong_G.Text;
            }
            /////////////////////
            string maKhu;
            if (cbb_MaKhu_G.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedKhu = (KeyValuePair<string, string>)cbb_MaKhu_G.SelectedItem;
                maKhu = selectedKhu.Key;
            }
            else
            {
                maKhu = cbb_MaKhu_G.Text;
            }

            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemMoiGiuong", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@MaKhu", maKhu);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới giường thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_Giuong", dgv_Giuong);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới giường. \n\nLỗi: " + ex.Message);
                }

            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatGiuong", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaGiuong", maGiuong);
                        command.Parameters.AddWithValue("@MaPhong", maPhong);
                        command.Parameters.AddWithValue("@MaKhu", maKhu);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin giường thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_Giuong", dgv_Giuong);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin giường: " + ex.Message);
                }

            }
        }

        private void btn_HuyADGiuong_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void LoadMaPhong()
        {
            string query = "Select [Mã Phòng], [Tên phòng] from vw_Phong_ConHoatDong";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maPhong = reader["Mã Phòng"].ToString();
                        string tenPhong = reader["Tên phòng"].ToString();
                        cbb_MaPhong_G.Items.Add(new KeyValuePair<string, string>(maPhong, tenPhong));     
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
                        cbb_MaKhu_G.Items.Add(new KeyValuePair<string, string>(maKhu, tenKhu));
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

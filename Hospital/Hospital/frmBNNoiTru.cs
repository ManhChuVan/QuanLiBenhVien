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
    public partial class frmBNNoiTru : Form
    {
        private string cellValue;
        private string connectionString;
        private DataGridView dgv_BNNoiTru;
        private RefreshDGV refreshDGV;
        public frmBNNoiTru(string cellValue, string connectionString, DataGridView dgv_BNNoiTru)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.dgv_BNNoiTru = dgv_BNNoiTru;

            InitializeComponent();

            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmBNNoiTru_Load(object sender, EventArgs e)
        {
            LoadMaGiuong();
            this.Text = "Cập nhật thông tin BN nội trú";
            LoadData(cellValue);
        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectBenhNhanNoiTru @MaBN";

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
                        txb_MaBNNoiTru.Text = reader["Mã BN"].ToString();
                        txb_MoTaBenhNoiTru.Text = reader["Mô tả bệnh"].ToString();
                        cbb_MaGiuong.Text = reader["Mã giường"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                MessageBox.Show("Không thực thi thành công. \n\nLỗi: " + ex.Message);
                this.Close();
            }
        }

        private void btn_CapNhatNoiTru_Click(object sender, EventArgs e)
        {
            string maBN = txb_MaBNNoiTru.Text;
            string moTaBenh = txb_MoTaBenhNoiTru.Text;
            string maGiuong = cbb_MaGiuong.Text;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("sp_CapNhatThongTinBenhNhanNoiTru", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaBN", maBN);
                    command.Parameters.AddWithValue("@MoTaBenh", moTaBenh);
                    command.Parameters.AddWithValue("@MaGiuong", maGiuong);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật thông tin bệnh nhân nội trú thành công.");
                    this.Close();
                    refreshDGV.Refresh_DGV("vw_ThongTinBenhNhanNoiTru", dgv_BNNoiTru);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message);
            }

        }

        private void btn_HuyCapNhatNoiTru_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadMaGiuong()
        {
            string query = "select [Mã Giường] from vw_Giuong";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cbb_MaGiuong.Items.Add(reader["Mã Giường"].ToString());     
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

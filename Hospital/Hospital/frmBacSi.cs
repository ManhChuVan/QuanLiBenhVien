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
    public partial class frmBacSi : Form
    {
        private string cellValue;
        private string connectionString;
        private DataGridView dgv_BacSi;
        private RefreshDGV refreshDGV;
        public frmBacSi(string cellValue, string connectionString, DataGridView dgv_BacSi)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.dgv_BacSi = dgv_BacSi;
            InitializeComponent();

            refreshDGV = new RefreshDGV(connectionString);
        }

        private void btn_HuyCapNhatBSi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectBacSi @MaNV";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNV", cellValue);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txb_MaBSi.Text = reader["Mã Bác Sĩ"].ToString();
                        txb_ChuyenMonBSi.Text = reader["Chuyên Môn"].ToString();                      
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                MessageBox.Show("Không thực thi thành công. \nLỗi: " + ex.Message);
                this.Close();
            }
        }
        private void frmBacSi_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhật thông tin bác sĩ";
            LoadData(cellValue);
        }

        private void btn_CapNhatBSi_Click(object sender, EventArgs e)
        {
            string maNV = txb_MaBSi.Text;
            string chuyenMon = txb_ChuyenMonBSi.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("sp_UpdateBacSi", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaBSi", maNV);
                    command.Parameters.AddWithValue("@ChuyenMon", chuyenMon);
                    

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật thông tin bác sĩ thành công.");
                    this.Close();
                    refreshDGV.Refresh_DGV("vw_ThongTinBacSi", dgv_BacSi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin bác sĩ: " + ex.Message);
            }

            
        }
    }
}

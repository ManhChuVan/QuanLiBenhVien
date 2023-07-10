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
    public partial class frmBNNgoaiTru : Form
    {
        private string cellValue;
        private string connectionString;
        private DataGridView dgv_BNNgoaiTru;
        private RefreshDGV refreshDGV;
        public frmBNNgoaiTru(string cellValue, string connectionString, DataGridView dgv_BNNgoaiTru)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.dgv_BNNgoaiTru = dgv_BNNgoaiTru;
            InitializeComponent();

            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmBNNgoaiTru_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhật thông tin BN ngoại trú";
            LoadData(cellValue);
        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectBenhNhanNgoaiTru @MaBN";

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
                        txb_MaBNNgoaiTru.Text = reader["Mã BN"].ToString();
                        txb_MoTaBenhNgoaiTru.Text = reader["Mô tả bệnh"].ToString();
                     
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

        private void btn_CapNhatNgoaiTru_Click(object sender, EventArgs e)
        {
            string maBN = txb_MaBNNgoaiTru.Text;
            string moTaBenh = txb_MoTaBenhNgoaiTru.Text;
           

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("sp_CapNhatBenhNhanNgoaiTru", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaBN", maBN);
                    command.Parameters.AddWithValue("@MoTaBenh", moTaBenh);
                  

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật thông tin bệnh nhân ngoại trú thành công.");
                    this.Close();
                    refreshDGV.Refresh_DGV("vw_ThongTinBenhNhanNgoaiTru", dgv_BNNgoaiTru);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message);
            }

            
        }

        private void btn_HuyCapNhatNgoaiTru_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

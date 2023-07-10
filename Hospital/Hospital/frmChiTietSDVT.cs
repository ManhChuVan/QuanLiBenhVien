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
    public partial class frmChiTietSDVT : Form
    {
        private string cellValue;
        private string connectionString;
        public frmChiTietSDVT(string cellValue, string connectionString)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void frmChiTietSDVT_Load(object sender, EventArgs e)
        {
            this.Text = "Chi tiết SDVT";
            LoadData(cellValue);
            dgv_ChiTietSDVT.DataSource = GetThongTinSDVT(cellValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectBenhNhan_All @MaBN";
     

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
                        txb_TenBNSDVT.Text = reader["TenBN"].ToString();
                        
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

        private DataTable GetThongTinSDVT(string maBN)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT [Mã Vật Tư], [Tên vật tư], [Số lượng], [Giá] FROM dbo.GetThongTinSDVT(@MaBN)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaBN", maBN);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                connection.Open();
                adapter.Fill(dataTable);
                connection.Close();
            }

            return dataTable;
        }


    }
}

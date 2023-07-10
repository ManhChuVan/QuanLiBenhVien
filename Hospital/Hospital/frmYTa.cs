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
    public partial class frmYTa : Form
    {
        private string cellValue;
        private string connectionString;
        private DataGridView dgv_YTa;
        private RefreshDGV refreshDGV;

        public frmYTa(string cellValue, string connectionString, DataGridView dgv_YTa)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.dgv_YTa = dgv_YTa;

            InitializeComponent();
            refreshDGV = new RefreshDGV(connectionString);
        }

        private void btn_HuyCapNhatYTa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectYTa @MaNV";

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
                        txb_MaYTa.Text = reader["Mã Y Tá"].ToString();
                        cbb_VTLV.Text = reader["Vị trí công việc"].ToString();
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

        private void frmYTa_Load(object sender, EventArgs e)
        {
            this.Text = "Cập nhật thông tin y tá";
            LoadData(cellValue);
        }

        private void btn_CapNhatYTa_Click(object sender, EventArgs e)
        {
            string maYTa = txb_MaYTa.Text;
            string viTriLamViec = cbb_VTLV.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("sp_UpdateYTa", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@MaYTa", maYTa);
                    command.Parameters.AddWithValue("@ViTriCongViec", viTriLamViec);


                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Cập nhật thông tin y tá thành công.");
                    this.Close();
                    refreshDGV.Refresh_DGV("vw_ThongTinYTa", dgv_YTa);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin y tá: " + ex.Message);
            }

            
        }
       
    }
}

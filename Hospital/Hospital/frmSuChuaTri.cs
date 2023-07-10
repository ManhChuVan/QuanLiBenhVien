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
    public partial class frmSuChuaTri : Form
    {
        private string cellValue;
        private string connectionString;
        private bool isAdding;
        private DataGridView dgv_SuChuaTri;
        private RefreshDGV refreshDGV;

        public frmSuChuaTri(string cellValue, string connectionString, bool isAdding, DataGridView dgv_SuChuaTri)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.isAdding = isAdding;
            this.dgv_SuChuaTri = dgv_SuChuaTri;

            InitializeComponent();
            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmSuChuaTri_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cellValue))
            {
                this.Text = "Thêm mới Sự chữa trị";
                //ẨN
                txb_MaSCT.Visible = false;
                label2.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật thông tin SCT";
                LoadData(cellValue);
            }

        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectSuChuaTri @MaCT";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaCT", cellValue);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txb_MaSCT.Text = reader["Mã sự chữa trị"].ToString();
                        txb_TenSCT.Text = reader["Tên sự chữa trị"].ToString();                       

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

        private void btn_ADSCT_Click(object sender, EventArgs e)
        {
            if (txb_TenSCT.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string maSCT = txb_MaSCT.Text;
            string tenSCT = txb_TenSCT.Text;
           
            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemSuChuaTri", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@Ten", tenSCT);
                        

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới sự chữa trị thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_SuChuaTri", dgv_SuChuaTri);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới SCT. \n\nLỗi: " + ex.Message);
                }

            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatSuChuaTri", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaCT", maSCT);
                        command.Parameters.AddWithValue("@Ten", tenSCT);
                       
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin sự chữa trị thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_SuChuaTri", dgv_SuChuaTri);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin SCT: " + ex.Message);
                }

            }
        }

        private void btn_HuyADSCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

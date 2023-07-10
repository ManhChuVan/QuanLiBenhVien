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
    public partial class frmKhuChuaTri : Form
    {
        private string cellValue;
        private string connectionString;
        private bool isReadOnly;
        private bool isAdding;
        private DataGridView dgv_KCT;
        private RefreshDGV refreshDGV;

        public frmKhuChuaTri(string cellValue, string connectionString, bool isReadOnly, bool isAdding, DataGridView dgv_KCT)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.isReadOnly = isReadOnly;
            this.isAdding = isAdding;
            this.dgv_KCT = dgv_KCT;

            InitializeComponent();
            refreshDGV = new RefreshDGV(connectionString);
        }



        private void frmKhuChuaTri_Load(object sender, EventArgs e)
        {
            LoadMaYTChinh();
            if (string.IsNullOrEmpty(cellValue))
            {
                this.Text = "Thêm mới KCT";
                //ẨN
                txb_MaKCT.Visible = false;
                label2.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật thông tin KCT";
                
                LoadData(cellValue);
            }
        }
        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectKhuChuaTri @MaKhuCT";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@MaKhuCT", cellValue);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txb_MaKCT.Text = reader["MaKhuCT"].ToString();
                        txb_TenKCT.Text = reader["TenKhuCT"].ToString();
                        //txb_MaYTT.Text = reader["MaYTaTruong"].ToString();
                        
                        cbb_MaYTT.Text = reader["MaYTaTruong"].ToString();                        
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                MessageBox.Show("Không thực thi thành công. \nLỗi:" + ex.Message);
                this.Close();
            }
        }

        private void btn_HuyADKCT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ADKCT_Click(object sender, EventArgs e)
        {
            if (txb_TenKCT.Text.Trim() == "" || cbb_MaYTT.Text.Trim() == "")
            {
                MessageBox.Show("Tên khu và mã y tá trưởng không thể bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string maKCT = txb_MaKCT.Text;
            string tenKCT = txb_TenKCT.Text;
 //           string maYTT = txb_MaYTT.Text;
            string maYTT;
            if (cbb_MaYTT.SelectedItem != null)
            {
                KeyValuePair<string, string> selectedYTa = (KeyValuePair<string, string>)cbb_MaYTT.SelectedItem;
                maYTT = selectedYTa.Key;
            }
            else
            {
                maYTT = cbb_MaYTT.Text;
            }
            

            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemMoiKhuChuaTri", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TenKhuCT", tenKCT);
                        command.Parameters.AddWithValue("@MaYTaTruong", maYTT);
                       

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới Khu Chữa Trị thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_ThongTinKhuChuaTri", dgv_KCT);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới Khu Chữa Trị. \nLỗi: " + ex.Message);
                }
                
            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatKhuChuaTri", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaKhuCT", maKCT);
                        command.Parameters.AddWithValue("@TenKhuCT", tenKCT);
                        command.Parameters.AddWithValue("@MaYTaTruong", maYTT);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin KCT thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_ThongTinKhuChuaTri", dgv_KCT);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin KCT: " + ex.Message);
                }
            
            }

        }
 
        //-----------
        private void LoadMaYTChinh()
        {
            string query = "SELECT * FROM vw_MaYTC";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string maYTa = reader["Mã Y Tá"].ToString();
                        string tenYTa = reader["Tên Y Tá"].ToString();
                        cbb_MaYTT.Items.Add(new KeyValuePair<string, string>(maYTa, tenYTa));
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

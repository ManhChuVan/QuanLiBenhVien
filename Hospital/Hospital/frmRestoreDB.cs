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
    public partial class frmRestoreDB : Form
    {
       private string connectionString;
        public frmRestoreDB(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }
        private void btn_linkRestore_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn tệp tin";
                openFileDialog.Filter = "Tệp tin Backup (*.bak)|*.bak|Tất cả các tệp tin (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    // Sử dụng selectedFilePath trong việc backup hoặc xử lý tùy ý
                    txb_linkRestore.Text = selectedFilePath;
                }
            }
        }

        private void btn_PhucHoi_Click(object sender, EventArgs e)
        {
            if (txb_linkRestore.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống các ô", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string link = txb_linkRestore.Text;
           
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sao phục hồi liệu không?", "Xác nhận phục hồi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Mở kết nối
                        connection.Open();

                        // Chuyển đổi kết nối sang database "master"
                        using (SqlCommand cmd = new SqlCommand("USE master;", connection))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        using (SqlCommand cmd = new SqlCommand("SP_RestoreHospitalDatabase2", connection))
                        {
                            cmd.CommandType = System.Data.CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@BackupPath", link);
                            // Thực thi stored procedure
                            cmd.ExecuteNonQuery();

                            // Hiển thị thông báo khi sao lưu thành công
                            MessageBox.Show("Đã phục hồi dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi.\nLỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_huyPhucHoi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRestoreDB_Load(object sender, EventArgs e)
        {
            this.Text = "Phục hồi dữ liệu";
        }
    }
}

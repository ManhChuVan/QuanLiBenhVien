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
    public partial class frmBackupDB : Form
    {
        private string connectionString;
        public frmBackupDB(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            // Thiết lập tiêu đề và mô tả cho hộp thoại chọn thư mục
            folderBrowserDialog.Description = "Chọn thư mục lưu trữ backup";
            folderBrowserDialog.ShowNewFolderButton = true;

            // Hiển thị hộp thoại chọn thư mục và xử lý kết quả
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Lấy đường dẫn thư mục được chọn
                string selectedPath = folderBrowserDialog.SelectedPath;

                // Thực hiện các thao tác cần thiết với đường dẫn thư mục
                // Ví dụ: gán đường dẫn vào textbox
                txb_link.Text = selectedPath;
            }
        }

        private void btn_SaoLuu_Click(object sender, EventArgs e)
        {
            if (txb_link.Text.Trim() == "" || txb_nameFile.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống các ô", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string link = txb_link.Text;
            string nameFile = txb_nameFile.Text;

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn sao lưu dữ liệu không?", "Xác nhận sao lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("SP_BackupHospitalDatabase2", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@BackupPath", link);
                        command.Parameters.AddWithValue("@NameFile", nameFile);


                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Sao lưu thành công.");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thực thi.\nLỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_huySaoLuu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBackupDB_Load(object sender, EventArgs e)
        {
            this.Text = "Sao lưu dữ liệu";
        }
    }
}

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
    public partial class frmTaoLogin : Form
    {
        private string connectionString;
        public frmTaoLogin(string connectionString)
        {
            this.connectionString = connectionString;
            InitializeComponent();
        }

        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            this.Text = "Tạo login";
        }

        private void btn_addLogin_Click(object sender, EventArgs e)
        {
            if (txb_login.Text.Trim() == "" || txb_password.Text.Trim() == "" || txb_rePassword.Text.Trim() == "" || txb_userName.Text.Trim() == "" || cbb_role.Text.Trim() == "")       
            {
                MessageBox.Show("Không được bỏ trống các ô", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string loginName = txb_login.Text;
            string password = txb_password.Text;
            string rePassword = txb_rePassword.Text;
            string userName = txb_userName.Text;
            string role = cbb_role.Text;

            // Kiểm tra mật khẩu có khớp hay không
            if (password != rePassword)
            {
                MessageBox.Show("Mật khẩu không giống nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Thực thi stored procedure
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SP_CreateHospitalLogin", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@LGNAME", loginName);
                    command.Parameters.AddWithValue("@PASS", password);
                    command.Parameters.AddWithValue("@USERNAME", userName);
                    command.Parameters.AddWithValue("@ROLE", role);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Tạo login thành công.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm tên đăng nhập và user.\nLỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exitAddLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

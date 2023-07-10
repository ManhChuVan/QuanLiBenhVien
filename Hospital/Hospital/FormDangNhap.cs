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
    public partial class FormDangNhap : Form
    {
        
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            if (tb_TaiKhoan.Text.Trim() == "" || tb_MatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không thể bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string taiKhoan = tb_TaiKhoan.Text;
            string matKhau = tb_MatKhau.Text;
            string connectionString = "Data Source=ADMIN\\SERVER0;Initial Catalog=HOSPITAL;User ID=" + taiKhoan + ";Password=" + matKhau;
            string currentRole;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT dbo.GetUserRole()", connection);
                    currentRole = command.ExecuteScalar().ToString();
                    
                   // MessageBox.Show("Kết nối thành công", "Thông báo", MessageBoxButtons.OK);
                    // Kết nối thành công, chuyển đến form trang chủ
                    FormTrangChu formTrangChu = new FormTrangChu(connectionString, currentRole);
                    formTrangChu.Show();

                    // Đóng form hiện tại (form đăng nhập)
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                // Kết nối không thành công, hiển thị thông báo lỗi
                MessageBox.Show("Kết nối không thành công: " + ex.Message);
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            this.Text = "Đăng nhập";
        }

      
    }
}

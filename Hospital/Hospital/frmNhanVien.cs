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
    public partial class frmNhanVien : Form
    {
        private string cellValue;
        private string connectionString;
        private bool isAdding;
        private DataGridView dgv_NhanVienBV;
        private RefreshDGV refreshDGV;
        public frmNhanVien(string cellValue, string connectionString, bool isAdding, DataGridView dgv_NhanVienBV)
        {
            this.cellValue = cellValue;
            this.isAdding = isAdding;
            this.connectionString = connectionString;
            this.dgv_NhanVienBV = dgv_NhanVienBV;
           
            InitializeComponent();
            refreshDGV = new RefreshDGV(connectionString);
        }
        
        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectNV @MaNV";

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
                        txb_MaNV.Text = reader["Mã Nhân Viên"].ToString();
                        txb_TenNV.Text = reader["Họ tên"].ToString();
                        cbb_ChucVuNV.Text = reader["Chức vụ"].ToString();
                        txb_PhaiNV.Text = reader["Phái"].ToString();
                        txb_SDTNV.Text = reader["SDT"].ToString();
                        txb_CCCDNV.Text = reader["CCCD"].ToString();
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

      
        
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cellValue))
            {
                this.Text = "Thêm mới nhân viên";
                txb_MaNV.Visible = false;
                label7.Visible = false;
            }
            else
            {
                cbb_ChucVuNV.Enabled = false;
                this.Text = "Cập nhật thông tin nhân viên";
                LoadData(cellValue);
            }

        }

      

        private void btn_ApDungNV_Click(object sender, EventArgs e)
        {
            if (txb_TenNV.Text.Trim() == "" || cbb_ChucVuNV.Text.Trim() == "" || txb_PhaiNV.Text.Trim() == "" ||
                txb_SDTNV.Text.Trim() == "" || txb_CCCDNV.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            // Lấy dữ liệu từ các textbox
            string maNV = txb_MaNV.Text;
            string tenNV = txb_TenNV.Text;
            string chucVu = cbb_ChucVuNV.Text;
            string phai = txb_PhaiNV.Text;
            string sdt = txb_SDTNV.Text;
            string cccd = txb_CCCDNV.Text;

            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemMoiNV", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@TenNV", tenNV);
                        command.Parameters.AddWithValue("@ChucVu", chucVu);
                        command.Parameters.AddWithValue("@Phai", phai);
                        command.Parameters.AddWithValue("@SDT", sdt);
                        command.Parameters.AddWithValue("@CCCD", cccd);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới thông tin nhân viên thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_ThongTinNhanVien", dgv_NhanVienBV);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới thông tin nhân viên. \nLỗi: " + ex.Message);
                }
                
            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatNV", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaNV", maNV);
                        command.Parameters.AddWithValue("@TenNV", tenNV);
                        command.Parameters.AddWithValue("@ChucVu", chucVu);
                        command.Parameters.AddWithValue("@Phai", phai);
                        command.Parameters.AddWithValue("@SDT", sdt);
                        command.Parameters.AddWithValue("@CCCD", cccd);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin nhân viên thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_ThongTinNhanVien", dgv_NhanVienBV);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin nhân viên: " + ex.Message);
                }

                
            }
            
        }
        private void btn_HuyApDungNV_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

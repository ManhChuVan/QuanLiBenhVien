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
    public partial class frmVatTu : Form
    {
        private string cellValue;
        private string connectionString;
        private bool isReadOnly;
        private bool isAdding;
        private DataGridView dgv_VatTu;
        private RefreshDGV refreshDGV;

        public frmVatTu(string cellValue, string connectionString, bool isReadOnly, bool isAdding, DataGridView dgv_VatTu)
        {
            this.cellValue = cellValue;
            this.connectionString = connectionString;
            this.isReadOnly = isReadOnly;
            this.isAdding = isAdding;
            this.dgv_VatTu = dgv_VatTu;

            InitializeComponent();
            refreshDGV = new RefreshDGV(connectionString);
        }

        private void frmVatTu_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cellValue))
            {
                this.Text = "Thêm mới Vật tư";
                //ẨN
                txb_MaVatTu.Visible = false;
                label2.Visible = false;
            }
            else
            {
                this.Text = "Cập nhật thông tin vật tư";
                LoadData(cellValue);
            }

        }

        private void LoadData(string cellValue)
        {
            string query = "EXEC sp_SelectVatTu @MaVT";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaVT", cellValue);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        txb_MaVatTu.Text = reader["Mã Vật Tư"].ToString();
                        txb_DonGiaVT.Text = reader["Đơn Giá"].ToString();
                        txb_DacTaVT.Text = reader["Đặc Tả Vật Tư"].ToString();
                        cbb_LoaiVT.Text = reader["Loại Vật Tư"].ToString();

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

        private void btn_ADVatTu_Click(object sender, EventArgs e)
        {
            if (txb_DacTaVT.Text.Trim() == "" || txb_DonGiaVT.Text.Trim() == "" || cbb_LoaiVT.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string maVatTu = txb_MaVatTu.Text;
            string donGia = txb_DonGiaVT.Text;
            string dacTa = txb_DacTaVT.Text;
            string loaiVT = cbb_LoaiVT.Text;
            if (isAdding)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_ThemVatTu", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@DonGia", donGia);
                        command.Parameters.AddWithValue("@DacTa", dacTa);
                        command.Parameters.AddWithValue("@LoaiVT", loaiVT);



                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Thêm mới vật tư thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_VatTuDangDuocSuDung", dgv_VatTu);
                    }       
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm mới vật tư. \n\nLỗi: " + ex.Message);
                }

            }
            else
            {
                // Thực hiện gọi stored procedure và cập nhật dữ liệu
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand("sp_CapNhatVatTu", connection);
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@MaVT", maVatTu);
                        command.Parameters.AddWithValue("@DonGia", donGia);
                        command.Parameters.AddWithValue("@DacTa", dacTa);
                        command.Parameters.AddWithValue("@LoaiVT", loaiVT);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();

                        MessageBox.Show("Cập nhật thông tin vật tư thành công.");
                        this.Close();
                        refreshDGV.Refresh_DGV("vw_VatTuDangDuocSuDung", dgv_VatTu);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật thông tin vật tư: " + ex.Message);
                }

            }
        }

        private void btn_HuyADVatTu_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}

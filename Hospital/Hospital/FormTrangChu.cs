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
    public partial class FormTrangChu : Form
    {
        //private string connectionString;
        public string ConnectionString { get; set; }
        public string currentRole { get; set; }

        private string currentView = ""; // Biến để lưu trữ view hiện tại
        private RefreshDGV refreshDGV;
        public FormTrangChu(string ConnectionString, string currentRole)
        {
            InitializeComponent();

            this.ConnectionString = ConnectionString;
            this.currentRole = currentRole;
            tabCtr_CSVC.SelectedIndexChanged += tabCtr_KCT_SelectedIndexChanged;
            tabCtrl_QuanLiChuaTri.SelectedIndexChanged += tabCtrl_QuanLiChuaTri_SelectedIndexChanged;
            tabCtrl_QLBV.SelectedIndexChanged += tabCtrl_QLBV_SelectedIndexChanged;
            tabCtrl_QLBN.SelectedIndexChanged += tabCtrl_QLBN_SelectedIndexChanged;
            tabCtrl_QLNhanVien.SelectedIndexChanged += tabCtrl_QLNhanVien_SelectedIndexChanged;

            refreshDGV = new RefreshDGV(ConnectionString);
        }  
     
        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            ConnectionString = null;

            // Đóng Form hiện tại
            this.Close();

            // Khởi tạo và hiển thị lại Form Đăng nhập
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.ShowDialog();
        }

        private void TimKiem(TextBox txb, string sp, DataGridView dgv)
        {
            if (txb.Text.Trim() == "")
            {
                MessageBox.Show("Không được bỏ trống ô tìm kiếm", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string keyword = txb.Text;

            // Gọi stored procedure sp_TimKiemNhanVien để tìm kiếm nhân viên
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(sp, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@keyword", keyword);

                    connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    dgv.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void Xoa(DataGridView dgv, string valueCell, string sp, string valueSP, string view)
        {
            if (dgv.SelectedRows.Count > 0)
            {

                // Lấy giá trị của cột từ hàng được chọn
                string valueDelete = dgv.SelectedRows[0].Cells[valueCell].Value.ToString();
                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã chọn "Xóa" hay "Hủy"
                if (result == DialogResult.Yes)
                {
                    // Thực hiện gọi stored procedure để xóa
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            SqlCommand command = new SqlCommand(sp, connection);
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue(valueSP, valueDelete);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("Xóa thành công.");
                            refreshDGV.Refresh_DGV(view, dgv);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa.\n\nLỗi: " + ex.Message);
                    }

                }
            }
        }


        //**********************************************
        private void tabCtrl_QLNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl_QLNhanVien.SelectedTab.Text == "Nhân Viên")
            {
                currentView = "vw_ThongTinNhanVien";
                LoadDataForCurrentView();
            }
            if (tabCtrl_QLNhanVien.SelectedTab.Text == "Bác Sĩ")
            {
                currentView = "vw_ThongTinBacSi";
                LoadDataForCurrentView();
            }
            if (tabCtrl_QLNhanVien.SelectedTab.Text == "Y Tá")
            {
                currentView = "vw_ThongTinYTa";
                LoadDataForCurrentView();
            }
        }

        
        //*****************************************************
        private void tabCtr_KCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtr_CSVC.SelectedTab.Text == "Khu Chữa Trị")
            {
                currentView = "vw_ThongTinKhuChuaTri";
                LoadDataForCurrentView();
            }
            if (tabCtr_CSVC.SelectedTab.Text == "Phòng")
            {
                currentView = "vw_Phong_ConHoatDong";
                LoadDataForCurrentView();
            }
            if (tabCtr_CSVC.SelectedTab.Text == "Giường")
            {
                currentView = "vw_Giuong";
                LoadDataForCurrentView();
            }
            if (tabCtr_CSVC.SelectedTab.Text == "Vật Tư")
            {
                currentView = "vw_VatTuDangDuocSuDung";
                LoadDataForCurrentView();
            }
            if (tabCtr_CSVC.SelectedTab.Text == "Sự Chữa Trị")
            {
                currentView = "vw_SuChuaTri";
                LoadDataForCurrentView();
            }
        }

        private void LoadDataForCurrentView()
        {
            string query = "SELECT * FROM " + currentView;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    switch (currentView)
                    {
                        case "vw_ThongTinNhanVien":
                            dgv_NhanVienBV.DataSource = dataTable;
                            break;
                        case "vw_ThongTinBacSi":
                            dgv_BacSi.DataSource = dataTable;
                            break;
                        case "vw_ThongTinYTa":
                            dgv_YTa.DataSource = dataTable;
                            break;
                        case "vw_ThongTinBenhNhanDangDieuTri":
                            dgv_BN.DataSource = dataTable;
                            break;
                        case "vw_ThongTinBenhNhanNoiTru":
                            dgv_BNNoiTru.DataSource = dataTable;
                            break;
                        case "vw_ThongTinBenhNhanNgoaiTru":
                            dgv_BNNgoaiTru.DataSource = dataTable;
                            break;
                        case "vw_ThongTinKhuChuaTri":
                            dgv_KCT.DataSource = dataTable;
                            break;
                        case "vw_Phong_ConHoatDong":
                            dgv_Phong.DataSource = dataTable;
                            break;
                        case "vw_Giuong":
                            dgv_Giuong.DataSource = dataTable;
                            break;
                        case "vw_VatTuDangDuocSuDung":
                            dgv_VatTu.DataSource = dataTable;                
                            break;
                        case "vw_SuChuaTri":
                            dgv_SuChuaTri.DataSource = dataTable;
                            break;
                        case "vw_SDVT_All":
                            dgv_SDVT.DataSource = dataTable;
                            break;
                        case "vw_CuocDieuTri_All":
                            dgv_CuocDieuTri.DataSource = dataTable;
                            break;
                        case "vw_ThongTinGioLamNV":
                            dgv_TKGL.DataSource = dataTable;
                            break;
                        case "GetTongHopVienPhi()":
                            dgv_ChiTietTongTienSDVT.DataSource = dataTable;
                            break;
                        default:
                            MessageBox.Show("View không hợp lệ");
                            return;
                    }

                }
            }
            catch (Exception ex)
            {
                // Kết nối không thành công, hiển thị thông báo lỗi
                MessageBox.Show("Không thực thi thành công: " + ex.Message);
            }
        }

        private void dgv_KCT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string columnName = "Mã Khu";
            string cellValue = dgv_KCT.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            new frmKhuChuaTri(cellValue, ConnectionString,true, false, dgv_KCT).ShowDialog();
        }

        private void btn_rfKCT_Click(object sender, EventArgs e)
        {
            currentView = "vw_ThongTinKhuChuaTri";
            LoadDataForCurrentView();
        }

        private void btn_TimKCT_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimKCT, "sp_TimKiemKCT", dgv_KCT);          
        }

        private void btn_ThemKCT_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmKhuChuaTri(null, ConnectionString, false, true, dgv_KCT).ShowDialog();
        }

        private void btn_XoaKCT_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Xoa(dgv_KCT, "Mã Khu", "sp_XoaKhuChuaTri", "@MaKhuCT", "vw_ThongTinKhuChuaTri");     
        }

        /////////////////////////////
        private void dgv_Phong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string columnName = "Mã Phòng";
            string cellValue = dgv_Phong.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            new frmPhong(cellValue, ConnectionString, true, false, dgv_Phong).ShowDialog();
        }

        private void btn_rfPhong_Click(object sender, EventArgs e)
        {
            currentView = "vw_Phong_ConHoatDong";
            LoadDataForCurrentView();
        }

        private void btn_ThemPhong_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmPhong(null, ConnectionString, false, true, dgv_Phong).ShowDialog();
        }

        private void btn_TimPhong_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimPhong, "sp_TimKiemPhong", dgv_Phong);             
        }

        private void btn_XoaPhong_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Xoa(dgv_Phong, "Mã Phòng", "sp_XoaPhong", "@MaPhong", "vw_Phong_ConHoatDong");       
        }

       
        //---------------------------------------

        private void dgv_Giuong_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string columnName = "Mã Giường";
            // Lấy giá trị trong cột tương ứng
            string cellValue = dgv_Giuong.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue);
            new frmGiuong(cellValue, ConnectionString, true, false, dgv_Giuong).ShowDialog();
        }

        private void btn_rfGiuong_Click(object sender, EventArgs e)
        {
            currentView = "vw_Giuong";
            LoadDataForCurrentView();
        }

        private void btn_TimGiuong_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimGiuong, "sp_TimKiemGiuong", dgv_Giuong);          
        }

        private void btn_ThemGiuong_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmGiuong(null, ConnectionString, false, true, dgv_Giuong).ShowDialog();
        }

        private void btn_XoaGiuong_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Xoa(dgv_Giuong, "Mã Giường", "sp_XoaGiuong", "@MaGiuong", "vw_Giuong"); 
        }

        
    
        //----------------------------------------------------
        private void dgv_VatTu_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRole == "Doctor_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string columnName = "Mã Vật Tư";
            string cellValue = dgv_VatTu.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            new frmVatTu(cellValue, ConnectionString, true, false, dgv_VatTu).ShowDialog();
            
        }

        private void btn_rfVatTu_Click(object sender, EventArgs e)
        {
            currentView = "vw_VatTuDangDuocSuDung";
            LoadDataForCurrentView();
        }

        private void btn_TimVT_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimVT, "sp_TimKiemVatTu", dgv_VatTu);        
        }

        private void btn_ThemVT_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" )
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmVatTu(null, ConnectionString, false, true, dgv_VatTu).ShowDialog();
        }

        private void btn_XoaVT_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Xoa(dgv_VatTu, "Mã Vật Tư", "sp_XoaVatTu", "@MaVT", "vw_VatTuDangDuocSuDung");         
        }

        //-------------------------------
        private void dgv_SuChuaTri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string columnName = "Mã sự chữa trị";
            string cellValue = dgv_SuChuaTri.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue);
            new frmSuChuaTri(cellValue, ConnectionString, false, dgv_SuChuaTri).ShowDialog();
        }

        private void btn_rfSCT_Click(object sender, EventArgs e)
        {
            currentView = "vw_SuChuaTri";
            LoadDataForCurrentView();
        }

        private void btn_TimSCT_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimSCT, "sp_TimKiemSuChuaTri", dgv_SuChuaTri);           
        }

        private void btn_ThemSCT_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmSuChuaTri(null, ConnectionString, true, dgv_SuChuaTri).ShowDialog();
        }

        private void btn_XoaSCT_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Xoa(dgv_SuChuaTri, "Mã sự chữa trị", "sp_XoaSuChuaTri", "@MaCT", "vw_SuChuaTri");          
        }


        //----------------------------------------------


        private void tabCtrl_QuanLiChuaTri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl_QuanLiChuaTri.SelectedTab.Text == "Sử dụng vật tư")
            {
                currentView = "vw_SDVT_All";
                LoadDataForCurrentView();
            }
            if (tabCtrl_QuanLiChuaTri.SelectedTab.Text == "Cuộc điều trị")
            {
                currentView = "vw_CuocDieuTri_All";
                LoadDataForCurrentView();
            }
           
        }
        //---
        private void dgv_SDVT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = "ID_SDVT";
            string cellValue = dgv_SDVT.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue);
            new frmSDVT(cellValue, ConnectionString, false, dgv_SDVT).ShowDialog();
        }

        private void btn_rfSDVT_Click(object sender, EventArgs e)
        {
            currentView = "vw_SDVT_All";
            LoadDataForCurrentView();
        }
        private void btn_TimSDVT_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimSDVT, "sp_TimKiemSDVT", dgv_SDVT);           
        }

        private void btn_ThemSDVT_Click(object sender, EventArgs e)
        {
            new frmSDVT(null, ConnectionString, true, dgv_SDVT).ShowDialog();
        }

        private void btn_XoaSDVT_Click(object sender, EventArgs e)
        {
            Xoa(dgv_SDVT, "ID_SDVT", "sp_XoaSuDungVatTu", "@ID_SDVT", "vw_SDVT_All");       
        }
        //-------------------
        private void dgv_CuocDieuTri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = "ID_CDT";
            string cellValue = dgv_CuocDieuTri.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue);
            new frmCuocDieuTri(cellValue, ConnectionString, false, dgv_CuocDieuTri).ShowDialog();
        }

        private void btn_rfCDT_Click(object sender, EventArgs e)
        {
            currentView = "vw_CuocDieuTri_All";
            LoadDataForCurrentView();
        }

        private void btn_TimCDT_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimCDT, "sp_TimKiemCuocDieuTri", dgv_CuocDieuTri);         
        }

        private void btn_ThemCDT_Click(object sender, EventArgs e)
        {
            new frmCuocDieuTri(null, ConnectionString, true, dgv_CuocDieuTri).ShowDialog();
        }

        private void btn_XoaCDT_Click(object sender, EventArgs e)
        {
            Xoa(dgv_CuocDieuTri, "ID_CDT", "sp_XoaCuocDieuTri", "@ID_CDT", "vw_CuocDieuTri_All");            
        }
        //-------------------------------------------------
        private bool isRoleMessageDisplayed = false; // Thêm biến cờ
        private bool isRoleMessageDisplayed2 = false;
        private void tabCtrl_QLBV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl_QLBV.SelectedTab.Text == "Quản lí giờ làm")
            {
                if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
                {
                    if (!isRoleMessageDisplayed) // Kiểm tra xem thông báo đã được hiển thị hay chưa
                    {
                        MessageBox.Show("Bạn không có quyền xem mục này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabPage7.Enabled = false;
                        isRoleMessageDisplayed = true; // Đánh dấu thông báo đã được hiển thị
                    }
                    return;
                }
                currentView = "vw_ThongTinGioLamNV";
                LoadDataForCurrentView();
            }

            if (tabCtrl_QLBV.SelectedTab.Text == "Thống kê")
            {
                if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
                {
                    if (!isRoleMessageDisplayed2) // Kiểm tra xem thông báo đã được hiển thị hay chưa
                    {
                        MessageBox.Show("Bạn không có quyền xem mục này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabPage18.Enabled = false;
                        isRoleMessageDisplayed2 = true; // Đánh dấu thông báo đã được hiển thị
                    }
                    return;
                }

                currentView = "GetTongHopVienPhi()";
                LoadQuantity("SELECT dbo.GetSoLuongNhanVien()", txb_slnv);
                LoadQuantity("SELECT dbo.GetSoLuongBacSi()", txb_slbs);
                LoadQuantity("SELECT dbo.GetSoLuongYTa()", txb_slyt);
                LoadQuantity("SELECT dbo.GetSoLuongBenhNhan()", txb_slbn);
                LoadQuantity("SELECT dbo.GetSoLuongBenhNhanNoiTru()", txb_slbnnoi);
                LoadQuantity("SELECT dbo.GetSoLuongBenhNhanNgoaiTru()", txb_slbnngoai);

                LoadQuantity("SELECT dbo.GetSoLuongKhuChuaTri()", txb_slkct);
                LoadQuantity("SELECT dbo.GetSoLuongGiuong()", txb_slg);
                LoadQuantity("SELECT dbo.GetSoLuongPhong()", txb_slp);
                LoadQuantity("SELECT dbo.GetSoLuongVatTu()", txb_slvt);
                LoadQuantity("SELECT dbo.GetSoLuongSuChuaTri()", txb_slsct);

                LoadSumMoney("SELECT dbo.TongTienSDVT()", txb_tongTienSDVT);
                LoadSumMoney("SELECT dbo.TongTienSDVT_BNdxv()", txb_tienSDVT_BNdxv);
                LoadSumMoney("SELECT dbo.TongTienSDVT_BNddt()", txb_tienSDVT_BNddt);

                LoadDataForCurrentView();
            }
        }

        private void LoadQuantity(string query, TextBox tb)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                // Đọc kết quả từ câu lệnh SELECT và gán vào TextBox
                int result = (int)command.ExecuteScalar();
                tb.Text = result.ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                MessageBox.Show("Không thực thi thành công. \n\nLỗi:" + ex.Message);
                
            }
            
        }

        private void LoadSumMoney(string query, TextBox tb)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                // Đọc kết quả từ câu lệnh SELECT và gán vào TextBox
                decimal result = (decimal)command.ExecuteScalar();
                tb.Text = result.ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                MessageBox.Show("Không thực thi thành công. \n\nLỗi:" + ex.Message);
                
            }

            
        }

        private void dgv_TKGL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRole == "Doctor_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string columnName1 = "Mã NV";
            string columnName2 = "Mã Khu";
            string cellValue = dgv_TKGL.Rows[e.RowIndex].Cells[columnName1].Value.ToString();
            string cellValue2 = dgv_TKGL.Rows[e.RowIndex].Cells[columnName2].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue + "và " + cellValue2);
            new frmTKGL(cellValue, cellValue2, ConnectionString, false, dgv_TKGL).ShowDialog();
        }

        private void btn_rfQLGL_Click(object sender, EventArgs e)
        {
            currentView = "vw_ThongTinGioLamNV";
            LoadDataForCurrentView();
        }

        private void btn_TimTKGL_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimTKGL, "sp_TimKiemTKGL", dgv_TKGL);      
        }

        private void btn_ThemTKGL_Click(object sender, EventArgs e)
        {
            new frmTKGL(null, null, ConnectionString, true, dgv_TKGL).ShowDialog();
        }

        private void btn_XoaTKGL_Click(object sender, EventArgs e)
        {

            if (dgv_TKGL.SelectedRows.Count > 0)
            {

                // Lấy giá trị của cột từ hàng được chọn
                string maNV = dgv_TKGL.SelectedRows[0].Cells["Mã NV"].Value.ToString();
                string maKhu = dgv_TKGL.SelectedRows[0].Cells["Mã Khu"].Value.ToString();
                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa CDT này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra xem người dùng đã chọn "Xóa" hay "Hủy"
                if (result == DialogResult.Yes)
                {
                    // Thực hiện gọi stored procedure để xóa
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(ConnectionString))
                        {
                            SqlCommand command = new SqlCommand("sp_XoaTKGL", connection);
                            command.CommandType = CommandType.StoredProcedure;

                            command.Parameters.AddWithValue("@MaNV", maNV);
                            command.Parameters.AddWithValue("@MaKhu", maKhu);

                            connection.Open();
                            command.ExecuteNonQuery();
                            connection.Close();

                            MessageBox.Show("Xóa TKGL thành công.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa TKGL.\n\nLỗi: " + ex.Message);
                    }

                }
               
            }
        }
        //****************************
        private void tabCtrl_QLBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl_QLBN.SelectedTab.Text == "Bệnh nhân")
            {
                currentView = "vw_ThongTinBenhNhanDangDieuTri";
                LoadDataForCurrentView();
            }
            if (tabCtrl_QLBN.SelectedTab.Text == "BN Nội Trú")
            {
                currentView = "vw_ThongTinBenhNhanNoiTru";
                LoadDataForCurrentView();
            }
            if (tabCtrl_QLBN.SelectedTab.Text == "BN Ngoại Trú")
            {
                currentView = "vw_ThongTinBenhNhanNgoaiTru";
                LoadDataForCurrentView();
            }
        }


        //*****************************
        private void dgv_BN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = "Mã BN";
            string cellValue = dgv_BN.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue);
            new frmBenhNhan(cellValue, ConnectionString, false, dgv_BN).ShowDialog();
        }

        private void btn_rfBN_Click(object sender, EventArgs e)
        {
            currentView = "vw_ThongTinBenhNhanDangDieuTri";
            LoadDataForCurrentView();
        }
        private void btn_TimBN_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimBN, "sp_TimKiemBenhNhan", dgv_BN);
                       
        }

        private void btn_ThemMoiBN_Click(object sender, EventArgs e)
        {          
            new frmBenhNhan(null, ConnectionString, true, dgv_BN).ShowDialog();
        }

        private void btn_XoaBenhNhan_Click(object sender, EventArgs e)
        {
           
            Xoa(dgv_BN, "Mã BN", "sp_XoaBenhNhan", "@MaBN", "vw_ThongTinBenhNhanDangDieuTri");
        }

      

        //*************************

        private void dgv_BNNoiTru_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = "Mã BN";
            string cellValue = dgv_BNNoiTru.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue);
            new frmBNNoiTru(cellValue, ConnectionString, dgv_BNNoiTru).ShowDialog();
        }

        private void btn_rfBNnoi_Click(object sender, EventArgs e)
        {
            currentView = "vw_ThongTinBenhNhanNoiTru";
            LoadDataForCurrentView();
        }

        private void btn_TimBNNoiTru_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimBNNoiTru, "sp_TimKiemBenhNhanNoiTru", dgv_BNNoiTru);
            
        }

        private void btn_ThemBNNoiTru_Click(object sender, EventArgs e)
        {
            new frmBenhNhan(null, ConnectionString, true, dgv_BN).ShowDialog();
        }

        private void btn_XoaBNNT_Click(object sender, EventArgs e)
        {
           
            Xoa(dgv_BNNoiTru, "Mã BN", "sp_XoaBenhNhan", "@MaBN", "vw_ThongTinBenhNhanNoiTru");       
        }
     
        //**************************************************
        private void dgv_BNNgoaiTru_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = "Mã BN";
            string cellValue = dgv_BNNgoaiTru.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue);
            new frmBNNgoaiTru(cellValue, ConnectionString, dgv_BNNgoaiTru).ShowDialog();            
        }

        private void btn_rfBNngoai_Click(object sender, EventArgs e)
        {
            currentView = "vw_ThongTinBenhNhanNgoaiTru";
            LoadDataForCurrentView();
        }

        private void btn_TimBNNgoaiTru_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimBNNgoaiTru, "sp_TimKiemBenhNhanNgoaiTru", dgv_BNNgoaiTru);
            
        }

        private void btn_ThemNgoaiTru_Click(object sender, EventArgs e)
        {
            new frmBenhNhan(null, ConnectionString, true, dgv_BN).ShowDialog();
        }

        private void btn_XoaNgoaiTru_Click(object sender, EventArgs e)
        {        
            Xoa(dgv_BNNgoaiTru, "Mã BN", "sp_XoaBenhNhan", "@MaBN", "vw_ThongTinBenhNhanNgoaiTru");
        }
        //*****************************************
        private void dgv_NhanVienBV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện chỉnh sửa thông tin Nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string columnName = "Mã Nhân Viên";
            string cellValue = dgv_NhanVienBV.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue);
            new frmNhanVien(cellValue, ConnectionString, false, dgv_NhanVienBV).ShowDialog();
        }

        private void btn_TimNV_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimNV, "sp_TimKiemNhanVien", dgv_NhanVienBV);
        }

        private void btn_ThemMoiNV_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmNhanVien(null, ConnectionString, true, dgv_NhanVienBV).ShowDialog();

        }

        private void btn_XoaNVBV_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Xoa(dgv_NhanVienBV, "Mã Nhân Viên", "sp_XoaNhanVien", "@MaNV", "vw_ThongTinNhanVien");
        
        }

        private void btn_rf_Click(object sender, EventArgs e)
        {
            currentView = "vw_ThongTinNhanVien";
            LoadDataForCurrentView();
        }

        //***********************************************

        private void dgv_BacSi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string columnName = "Mã Bác Sĩ";
            string cellValue = dgv_BacSi.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            //MessageBox.Show("Giá trị được chọn: " + cellValue);
            new frmBacSi(cellValue, ConnectionString, dgv_BacSi).ShowDialog();
        }

        private void btn_TimBacSi_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimBacSi, "sp_TimKiemBacSi", dgv_BacSi);
        }
     
        private void btn_ThemNVbsi_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmNhanVien(null, ConnectionString, true, dgv_NhanVienBV).ShowDialog();
        }

        private void btn_XoaNVbsi_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Xoa(dgv_BacSi, "Mã Bác Sĩ", "sp_XoaNhanVien", "@MaNV", "vw_ThongTinBacSi");
        }

        private void btn_rfBsi_Click(object sender, EventArgs e)
        {
            currentView = "vw_ThongTinBacSi";
            LoadDataForCurrentView();
        }
  
     //******************************

        private void dgv_YTa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string columnName = "Mã Y Tá";
            string cellValue = dgv_YTa.Rows[e.RowIndex].Cells[columnName].Value.ToString();

            new frmYTa(cellValue, ConnectionString, dgv_YTa).ShowDialog();
        }

        private void btn_TimYTa_Click(object sender, EventArgs e)
        {
            TimKiem(txb_TimYTa, "sp_TimKiemYTa", dgv_YTa);
        }

        private void btn_ThemNVyta_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmNhanVien(null, ConnectionString, true, dgv_NhanVienBV).ShowDialog();
        }

        private void btn_XoaNVyta_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Xoa(dgv_YTa, "Mã Y Tá", "sp_XoaNhanVien", "@MaNV", "vw_ThongTinYTa");
        }

        private void btn_rfYTa_Click(object sender, EventArgs e)
        {
            currentView = "vw_ThongTinYTa";
            LoadDataForCurrentView();
        }

       

        private void btn_CreateLogin_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmTaoLogin(ConnectionString).ShowDialog();
        }

        private void dgv_ChiTietTongTienSDVT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string columnName = "Mã Bệnh Nhân";
                string cellValue = dgv_ChiTietTongTienSDVT.Rows[e.RowIndex].Cells[columnName].Value.ToString();

                //MessageBox.Show("Giá trị được chọn: " + cellValue);
                new frmChiTietSDVT(cellValue, ConnectionString).ShowDialog();
            }
            catch (Exception ex)
            {
                // Xử lý exception nếu cần thiết
                MessageBox.Show("Không thực thi thành công. \n\nLỗi:" + ex.Message);
                this.Close();
            }
        }

        private void FormTrangChu_Load(object sender, EventArgs e)
        {
            switch (currentRole)
            {            
                case "Doctor_Role":
                    txb_roleUser.Text = "Bác sĩ";
                    break;
                case "Nurse_Role":
                    txb_roleUser.Text = "Y Tá";
                    break;
                case "Head_Nurse_Role":
                    txb_roleUser.Text = "Y Tá Trưởng";
                    break;
                default:
                    txb_roleUser.Text = "Quản trị viên";
                    return;
            }
            this.Text = "Quản lí bệnh viện";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmBackupDB(ConnectionString).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currentRole == "Doctor_Role" || currentRole == "Nurse_Role" || currentRole == "Head_Nurse_Role")
            {
                MessageBox.Show("Bạn không có quyền thực hiện hành động này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new frmRestoreDB(ConnectionString).ShowDialog();
        }

    }
}

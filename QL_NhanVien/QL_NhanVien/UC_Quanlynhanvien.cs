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

namespace QL_NhanVien
{
    public partial class UC_Quanlynhanvien : UserControl
    {
        public UC_Quanlynhanvien()
        {
            InitializeComponent();
        }
        private void LoadDanhSachSinhVien()
        {
            string sql = "SELECT * FROM NhanVien";
            Database db = new Database();
           dgvNhanvien.DataSource = db.ExecuteQuery(sql);
        }

        private void LoadDanhSachNhanVienTheoCongViec(string tenCV)
        {
            string sql = "SELECT * FROM dbo.fn_DanhSachNhanVienTheoTenCongViec(@TenCV)";
            SqlParameter[] parameters = { new SqlParameter("@TenCV", tenCV) };
            Database db = new Database();
            dgvNhanvientheocongviec.DataSource = db.ExecuteQuery(sql, parameters);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(txtHoten.Text) || string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            SqlParameter[] parameters = {
        new SqlParameter("@HoTen", txtHoten.Text),
        new SqlParameter("@DiaChi", txtDiachi.Text),
        new SqlParameter("@NgaySinh", dtpNgaysinh.Value),
        new SqlParameter("@Email", txtEmail.Text),
        new SqlParameter("@SDT", txtSoDT.Text),
        new SqlParameter("@MaTK", txtMaTK.Text),
        new SqlParameter("@MaCV", txtMaCV.Text)
    };

            try
            {
                Database db = new Database();
                int rows = db.ExecuteStoredProc("sp_ThemNhanVien", parameters);
                if (rows > 0)
                {
                    MessageBox.Show("✅ Thêm nhân viên thành công!");
                    LoadDanhSachSinhVien();  // Tải lại danh sách nhân viên
                    LoadDanhSachNhanVienTheoCongViec(cboTencongviec.SelectedItem.ToString());
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("⚠️ Thêm nhân viên thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(txtHoten.Text) || string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            SqlParameter[] parameters = {
        new SqlParameter("@MaNV", dgvNhanvien.SelectedRows[0].Cells["MaNV"].Value),
        new SqlParameter("@HoTen", txtHoten.Text),
        new SqlParameter("@DiaChi", txtDiachi.Text),
        new SqlParameter("@NgaySinh", dtpNgaysinh.Value),
        new SqlParameter("@Email", txtEmail.Text),
        new SqlParameter("@SDT", txtSoDT.Text),
        new SqlParameter("@MaCV", txtMaCV.Text)
    };

            try
            {
                Database db = new Database();
                int rows = db.ExecuteStoredProc("sp_CapNhatNhanVien", parameters);
                if (rows > 0)
                {
                    MessageBox.Show("✅ Cập nhật thông tin nhân viên thành công!");
                    LoadDanhSachSinhVien();  // Tải lại danh sách nhân viên
                    LoadDanhSachNhanVienTheoCongViec(cboTencongviec.SelectedItem.ToString());
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("⚠️ Cập nhật thất bại.");
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanvien.SelectedRows.Count == 0)
            {
                MessageBox.Show("⚠️ Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            int maNV = Convert.ToInt32(dgvNhanvien.SelectedRows[0].Cells["MaNV"].Value);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlParameter[] parameters = {
            new SqlParameter("@MaNV", maNV)
        };

                try
                {
                    Database db = new Database();
                    int rows = db.ExecuteStoredProc("sp_XoaNhanVien", parameters);
                    if (rows > 0)
                    {
                        MessageBox.Show("🗑️ Xóa nhân viên thành công!");
                        LoadDanhSachSinhVien();  // Tải lại danh sách nhân viên
                        LoadDanhSachNhanVienTheoCongViec(cboTencongviec.SelectedItem.ToString());
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("⚠️ Xóa nhân viên thất bại.");
                    }
                }
                catch (Exception ex )
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void ClearForm()
        {
            txtHoten.Clear();
            txtDiachi.Clear();
            txtEmail.Clear();
            txtSoDT.Clear();
            txtMaTK.Clear();
            txtMaCV.Clear();
            dtpNgaysinh.Value = DateTime.Now;
        }

        private void UC_Quanlynhanvien_Load(object sender, EventArgs e)
        {
            LoadDanhSachSinhVien();  
          
        }

        private void cboTencongviec_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenCV = cboTencongviec.SelectedItem.ToString();
            LoadDanhSachNhanVienTheoCongViec(tenCV);
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nếu người dùng chọn dòng dữ liệu
            {
                DataGridViewRow row = dgvNhanvien.Rows[e.RowIndex];  // Lấy dòng dữ liệu
                txtHoten.Text = row.Cells["HoTen"].Value?.ToString() ?? ""; // Kiểm tra null trước khi gán
                txtDiachi.Text = row.Cells["DiaChi"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtSoDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";
                txtMaTK.Text = row.Cells["MaTK"].Value?.ToString() ?? "";
                txtMaCV.Text = row.Cells["MaCV"].Value?.ToString() ?? "";

                // Cập nhật ngày sinh cho DateTimePicker nếu giá trị không null
                var ngaySinh = row.Cells["NgaySinh"].Value;
                if (ngaySinh != DBNull.Value)
                {
                    dtpNgaysinh.Value = Convert.ToDateTime(ngaySinh);
                }
                else
                {
                    // Nếu ngày sinh là null, bạn có thể thiết lập giá trị mặc định
                    dtpNgaysinh.Value = DateTime.Now; // Hoặc giá trị mặc định khác
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}

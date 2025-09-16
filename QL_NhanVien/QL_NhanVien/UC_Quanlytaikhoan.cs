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
    public partial class UC_Quanlytaikhoan : UserControl
    {
        Database db = new Database();
        public UC_Quanlytaikhoan()
        {
            InitializeComponent();
        }

        private void UC_Quanlytaikhoan_Load(object sender, EventArgs e)
        {
            
            cboVaiTro.Items.Clear();
            cboVaiTro.Items.Add("QuanLy");
            cboVaiTro.Items.Add("NhanVien");
            cboVaiTro.SelectedIndex = 0;

            LoadDanhSachTaiKhoan();
        }

        private void LoadDanhSachTaiKhoan()
        {
            string sql = "SELECT * FROM TaiKhoan";
            dgvTaiKhoan.DataSource = db.ExecuteQuery(sql);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("❌ Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            SqlParameter[] parameters = {
                new SqlParameter("@TenTK", txtTenTK.Text.Trim()),
                new SqlParameter("@MatKhau", txtMatKhau.Text.Trim()),
                new SqlParameter("@VaiTro", cboVaiTro.SelectedItem.ToString())
            };

            try
            {
                int rows = db.ExecuteStoredProc("sp_ThemTaiKhoan", parameters);
                MessageBox.Show("Thêm tài khoản thành công.");
                LoadDanhSachTaiKhoan();  // Gọi lại hàm LoadDanhSachTaiKhoan() để cập nhật dgv
                ClearForm();
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi: " + ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (dgvTaiKhoan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa.");
                return;
            }

            int maTK = Convert.ToInt32(dgvTaiKhoan.SelectedRows[0].Cells["MaTK"].Value);

            DialogResult r = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                SqlParameter[] parameters = {
                    new SqlParameter("@MaTK", maTK)
                };

                try
                {
                    int rows = db.ExecuteStoredProc("sp_XoaTaiKhoan", parameters);
                    MessageBox.Show("Tài khoản đã được xóa.");
                    LoadDanhSachTaiKhoan();  
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Lỗi: " + ex.Message);
                }
            }
        }
        private void ClearForm()
        {
            txtTenTK.Text = "";
            txtMatKhau.Text = "";
            cboVaiTro.SelectedIndex = 0;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng không click vào tiêu đề cột
            if (e.RowIndex >= 0)
            {
                // Lấy các giá trị từ các cột trong dòng đã chọn
                string tenTaiKhoan = dgvTaiKhoan.Rows[e.RowIndex].Cells[1].Value.ToString();  // Cột Tên tài khoản
                string matKhau = dgvTaiKhoan.Rows[e.RowIndex].Cells[2].Value.ToString();      // Cột Mật khẩu
                string vaiTro = dgvTaiKhoan.Rows[e.RowIndex].Cells[3].Value.ToString();        // Cột Vai trò

                // Gán các giá trị vào các TextBox
                txtTenTK.Text = tenTaiKhoan;
                txtMatKhau.Text = matKhau;
                cboVaiTro.SelectedItem = vaiTro; // Nếu vai trò là combobox
            }
        }

        private void dgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
    }
}

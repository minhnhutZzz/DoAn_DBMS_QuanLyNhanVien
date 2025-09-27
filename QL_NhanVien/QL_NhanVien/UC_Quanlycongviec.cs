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
    public partial class UC_Quanlycongviec : UserControl
    {
        public UC_Quanlycongviec()
        {
            InitializeComponent();
        }
        private void LoadDanhSachCongViec()
        {
            string sql = "SELECT * FROM vw_CongViec";
            Database db = new Database();
            dgvDanhsachcongviec.DataSource = db.ExecuteQuery(sql);
        }   
        private void LoadThongKeSoNhanVienTheoCongViec()
        {
            string sql = "SELECT * FROM dbo.fn_ThongKeSoNhanVienTheoCongViec()";
            Database db = new Database();
            dgvSonhanvientheocongviec.DataSource = db.ExecuteQuery(sql);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UC_Quanlycongviec_Load(object sender, EventArgs e)
        {
            LoadDanhSachCongViec();
            LoadThongKeSoNhanVienTheoCongViec();
        }

        private void btnThemcongviec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTencongviec.Text) || string.IsNullOrEmpty(txtLuongcoban.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin công việc!");
                return;
            }

            string sql = "INSERT INTO CongViec (TenCV, LuongCoBan) VALUES (@TenCV, @LuongCoBan)";
            SqlParameter[] parameters = {
        new SqlParameter("@TenCV", txtTencongviec.Text),
        new SqlParameter("@LuongCoBan", Convert.ToDecimal(txtLuongcoban.Text))
    };

            try
            {
                Database db = new Database();
                int rows = db.ExecuteNonQuery(sql, parameters);
                if (rows > 0)
                {
                    MessageBox.Show("Thêm công việc thành công!");
                    LoadDanhSachCongViec();  // Tải lại danh sách công việc
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Thêm công việc thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCapnhatcongviec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTencongviec.Text) || string.IsNullOrEmpty(txtLuongcoban.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin công việc!");
                return;
            }

            SqlParameter[] parameters = {
        new SqlParameter("@MaCV", dgvDanhsachcongviec.SelectedRows[0].Cells["MaCV"].Value),
        new SqlParameter("@TenCV", txtTencongviec.Text),
        new SqlParameter("@LuongCoBan", Convert.ToDecimal(txtLuongcoban.Text))
    };

            try
            {
                Database db = new Database();
                int rows = db.ExecuteStoredProc("sp_CapNhatCongViec", parameters);
                if (rows > 0)
                {
                    MessageBox.Show("Cập nhật công việc thành công!");
                    LoadDanhSachCongViec();  // Tải lại danh sách công việc
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Cập nhật công việc thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoacongviec_Click(object sender, EventArgs e)
        {
            if (dgvDanhsachcongviec.SelectedRows.Count == 0)
            {
                MessageBox.Show(" Vui lòng chọn công việc cần xóa.");
                return;
            }

            int maCV = Convert.ToInt32(dgvDanhsachcongviec.SelectedRows[0].Cells["MaCV"].Value);
            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa công việc này?", "Xác nhận", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                SqlParameter[] parameters = {
            new SqlParameter("@MaCV", maCV)
        };

                try
                {
                    Database db = new Database();
                    int rows = db.ExecuteStoredProc("sp_XoaCongViec", parameters);
                    if (rows > 0)
                    {
                        MessageBox.Show(" Xóa công việc thành công!");
                        LoadDanhSachCongViec();  // Tải lại danh sách công việc
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show(" Xóa công việc thất bại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void dgvDanhsachcongviec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Nếu người dùng chọn dòng dữ liệu
            {
                DataGridViewRow row = dgvDanhsachcongviec.Rows[e.RowIndex];
                txtMacongviec.Text = row.Cells["MaCV"].Value.ToString();
                txtTencongviec.Text = row.Cells["TenCV"].Value.ToString();
                txtLuongcoban.Text = row.Cells["LuongCoBan"].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtMacongviec.Clear();
            txtTencongviec.Clear();
            txtLuongcoban.Clear();
          
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            // Tạo tham số truyền vào thủ tục
            SqlParameter[] parameters = {
        new SqlParameter("@Search", searchText)
    };

            Database db = new Database();
            dgvDanhsachcongviec.DataSource = db.ExecuteProcToTable("sp_TimKiemCongViec", parameters);
        }
    }
}

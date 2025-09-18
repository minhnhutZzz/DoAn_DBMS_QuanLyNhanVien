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
    public partial class UC_TinhLuong : UserControl
    {
        public UC_TinhLuong()
        {
            InitializeComponent();
        }

        private void LoadLuong()
        {
            string sql = "SELECT * FROM Luong";
            Database db = new Database();
            dgvBangluongnhanvien.DataSource = db.ExecuteQuery(sql); // Hiển thị lại bảng lương sau khi thực hiện thao tác
        }

        private void txtTongluongnhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnthemcapnhatluong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy giá trị từ các TextBox
                int maNV = Convert.ToInt32(txtManhanvien.Text);  // Mã nhân viên
                decimal thuong = Convert.ToDecimal(txtThuong.Text);  // Thưởng
                decimal phuCap = Convert.ToDecimal(txtPhucap.Text);  // Phụ cấp

                // Gọi thủ tục TinhLuong từ cơ sở dữ liệu
                SqlParameter[] parameters = {
                    new SqlParameter("@MaNV", maNV),
                    new SqlParameter("@Thuong", thuong),
                    new SqlParameter("@PhuCap", phuCap)
                };

                Database db = new Database();
                db.ExecuteStoredProc("sp_TinhLuong", parameters); // Thực thi thủ tục

                // Làm mới bảng lương sau khi thêm hoặc cập nhật lương
                LoadLuong();
                TinhTongLuong();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm/cập nhật lương: " + ex.Message);
            }
        }

        private void btnXoaluong_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy Mã nhân viên từ TextBox
                int maNV = Convert.ToInt32(txtManhanvien.Text);

                // Gọi thủ tục XoaLuong từ cơ sở dữ liệu
                SqlParameter[] parameters = {
                    new SqlParameter("@MaNV", maNV)
                };

                Database db = new Database();
                db.ExecuteStoredProc("sp_XoaLuong", parameters); // Thực thi thủ tục xóa lương

                // Làm mới bảng lương sau khi xóa
                LoadLuong();
                TinhTongLuong();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lương: " + ex.Message);
            }
        }

        private void UC_TinhLuong_Load(object sender, EventArgs e)
        {
            LoadLuong();
            TinhTongLuong();
        }

        private void dgvBangluong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng đã chọn dòng dữ liệu
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBangluongnhanvien.Rows[e.RowIndex];  // Lấy dòng dữ liệu
                txtManhanvien.Text = row.Cells["MaNV"].Value.ToString();
                txtThuong.Text = row.Cells["Thuong"].Value.ToString();
                txtPhucap.Text = row.Cells["PhuCap"].Value.ToString();

                // Tính tổng lương phải trả khi bảng lương được load lại
                TinhTongLuong();

                int maNV = Convert.ToInt32(row.Cells["MaNV"].Value);  // Mã nhân viên

                // Gọi hàm TinhTongLuongTheoMaNV từ cơ sở dữ liệu để tính tổng lương theo MaNV
                string sql = "SELECT dbo.fn_TinhTongLuongTheoMaNV(@MaNV) AS TongLuong";
                SqlParameter[] parameters = {
                    new SqlParameter("@MaNV", maNV)
                };

                Database db = new Database();
                var result = db.ExecuteQuery(sql, parameters);  // Thực thi câu lệnh SQL gọi hàm

                // Lấy tổng lương từ kết quả trả về
                decimal tongLuong = Convert.ToDecimal(result.Rows[0]["TongLuong"]);

                // Hiển thị tổng lương trong TextBox
                txtTongluongnhanvientheoMaNV.Text = tongLuong.ToString("C");
            }
        }
        private void TinhTongLuong()
        {
            try
            {
                // Gọi hàm TinhTongLuong từ cơ sở dữ liệu để tính tổng lương
                string sql = "SELECT dbo.fn_TinhTongLuong() AS TongLuong";
                Database db = new Database();
                var result = db.ExecuteQuery(sql); // Thực thi câu lệnh SQL gọi hàm

                // Lấy tổng lương từ kết quả trả về
                decimal tongLuong = Convert.ToDecimal(result.Rows[0]["TongLuong"]);

                // Hiển thị tổng lương trong TextBox
                txtTongluongphaitra.Text = tongLuong.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tính tổng lương: " + ex.Message);
            }
        }

        private void Clear()
        {
            txtManhanvien.Clear();           // Xóa Mã nhân viên
            txtThuong.Clear();               // Xóa Thưởng
            txtPhucap.Clear();               // Xóa Phụ cấp
            txtTongluongphaitra.Clear();     // Xóa Tổng lương phải trả
            txtTongluongnhanvientheoMaNV.Clear();  // Xóa Tổng lương của nhân viên theo MaNV
        }


    }
}

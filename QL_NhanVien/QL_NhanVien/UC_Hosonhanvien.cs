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
    public partial class UC_Hosonhanvien : UserControl
    {
        public UC_Hosonhanvien()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Hosonhanvien_Load(object sender, EventArgs e)
        {
            try
            {
                // Lấy MaNV từ MaTK của tài khoản đang đăng nhập
                int maNV = GetMaNVByMaTK(GlobalState.MaTK);

                // Nếu không tìm thấy MaNV, thông báo lỗi
                if (maNV == 0)
                {
                    MessageBox.Show("Không tìm thấy thông tin nhân viên");
                    return;
                }

                // Gọi hàm Hosocanhan để lấy dữ liệu
                string sql = "SELECT * FROM dbo.fn_Hosonhanvien(@MaTK)";
                SqlParameter[] parameters = { new SqlParameter("@MaTK", GlobalState.MaTK) };
                Database db = new Database();
                DataTable result = db.ExecuteQuery(sql, parameters);

                // Kiểm tra nếu có kết quả trả về
                if (result.Rows.Count > 0)
                {
                    // Lấy thông tin từ DataTable và gán vào các Label
                    DataRow row = result.Rows[0];  // Dữ liệu trả về từ hàm Hosocanhan

                    lblTentaikhoan.Text = row["Tên Tài Khoản"].ToString();
                    lblMatkhau.Text = row["Mật khẩu"].ToString();
                    lblHoten.Text = row["Họ tên"].ToString();
                    lblDiachi.Text = row["Địa chỉ"].ToString();
                    lblNgaysinh.Text = Convert.ToDateTime(row["Ngày sinh"]).ToString("dd/MM/yyyy");
                    lblEmail.Text = row["Email"].ToString();
                    lblSodienthoai.Text = row["Số điện thoại"].ToString();
                    lblTencongviec.Text = row["Tên Công Việc"].ToString();
                }
                else
                {
                    MessageBox.Show("Không có thông tin lương của nhân viên");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private int GetMaNVByMaTK(int maTK)
        {
            int maNV = 0; // Khởi tạo giá trị mặc định là 0
            string sql = "SELECT MaNV FROM NhanVien WHERE MaTK = @MaTK";  // Truy vấn lấy MaNV
            SqlParameter[] parameters = { new SqlParameter("@MaTK", maTK) };
            Database db = new Database();
            DataTable result = db.ExecuteQuery(sql, parameters);

            // Nếu có kết quả trả về, lấy MaNV
            if (result.Rows.Count > 0)
            {
                maNV = Convert.ToInt32(result.Rows[0]["MaNV"]);
            }

            return maNV;
        }
    }
}

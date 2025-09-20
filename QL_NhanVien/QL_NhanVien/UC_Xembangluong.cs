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
    public partial class UC_Xembangluong : UserControl
    {
        public UC_Xembangluong()
        {
            InitializeComponent();
        }

        private void UC_Xembangluong_Load(object sender, EventArgs e)
        {
            // Lấy MaNV từ bảng NhanVien dựa trên MaTK (tài khoản đăng nhập)
            int maNV = GetMaNVByMaTK(GlobalState.MaTK);

            // Truy vấn bảng lương với MaNV đã lấy được
            string sql = "SELECT * FROM dbo.fn_HienThiThongTinLuong(@MaNV)";
            SqlParameter[] parameters = { new SqlParameter("@MaNV", maNV) };
            Database db = new Database();
            dgvXembangluong.DataSource = db.ExecuteQuery(sql, parameters);

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

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void frmForgotPassword_Load(object sender, EventArgs e)
        {
            GlobalState.ConnectionString = @"Data Source=MINH_NHUT\MINH_NHUT;Initial Catalog=QL_NhanVien;Integrated Security=True";
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {

            string tenTK = txtTentaikhoan.Text.Trim();
            string matKhauMoi = txtMatkhaumoi.Text;
            string xacNhan = txtXacnhanmatkhau.Text;

            // Kiểm tra nhập liệu
            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(xacNhan))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (matKhauMoi != xacNhan)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!");
                return;
            }

            try
            {
                

                Database db = new Database();                   
                SqlParameter[] parameters = new SqlParameter[]
                {
        new SqlParameter("@TenTK", tenTK),
        new SqlParameter("@MatKhauMoi", matKhauMoi)
                };

                db.ExecuteStoredProc("sp_QuenMatKhau", parameters);
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠ Lỗi đăng nhập: " + ex.Message);
            }

           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbQuenmatkhau_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

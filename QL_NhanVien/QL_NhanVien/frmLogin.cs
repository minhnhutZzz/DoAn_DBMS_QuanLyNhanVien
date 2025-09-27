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



    public partial class frmLogin : Form
    {

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtTenTK.Focus();
            this.CenterToScreen();

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            string tenTK = txtTenTK.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenTK) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("❌ Vui lòng nhập đầy đủ tên tài khoản và mật khẩu!");
                return;
            }

            string connDefault = @"Data Source=MINH_NHUT\MINH_NHUT;Initial Catalog=QL_NhanVien;Integrated Security=True";

            try
            {
                using (SqlConnection conn = new SqlConnection(connDefault))
                {
                    string sql = "SELECT * FROM TaiKhoan WHERE TenTK = @TenTK AND MatKhau = @MatKhau";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@TenTK", tenTK);
                    cmd.Parameters.AddWithValue("@MatKhau", matKhau);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        // Đăng nhập thành công
                        GlobalState.TenTaiKhoan = tenTK;
                        GlobalState.VaiTro = dt.Rows[0]["VaiTro"].ToString();  
                        GlobalState.MaTK = Convert.ToInt32(dt.Rows[0]["MaTK"]);

                        // Gán ConnectionString trực tiếp bằng tài khoản SQL login vừa nhập
                        GlobalState.ConnectionString = $@"Server=MINH_NHUT\MINH_NHUT;Database=QL_NhanVien;User Id={tenTK};Password={matKhau}";

                        frmMenu main = new frmMenu();
                        this.Hide();
                        main.ShowDialog();
                        this.Show();
                    }
                    else
                    {
                        MessageBox.Show("❌ Tài khoản hoặc mật khẩu không đúng!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠ Lỗi đăng nhập: " + ex.Message);
            }
        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void llblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmForgotPassword forgotForm = new frmForgotPassword();
            forgotForm.ShowDialog();
            this.Show();
        }

        private void pbLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

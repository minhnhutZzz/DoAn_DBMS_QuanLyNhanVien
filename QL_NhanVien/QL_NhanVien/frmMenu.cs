using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhanVien
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void LoadForm(UserControl uc)
        {
            this.CenterToScreen();
           pnMenu.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnMenu.Controls.Add(uc);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (GlobalState.VaiTro == "NhanVien")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadForm(new UC_ChamCong());
        }

        private void btnQuanlytaikhoan_Click(object sender, EventArgs e)
        {
            if (GlobalState.VaiTro == "NhanVien")
            { 
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            LoadForm(new UC_Quanlytaikhoan());
        }

        private void btnQuanlynhanvien_Click(object sender, EventArgs e)
        {
            if (GlobalState.VaiTro == "NhanVien")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadForm(new UC_Quanlynhanvien());
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnQuanlycongviec_Click(object sender, EventArgs e)
        {
            if (GlobalState.VaiTro == "NhanVien")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadForm(new UC_Quanlycongviec());
        }

        private void btnTinhluong_Click(object sender, EventArgs e)
        {
            if (GlobalState.VaiTro == "NhanVien")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadForm(new UC_TinhLuong());
        }

        private void btnXembangluong_Click(object sender, EventArgs e)
        {

            if (GlobalState.VaiTro == "QuanLy")
            {
                MessageBox.Show("Bạn không cần vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadForm(new UC_Xembangluong());
        }

        private void btnHosocanhan_Click(object sender, EventArgs e)
        {

            if (GlobalState.VaiTro == "QuanLy")
            {
                MessageBox.Show("Bạn không cần vào chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            LoadForm(new UC_Hosonhanvien());
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

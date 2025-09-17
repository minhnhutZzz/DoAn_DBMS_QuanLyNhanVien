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
    public partial class UC_ChamCong : UserControl
    {
        public UC_ChamCong()
        {
            InitializeComponent();
        }
        private void LoadChamCong()
        {
            string sql = "SELECT * FROM ChamCong";
            Database db = new Database();
            dgvChamCong.DataSource = db.ExecuteQuery(sql);
        }

        private void UC_ChamCong_Load(object sender, EventArgs e)
        {
            LoadChamCong();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các điều khiển trên form
            int maNV = Convert.ToInt32(txtManhanvien.Text); // Mã nhân viên
            DateTime ngay = dtpNgay.Value; // Ngày
            TimeSpan gioVao = dtpGiovao.Value.TimeOfDay; // Giờ vào
            TimeSpan gioRa = dtpGiora.Value.TimeOfDay; // Giờ ra
            int soGioTangCa = Convert.ToInt32(txtSogiotangca.Text); // Số giờ tăng ca

            // Gọi thủ tục Chấm công
            SqlParameter[] parameters = {
        new SqlParameter("@MaNV", maNV),
        new SqlParameter("@Ngay", ngay),
        new SqlParameter("@GioVao", gioVao),
        new SqlParameter("@GioRa", gioRa),
        new SqlParameter("@SoGioTangCa", soGioTangCa)
    };

            try
            {
                Database db = new Database();
                db.ExecuteStoredProc("sp_ChamCong", parameters); // Thực thi thủ tục
                MessageBox.Show("Chấm công thành công!");

                // Làm mới lại bảng chấm công sau khi chấm công thành công
                LoadChamCong();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chấm công: " + ex.Message);
            }
        }
        private void ClearForm()
        {
            // Làm sạch các TextBox
            txtManhanvien.Clear();
            txtSogiotangca.Clear();

            // Làm sạch các DateTimePicker
            dtpNgay.Value = DateTime.Now;  // Đặt lại ngày mặc định là ngày hiện tại
            dtpGiovao.Value = DateTime.Now;  // Đặt lại giờ vào mặc định là thời gian hiện tại
            dtpGiora.Value = DateTime.Now;  // Đặt lại giờ ra mặc định là thời gian hiện tại
        }
    }
}

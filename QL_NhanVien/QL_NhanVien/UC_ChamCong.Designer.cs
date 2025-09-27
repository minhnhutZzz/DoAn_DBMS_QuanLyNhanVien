namespace QL_NhanVien
{
    partial class UC_ChamCong
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvChamCong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.chamCongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhanVienDataSet12 = new QL_NhanVien.QL_NhanVienDataSet12();
            this.btnChamCong = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtManhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpNgay = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpGiovao = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpGiora = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtSogiotangca = new Guna.UI2.WinForms.Guna2TextBox();
            this.chamCongTableAdapter = new QL_NhanVien.QL_NhanVienDataSet12TableAdapters.ChamCongTableAdapter();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnXoabangghi = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoatoanbo = new Guna.UI2.WinForms.Guna2Button();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioRa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGioLam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGioTangCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhanVienDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(794, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng chấm công";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(575, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chấm Công";
            // 
            // dgvChamCong
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvChamCong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvChamCong.AutoGenerateColumns = false;
            this.dgvChamCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvChamCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvChamCong.ColumnHeadersHeight = 22;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChamCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.Ngay,
            this.GioVao,
            this.GioRa,
            this.SoGioLam,
            this.SoGioTangCa});
            this.dgvChamCong.DataSource = this.chamCongBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChamCong.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvChamCong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChamCong.Location = new System.Drawing.Point(514, 179);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersVisible = false;
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.Size = new System.Drawing.Size(759, 284);
            this.dgvChamCong.TabIndex = 2;
            this.dgvChamCong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChamCong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvChamCong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvChamCong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvChamCong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvChamCong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvChamCong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChamCong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvChamCong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvChamCong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChamCong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChamCong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvChamCong.ThemeStyle.HeaderStyle.Height = 22;
            this.dgvChamCong.ThemeStyle.ReadOnly = false;
            this.dgvChamCong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvChamCong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvChamCong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvChamCong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChamCong.ThemeStyle.RowsStyle.Height = 24;
            this.dgvChamCong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvChamCong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellClick);
            // 
            // chamCongBindingSource
            // 
            this.chamCongBindingSource.DataMember = "ChamCong";
            this.chamCongBindingSource.DataSource = this.qL_NhanVienDataSet12;
            // 
            // qL_NhanVienDataSet12
            // 
            this.qL_NhanVienDataSet12.DataSetName = "QL_NhanVienDataSet12";
            this.qL_NhanVienDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnChamCong
            // 
            this.btnChamCong.BorderRadius = 30;
            this.btnChamCong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChamCong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChamCong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChamCong.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.ForeColor = System.Drawing.Color.Black;
            this.btnChamCong.Location = new System.Drawing.Point(514, 475);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(391, 77);
            this.btnChamCong.TabIndex = 3;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(50, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(52, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(52, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Giờ vào";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 401);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Giờ ra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(50, 484);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Số giờ tăng ca";
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.BorderRadius = 30;
            this.txtManhanvien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtManhanvien.DefaultText = "";
            this.txtManhanvien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtManhanvien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtManhanvien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtManhanvien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtManhanvien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtManhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManhanvien.ForeColor = System.Drawing.Color.Black;
            this.txtManhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtManhanvien.Location = new System.Drawing.Point(193, 159);
            this.txtManhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.PlaceholderText = "";
            this.txtManhanvien.SelectedText = "";
            this.txtManhanvien.Size = new System.Drawing.Size(234, 71);
            this.txtManhanvien.TabIndex = 9;
            // 
            // dtpNgay
            // 
            this.dtpNgay.BorderRadius = 30;
            this.dtpNgay.Checked = true;
            this.dtpNgay.FillColor = System.Drawing.Color.White;
            this.dtpNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay.ForeColor = System.Drawing.Color.Black;
            this.dtpNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay.Location = new System.Drawing.Point(193, 237);
            this.dtpNgay.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgay.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.ShowUpDown = true;
            this.dtpNgay.Size = new System.Drawing.Size(234, 73);
            this.dtpNgay.TabIndex = 10;
            this.dtpNgay.Value = new System.DateTime(2025, 9, 16, 23, 35, 5, 853);
            // 
            // dtpGiovao
            // 
            this.dtpGiovao.BorderRadius = 30;
            this.dtpGiovao.Checked = true;
            this.dtpGiovao.CustomFormat = "HH:mm";
            this.dtpGiovao.FillColor = System.Drawing.Color.White;
            this.dtpGiovao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGiovao.ForeColor = System.Drawing.Color.Black;
            this.dtpGiovao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGiovao.Location = new System.Drawing.Point(193, 316);
            this.dtpGiovao.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpGiovao.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpGiovao.Name = "dtpGiovao";
            this.dtpGiovao.ShowUpDown = true;
            this.dtpGiovao.Size = new System.Drawing.Size(234, 68);
            this.dtpGiovao.TabIndex = 11;
            this.dtpGiovao.Value = new System.DateTime(2025, 9, 16, 23, 35, 5, 853);
            // 
            // dtpGiora
            // 
            this.dtpGiora.BorderRadius = 30;
            this.dtpGiora.Checked = true;
            this.dtpGiora.CustomFormat = "HH:mm";
            this.dtpGiora.FillColor = System.Drawing.Color.White;
            this.dtpGiora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGiora.ForeColor = System.Drawing.Color.Black;
            this.dtpGiora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGiora.Location = new System.Drawing.Point(193, 390);
            this.dtpGiora.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpGiora.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpGiora.Name = "dtpGiora";
            this.dtpGiora.ShowUpDown = true;
            this.dtpGiora.Size = new System.Drawing.Size(234, 73);
            this.dtpGiora.TabIndex = 12;
            this.dtpGiora.Value = new System.DateTime(2025, 9, 16, 23, 35, 5, 853);
            // 
            // txtSogiotangca
            // 
            this.txtSogiotangca.BorderRadius = 30;
            this.txtSogiotangca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSogiotangca.DefaultText = "";
            this.txtSogiotangca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSogiotangca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSogiotangca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSogiotangca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSogiotangca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSogiotangca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSogiotangca.ForeColor = System.Drawing.Color.Black;
            this.txtSogiotangca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSogiotangca.Location = new System.Drawing.Point(193, 470);
            this.txtSogiotangca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSogiotangca.Name = "txtSogiotangca";
            this.txtSogiotangca.PlaceholderText = "";
            this.txtSogiotangca.SelectedText = "";
            this.txtSogiotangca.Size = new System.Drawing.Size(234, 69);
            this.txtSogiotangca.TabIndex = 13;
            // 
            // chamCongTableAdapter
            // 
            this.chamCongTableAdapter.ClearBeforeFill = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::QL_NhanVien.Properties.Resources.working;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(53, 34);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(134, 95);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 14;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnXoabangghi
            // 
            this.btnXoabangghi.BorderRadius = 30;
            this.btnXoabangghi.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoabangghi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoabangghi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoabangghi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoabangghi.FillColor = System.Drawing.Color.Cyan;
            this.btnXoabangghi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoabangghi.ForeColor = System.Drawing.Color.Black;
            this.btnXoabangghi.Location = new System.Drawing.Point(911, 475);
            this.btnXoabangghi.Name = "btnXoabangghi";
            this.btnXoabangghi.Size = new System.Drawing.Size(177, 77);
            this.btnXoabangghi.TabIndex = 15;
            this.btnXoabangghi.Text = "Xóa bảng ghi";
            this.btnXoabangghi.Click += new System.EventHandler(this.btnXoabangghi_Click);
            // 
            // btnXoatoanbo
            // 
            this.btnXoatoanbo.BorderRadius = 30;
            this.btnXoatoanbo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoatoanbo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoatoanbo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoatoanbo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoatoanbo.FillColor = System.Drawing.Color.Cyan;
            this.btnXoatoanbo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoatoanbo.ForeColor = System.Drawing.Color.Black;
            this.btnXoatoanbo.Location = new System.Drawing.Point(1094, 475);
            this.btnXoatoanbo.Name = "btnXoatoanbo";
            this.btnXoatoanbo.Size = new System.Drawing.Size(179, 77);
            this.btnXoatoanbo.TabIndex = 16;
            this.btnXoatoanbo.Text = "Xóa toàn bộ";
            this.btnXoatoanbo.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "Ngay";
            this.Ngay.HeaderText = "Ngay";
            this.Ngay.MinimumWidth = 6;
            this.Ngay.Name = "Ngay";
            // 
            // GioVao
            // 
            this.GioVao.DataPropertyName = "GioVao";
            this.GioVao.HeaderText = "GioVao";
            this.GioVao.MinimumWidth = 6;
            this.GioVao.Name = "GioVao";
            // 
            // GioRa
            // 
            this.GioRa.DataPropertyName = "GioRa";
            this.GioRa.HeaderText = "GioRa";
            this.GioRa.MinimumWidth = 6;
            this.GioRa.Name = "GioRa";
            // 
            // SoGioLam
            // 
            this.SoGioLam.DataPropertyName = "SoGioLam";
            this.SoGioLam.HeaderText = "SoGioLam";
            this.SoGioLam.MinimumWidth = 6;
            this.SoGioLam.Name = "SoGioLam";
            this.SoGioLam.ReadOnly = true;
            // 
            // SoGioTangCa
            // 
            this.SoGioTangCa.DataPropertyName = "SoGioTangCa";
            this.SoGioTangCa.HeaderText = "SoGioTangCa";
            this.SoGioTangCa.MinimumWidth = 6;
            this.SoGioTangCa.Name = "SoGioTangCa";
            // 
            // UC_ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Controls.Add(this.btnXoatoanbo);
            this.Controls.Add(this.btnXoabangghi);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.txtSogiotangca);
            this.Controls.Add(this.dtpGiora);
            this.Controls.Add(this.dtpGiovao);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txtManhanvien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnChamCong);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_ChamCong";
            this.Size = new System.Drawing.Size(1324, 646);
            this.Load += new System.EventHandler(this.UC_ChamCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chamCongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhanVienDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvChamCong;
        private Guna.UI2.WinForms.Guna2Button btnChamCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtManhanvien;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgay;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpGiovao;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpGiora;
        private Guna.UI2.WinForms.Guna2TextBox txtSogiotangca;
        private System.Windows.Forms.BindingSource chamCongBindingSource;
        private QL_NhanVienDataSet12 qL_NhanVienDataSet12;
        private QL_NhanVienDataSet12TableAdapters.ChamCongTableAdapter chamCongTableAdapter;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnXoabangghi;
        private Guna.UI2.WinForms.Guna2Button btnXoatoanbo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioRa;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGioLam;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGioTangCa;
    }
}

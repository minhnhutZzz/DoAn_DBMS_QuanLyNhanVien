namespace QL_NhanVien
{
    partial class UC_TinhLuong
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBangluongnhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongTangCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.luongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_NhanVienDataSet13 = new QL_NhanVien.QL_NhanVienDataSet13();
            this.label2 = new System.Windows.Forms.Label();
            this.luongTableAdapter = new QL_NhanVien.QL_NhanVienDataSet13TableAdapters.LuongTableAdapter();
            this.btnthemcapnhatluong = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtManhanvien = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtThuong = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhucap = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXoaluong = new Guna.UI2.WinForms.Guna2Button();
            this.lblTongluongphaitra = new System.Windows.Forms.Label();
            this.txtTongluongphaitra = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTongluongnhanvientheoMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangluongnhanvien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhanVienDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tiền lương";
            // 
            // dgvBangluongnhanvien
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvBangluongnhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBangluongnhanvien.AutoGenerateColumns = false;
            this.dgvBangluongnhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvBangluongnhanvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBangluongnhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBangluongnhanvien.ColumnHeadersHeight = 20;
            this.dgvBangluongnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBangluongnhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLuong,
            this.MaNV,
            this.Thuong,
            this.PhuCap,
            this.LuongTangCa,
            this.TongLuong});
            this.dgvBangluongnhanvien.DataSource = this.luongBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBangluongnhanvien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBangluongnhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangluongnhanvien.Location = new System.Drawing.Point(440, 207);
            this.dgvBangluongnhanvien.Name = "dgvBangluongnhanvien";
            this.dgvBangluongnhanvien.RowHeadersVisible = false;
            this.dgvBangluongnhanvien.RowHeadersWidth = 51;
            this.dgvBangluongnhanvien.RowTemplate.Height = 24;
            this.dgvBangluongnhanvien.Size = new System.Drawing.Size(718, 202);
            this.dgvBangluongnhanvien.TabIndex = 1;
            this.dgvBangluongnhanvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangluongnhanvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvBangluongnhanvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvBangluongnhanvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvBangluongnhanvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvBangluongnhanvien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangluongnhanvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangluongnhanvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvBangluongnhanvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBangluongnhanvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBangluongnhanvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvBangluongnhanvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvBangluongnhanvien.ThemeStyle.HeaderStyle.Height = 20;
            this.dgvBangluongnhanvien.ThemeStyle.ReadOnly = false;
            this.dgvBangluongnhanvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvBangluongnhanvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBangluongnhanvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvBangluongnhanvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangluongnhanvien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvBangluongnhanvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvBangluongnhanvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvBangluongnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBangluong_CellClick);
            // 
            // MaLuong
            // 
            this.MaLuong.DataPropertyName = "MaLuong";
            this.MaLuong.HeaderText = "MaLuong";
            this.MaLuong.MinimumWidth = 6;
            this.MaLuong.Name = "MaLuong";
            this.MaLuong.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // Thuong
            // 
            this.Thuong.DataPropertyName = "Thuong";
            this.Thuong.HeaderText = "Thuong";
            this.Thuong.MinimumWidth = 6;
            this.Thuong.Name = "Thuong";
            // 
            // PhuCap
            // 
            this.PhuCap.DataPropertyName = "PhuCap";
            this.PhuCap.HeaderText = "PhuCap";
            this.PhuCap.MinimumWidth = 6;
            this.PhuCap.Name = "PhuCap";
            // 
            // LuongTangCa
            // 
            this.LuongTangCa.DataPropertyName = "LuongTangCa";
            this.LuongTangCa.HeaderText = "LuongTangCa";
            this.LuongTangCa.MinimumWidth = 6;
            this.LuongTangCa.Name = "LuongTangCa";
            // 
            // TongLuong
            // 
            this.TongLuong.DataPropertyName = "TongLuong";
            this.TongLuong.HeaderText = "TongLuong";
            this.TongLuong.MinimumWidth = 6;
            this.TongLuong.Name = "TongLuong";
            // 
            // luongBindingSource
            // 
            this.luongBindingSource.DataMember = "Luong";
            this.luongBindingSource.DataSource = this.qL_NhanVienDataSet13;
            // 
            // qL_NhanVienDataSet13
            // 
            this.qL_NhanVienDataSet13.DataSetName = "QL_NhanVienDataSet13";
            this.qL_NhanVienDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bảng lương nhân viên";
            // 
            // luongTableAdapter
            // 
            this.luongTableAdapter.ClearBeforeFill = true;
            // 
            // btnthemcapnhatluong
            // 
            this.btnthemcapnhatluong.BackColor = System.Drawing.Color.Yellow;
            this.btnthemcapnhatluong.BorderRadius = 20;
            this.btnthemcapnhatluong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemcapnhatluong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemcapnhatluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemcapnhatluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemcapnhatluong.FillColor = System.Drawing.Color.Black;
            this.btnthemcapnhatluong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemcapnhatluong.ForeColor = System.Drawing.Color.White;
            this.btnthemcapnhatluong.Location = new System.Drawing.Point(110, 449);
            this.btnthemcapnhatluong.Name = "btnthemcapnhatluong";
            this.btnthemcapnhatluong.Size = new System.Drawing.Size(163, 76);
            this.btnthemcapnhatluong.TabIndex = 3;
            this.btnthemcapnhatluong.Text = "Thêm/Cập nhật Lương";
            this.btnthemcapnhatluong.Click += new System.EventHandler(this.btnthemcapnhatluong_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thưởng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phụ cấp";
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
            this.txtManhanvien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtManhanvien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtManhanvien.Location = new System.Drawing.Point(183, 182);
            this.txtManhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.PlaceholderText = "";
            this.txtManhanvien.SelectedText = "";
            this.txtManhanvien.Size = new System.Drawing.Size(212, 76);
            this.txtManhanvien.TabIndex = 7;
            // 
            // txtThuong
            // 
            this.txtThuong.BorderRadius = 30;
            this.txtThuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThuong.DefaultText = "";
            this.txtThuong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtThuong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtThuong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThuong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtThuong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtThuong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtThuong.Location = new System.Drawing.Point(183, 266);
            this.txtThuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThuong.Name = "txtThuong";
            this.txtThuong.PlaceholderText = "";
            this.txtThuong.SelectedText = "";
            this.txtThuong.Size = new System.Drawing.Size(212, 74);
            this.txtThuong.TabIndex = 8;
            // 
            // txtPhucap
            // 
            this.txtPhucap.BorderRadius = 30;
            this.txtPhucap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhucap.DefaultText = "";
            this.txtPhucap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhucap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhucap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhucap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhucap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhucap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhucap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhucap.Location = new System.Drawing.Point(183, 348);
            this.txtPhucap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhucap.Name = "txtPhucap";
            this.txtPhucap.PlaceholderText = "";
            this.txtPhucap.SelectedText = "";
            this.txtPhucap.Size = new System.Drawing.Size(212, 75);
            this.txtPhucap.TabIndex = 9;
            // 
            // btnXoaluong
            // 
            this.btnXoaluong.BackColor = System.Drawing.Color.Yellow;
            this.btnXoaluong.BorderColor = System.Drawing.Color.Yellow;
            this.btnXoaluong.BorderRadius = 20;
            this.btnXoaluong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaluong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaluong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaluong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaluong.FillColor = System.Drawing.Color.Black;
            this.btnXoaluong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaluong.ForeColor = System.Drawing.Color.White;
            this.btnXoaluong.Location = new System.Drawing.Point(308, 449);
            this.btnXoaluong.Name = "btnXoaluong";
            this.btnXoaluong.Size = new System.Drawing.Size(158, 76);
            this.btnXoaluong.TabIndex = 11;
            this.btnXoaluong.Text = "Xóa lương";
            this.btnXoaluong.Click += new System.EventHandler(this.btnXoaluong_Click);
            // 
            // lblTongluongphaitra
            // 
            this.lblTongluongphaitra.AutoSize = true;
            this.lblTongluongphaitra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongluongphaitra.Location = new System.Drawing.Point(570, 444);
            this.lblTongluongphaitra.Name = "lblTongluongphaitra";
            this.lblTongluongphaitra.Size = new System.Drawing.Size(171, 20);
            this.lblTongluongphaitra.TabIndex = 12;
            this.lblTongluongphaitra.Text = "Tổng lương phải trả";
            // 
            // txtTongluongphaitra
            // 
            this.txtTongluongphaitra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongluongphaitra.DefaultText = "";
            this.txtTongluongphaitra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongluongphaitra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongluongphaitra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongluongphaitra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongluongphaitra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongluongphaitra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongluongphaitra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongluongphaitra.Location = new System.Drawing.Point(935, 426);
            this.txtTongluongphaitra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongluongphaitra.Name = "txtTongluongphaitra";
            this.txtTongluongphaitra.PlaceholderText = "";
            this.txtTongluongphaitra.SelectedText = "";
            this.txtTongluongphaitra.Size = new System.Drawing.Size(135, 46);
            this.txtTongluongphaitra.TabIndex = 13;
            this.txtTongluongphaitra.TextChanged += new System.EventHandler(this.txtTongluongnhanvien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1085, 444);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "VND";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(570, 495);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tổng lương nhân viên theo MaNV";
            // 
            // txtTongluongnhanvientheoMaNV
            // 
            this.txtTongluongnhanvientheoMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongluongnhanvientheoMaNV.DefaultText = "";
            this.txtTongluongnhanvientheoMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTongluongnhanvientheoMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTongluongnhanvientheoMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongluongnhanvientheoMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTongluongnhanvientheoMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongluongnhanvientheoMaNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongluongnhanvientheoMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTongluongnhanvientheoMaNV.Location = new System.Drawing.Point(935, 480);
            this.txtTongluongnhanvientheoMaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTongluongnhanvientheoMaNV.Name = "txtTongluongnhanvientheoMaNV";
            this.txtTongluongnhanvientheoMaNV.PlaceholderText = "";
            this.txtTongluongnhanvientheoMaNV.SelectedText = "";
            this.txtTongluongnhanvientheoMaNV.Size = new System.Drawing.Size(135, 45);
            this.txtTongluongnhanvientheoMaNV.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1085, 495);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "VND";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::QL_NhanVien.Properties.Resources.money_bag;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(39, 40);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(150, 117);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 19;
            this.guna2PictureBox1.TabStop = false;
            // 
            // UC_TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongluongnhanvientheoMaNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongluongphaitra);
            this.Controls.Add(this.lblTongluongphaitra);
            this.Controls.Add(this.btnXoaluong);
            this.Controls.Add(this.txtPhucap);
            this.Controls.Add(this.txtThuong);
            this.Controls.Add(this.txtManhanvien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnthemcapnhatluong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvBangluongnhanvien);
            this.Controls.Add(this.label1);
            this.Name = "UC_TinhLuong";
            this.Size = new System.Drawing.Size(1186, 692);
            this.Load += new System.EventHandler(this.UC_TinhLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangluongnhanvien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_NhanVienDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvBangluongnhanvien;
        private System.Windows.Forms.BindingSource luongBindingSource;
        private QL_NhanVienDataSet13 qL_NhanVienDataSet13;
        private System.Windows.Forms.Label label2;
        private QL_NhanVienDataSet13TableAdapters.LuongTableAdapter luongTableAdapter;
        private Guna.UI2.WinForms.Guna2Button btnthemcapnhatluong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtManhanvien;
        private Guna.UI2.WinForms.Guna2TextBox txtThuong;
        private Guna.UI2.WinForms.Guna2TextBox txtPhucap;
        private Guna.UI2.WinForms.Guna2Button btnXoaluong;
        private System.Windows.Forms.Label lblTongluongphaitra;
        private Guna.UI2.WinForms.Guna2TextBox txtTongluongphaitra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtTongluongnhanvientheoMaNV;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhuCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongTangCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongLuong;
    }
}

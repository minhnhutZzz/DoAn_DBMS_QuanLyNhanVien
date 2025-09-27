namespace QL_NhanVien
{
    partial class frmForgotPassword
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pbQuenmatkhau = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnXacnhan = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXacnhanmatkhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatkhaumoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTentaikhoan = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuenmatkhau)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Panel1.BackgroundImage = global::QL_NhanVien.Properties.Resources.bgquenmatkhau;
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Panel1.Controls.Add(this.pbQuenmatkhau);
            this.guna2Panel1.Controls.Add(this.btnXacnhan);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.txtXacnhanmatkhau);
            this.guna2Panel1.Controls.Add(this.txtMatkhaumoi);
            this.guna2Panel1.Controls.Add(this.txtTentaikhoan);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(70, 45);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1086, 647);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // pbQuenmatkhau
            // 
            this.pbQuenmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.pbQuenmatkhau.Image = global::QL_NhanVien.Properties.Resources.no;
            this.pbQuenmatkhau.ImageRotate = 0F;
            this.pbQuenmatkhau.Location = new System.Drawing.Point(1008, 11);
            this.pbQuenmatkhau.Name = "pbQuenmatkhau";
            this.pbQuenmatkhau.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbQuenmatkhau.Size = new System.Drawing.Size(56, 52);
            this.pbQuenmatkhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQuenmatkhau.TabIndex = 9;
            this.pbQuenmatkhau.TabStop = false;
            this.pbQuenmatkhau.Click += new System.EventHandler(this.pbQuenmatkhau_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.Transparent;
            this.btnXacnhan.BorderRadius = 30;
            this.btnXacnhan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacnhan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacnhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacnhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacnhan.FillColor = System.Drawing.Color.Black;
            this.btnXacnhan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.ForeColor = System.Drawing.Color.White;
            this.btnXacnhan.Location = new System.Drawing.Point(120, 528);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(229, 73);
            this.btnXacnhan.TabIndex = 8;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MistyRose;
            this.label5.Location = new System.Drawing.Point(117, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(388, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vui lòng nhập đầy đủ thông tin bên dưới để lấy lại mật khẩu";
            // 
            // txtXacnhanmatkhau
            // 
            this.txtXacnhanmatkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXacnhanmatkhau.DefaultText = "";
            this.txtXacnhanmatkhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtXacnhanmatkhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtXacnhanmatkhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacnhanmatkhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtXacnhanmatkhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacnhanmatkhau.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXacnhanmatkhau.ForeColor = System.Drawing.Color.Black;
            this.txtXacnhanmatkhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtXacnhanmatkhau.Location = new System.Drawing.Point(120, 447);
            this.txtXacnhanmatkhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtXacnhanmatkhau.Name = "txtXacnhanmatkhau";
            this.txtXacnhanmatkhau.PlaceholderText = "";
            this.txtXacnhanmatkhau.SelectedText = "";
            this.txtXacnhanmatkhau.Size = new System.Drawing.Size(229, 48);
            this.txtXacnhanmatkhau.TabIndex = 6;
            // 
            // txtMatkhaumoi
            // 
            this.txtMatkhaumoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatkhaumoi.DefaultText = "";
            this.txtMatkhaumoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatkhaumoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatkhaumoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhaumoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatkhaumoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhaumoi.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhaumoi.ForeColor = System.Drawing.Color.Black;
            this.txtMatkhaumoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatkhaumoi.Location = new System.Drawing.Point(120, 342);
            this.txtMatkhaumoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatkhaumoi.Name = "txtMatkhaumoi";
            this.txtMatkhaumoi.PlaceholderText = "";
            this.txtMatkhaumoi.SelectedText = "";
            this.txtMatkhaumoi.Size = new System.Drawing.Size(229, 48);
            this.txtMatkhaumoi.TabIndex = 5;
            // 
            // txtTentaikhoan
            // 
            this.txtTentaikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTentaikhoan.DefaultText = "";
            this.txtTentaikhoan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTentaikhoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTentaikhoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTentaikhoan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTentaikhoan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTentaikhoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentaikhoan.ForeColor = System.Drawing.Color.Black;
            this.txtTentaikhoan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTentaikhoan.Location = new System.Drawing.Point(120, 247);
            this.txtTentaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTentaikhoan.Name = "txtTentaikhoan";
            this.txtTentaikhoan.PlaceholderText = "";
            this.txtTentaikhoan.SelectedText = "";
            this.txtTentaikhoan.Size = new System.Drawing.Size(229, 48);
            this.txtTentaikhoan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(102, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "* Xác nhận mật khẩu ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "* Mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(102, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "* Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(167, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên mật khẩu ?";
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1247, 739);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgotPassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmForgotPassword_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuenmatkhau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtXacnhanmatkhau;
        private Guna.UI2.WinForms.Guna2TextBox txtMatkhaumoi;
        private Guna.UI2.WinForms.Guna2TextBox txtTentaikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnXacnhan;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbQuenmatkhau;
    }
}
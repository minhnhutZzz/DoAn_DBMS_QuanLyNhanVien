namespace QL_NhanVien
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.llblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.btnSignin = new Guna.UI2.WinForms.Guna2Button();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenTK = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 50;
            this.guna2Elipse1.TargetControl = this.pnLogin;
            // 
            // pnLogin
            // 
            this.pnLogin.BackgroundImage = global::QL_NhanVien.Properties.Resources.bg;
            this.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnLogin.Controls.Add(this.label1);
            this.pnLogin.Controls.Add(this.llblForgotPassword);
            this.pnLogin.Controls.Add(this.btnSignin);
            this.pnLogin.Controls.Add(this.txtMatKhau);
            this.pnLogin.Controls.Add(this.txtTenTK);
            this.pnLogin.Controls.Add(this.Login);
            this.pnLogin.Location = new System.Drawing.Point(98, 71);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(942, 552);
            this.pnLogin.TabIndex = 0;
            this.pnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnLogin_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(588, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCOME";
            // 
            // llblForgotPassword
            // 
            this.llblForgotPassword.AutoSize = true;
            this.llblForgotPassword.BackColor = System.Drawing.Color.White;
            this.llblForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblForgotPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.llblForgotPassword.LinkColor = System.Drawing.Color.Blue;
            this.llblForgotPassword.Location = new System.Drawing.Point(237, 355);
            this.llblForgotPassword.Name = "llblForgotPassword";
            this.llblForgotPassword.Size = new System.Drawing.Size(132, 16);
            this.llblForgotPassword.TabIndex = 4;
            this.llblForgotPassword.TabStop = true;
            this.llblForgotPassword.Text = "Forgot Password?";
            this.llblForgotPassword.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.Color.White;
            this.btnSignin.BorderRadius = 20;
            this.btnSignin.BorderThickness = 1;
            this.btnSignin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignin.FillColor = System.Drawing.Color.Cyan;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignin.ForeColor = System.Drawing.Color.Black;
            this.btnSignin.Location = new System.Drawing.Point(71, 387);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(297, 63);
            this.btnSignin.TabIndex = 3;
            this.btnSignin.Text = "Sign in";
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderColor = System.Drawing.Color.Black;
            this.txtMatKhau.BorderRadius = 20;
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.IconLeft = global::QL_NhanVien.Properties.Resources.padlock;
            this.txtMatKhau.Location = new System.Drawing.Point(71, 265);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.PlaceholderText = "Password";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(297, 62);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // txtTenTK
            // 
            this.txtTenTK.BackColor = System.Drawing.Color.White;
            this.txtTenTK.BorderColor = System.Drawing.Color.Black;
            this.txtTenTK.BorderRadius = 20;
            this.txtTenTK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenTK.DefaultText = "";
            this.txtTenTK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenTK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenTK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenTK.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenTK.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenTK.ForeColor = System.Drawing.Color.Black;
            this.txtTenTK.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenTK.IconLeft = global::QL_NhanVien.Properties.Resources.user;
            this.txtTenTK.Location = new System.Drawing.Point(71, 181);
            this.txtTenTK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.PlaceholderForeColor = System.Drawing.Color.Black;
            this.txtTenTK.PlaceholderText = "Username";
            this.txtTenTK.SelectedText = "";
            this.txtTenTK.Size = new System.Drawing.Size(297, 60);
            this.txtTenTK.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(88, 91);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(149, 46);
            this.Login.TabIndex = 0;
            this.Login.Text = "Sign in";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1139, 692);
            this.Controls.Add(this.pnLogin);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnLogin;
        private Guna.UI2.WinForms.Guna2Button btnSignin;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTK;
        private System.Windows.Forms.Label Login;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.LinkLabel llblForgotPassword;
        private System.Windows.Forms.Label label1;
    }
}


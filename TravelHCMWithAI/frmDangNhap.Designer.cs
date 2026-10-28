namespace TravelHCMWithAI
{
    partial class frmDangNhap
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
            this.tabControlAuth = new System.Windows.Forms.TabControl();
            this.tabDangNhap = new System.Windows.Forms.TabPage();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtMatKhauDN = new System.Windows.Forms.TextBox();
            this.txtEmailDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTieuDeDN = new System.Windows.Forms.Label();
            this.tabDangKy = new System.Windows.Forms.TabPage();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtSoThichDK = new System.Windows.Forms.TextBox();
            this.txtEmailDK = new System.Windows.Forms.TextBox();
            this.txtHoTenDK = new System.Windows.Forms.TextBox();
            this.txtMatKhauDK = new System.Windows.Forms.TextBox();
            this.txtTenDangNhapDK = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlAuth.SuspendLayout();
            this.tabDangNhap.SuspendLayout();
            this.tabDangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAuth
            // 
            this.tabControlAuth.Controls.Add(this.tabDangNhap);
            this.tabControlAuth.Controls.Add(this.tabDangKy);
            this.tabControlAuth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabControlAuth.Location = new System.Drawing.Point(0, 0);
            this.tabControlAuth.Name = "tabControlAuth";
            this.tabControlAuth.SelectedIndex = 0;
            this.tabControlAuth.Size = new System.Drawing.Size(800, 450);
            this.tabControlAuth.TabIndex = 0;
            // 
            // tabDangNhap
            // 
            this.tabDangNhap.Controls.Add(this.btnDangNhap);
            this.tabDangNhap.Controls.Add(this.txtMatKhauDN);
            this.tabDangNhap.Controls.Add(this.txtEmailDN);
            this.tabDangNhap.Controls.Add(this.label3);
            this.tabDangNhap.Controls.Add(this.label2);
            this.tabDangNhap.Controls.Add(this.lblTieuDeDN);
            this.tabDangNhap.Location = new System.Drawing.Point(4, 34);
            this.tabDangNhap.Name = "tabDangNhap";
            this.tabDangNhap.Padding = new System.Windows.Forms.Padding(3);
            this.tabDangNhap.Size = new System.Drawing.Size(792, 412);
            this.tabDangNhap.TabIndex = 0;
            this.tabDangNhap.Text = "Đăng nhập";
            this.tabDangNhap.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.Location = new System.Drawing.Point(326, 277);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(167, 43);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập ngay!";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtMatKhauDN
            // 
            this.txtMatKhauDN.Location = new System.Drawing.Point(326, 185);
            this.txtMatKhauDN.Name = "txtMatKhauDN";
            this.txtMatKhauDN.PasswordChar = '*';
            this.txtMatKhauDN.Size = new System.Drawing.Size(256, 30);
            this.txtMatKhauDN.TabIndex = 4;
            // 
            // txtEmailDN
            // 
            this.txtEmailDN.Location = new System.Drawing.Point(326, 113);
            this.txtEmailDN.Name = "txtEmailDN";
            this.txtEmailDN.Size = new System.Drawing.Size(256, 30);
            this.txtEmailDN.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(209, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(224, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // lblTieuDeDN
            // 
            this.lblTieuDeDN.AutoSize = true;
            this.lblTieuDeDN.BackColor = System.Drawing.Color.Transparent;
            this.lblTieuDeDN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTieuDeDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeDN.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTieuDeDN.Location = new System.Drawing.Point(228, 28);
            this.lblTieuDeDN.Name = "lblTieuDeDN";
            this.lblTieuDeDN.Size = new System.Drawing.Size(354, 34);
            this.lblTieuDeDN.TabIndex = 0;
            this.lblTieuDeDN.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // tabDangKy
            // 
            this.tabDangKy.Controls.Add(this.btnDangKy);
            this.tabDangKy.Controls.Add(this.txtSoThichDK);
            this.tabDangKy.Controls.Add(this.txtEmailDK);
            this.tabDangKy.Controls.Add(this.txtHoTenDK);
            this.tabDangKy.Controls.Add(this.txtMatKhauDK);
            this.tabDangKy.Controls.Add(this.txtTenDangNhapDK);
            this.tabDangKy.Controls.Add(this.label8);
            this.tabDangKy.Controls.Add(this.label7);
            this.tabDangKy.Controls.Add(this.label6);
            this.tabDangKy.Controls.Add(this.label5);
            this.tabDangKy.Controls.Add(this.label4);
            this.tabDangKy.Controls.Add(this.label1);
            this.tabDangKy.Location = new System.Drawing.Point(4, 34);
            this.tabDangKy.Name = "tabDangKy";
            this.tabDangKy.Padding = new System.Windows.Forms.Padding(3);
            this.tabDangKy.Size = new System.Drawing.Size(792, 412);
            this.tabDangKy.TabIndex = 1;
            this.tabDangKy.Text = "Đăng ký tài khoản";
            this.tabDangKy.UseVisualStyleBackColor = true;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangKy.Location = new System.Drawing.Point(303, 347);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(181, 47);
            this.btnDangKy.TabIndex = 11;
            this.btnDangKy.Text = "Đăng ký ngay!";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtSoThichDK
            // 
            this.txtSoThichDK.Location = new System.Drawing.Point(355, 299);
            this.txtSoThichDK.Name = "txtSoThichDK";
            this.txtSoThichDK.Size = new System.Drawing.Size(244, 30);
            this.txtSoThichDK.TabIndex = 10;
            // 
            // txtEmailDK
            // 
            this.txtEmailDK.Location = new System.Drawing.Point(355, 242);
            this.txtEmailDK.Name = "txtEmailDK";
            this.txtEmailDK.Size = new System.Drawing.Size(244, 30);
            this.txtEmailDK.TabIndex = 9;
            // 
            // txtHoTenDK
            // 
            this.txtHoTenDK.Location = new System.Drawing.Point(355, 190);
            this.txtHoTenDK.Name = "txtHoTenDK";
            this.txtHoTenDK.Size = new System.Drawing.Size(244, 30);
            this.txtHoTenDK.TabIndex = 8;
            // 
            // txtMatKhauDK
            // 
            this.txtMatKhauDK.Location = new System.Drawing.Point(355, 140);
            this.txtMatKhauDK.Name = "txtMatKhauDK";
            this.txtMatKhauDK.Size = new System.Drawing.Size(244, 30);
            this.txtMatKhauDK.TabIndex = 7;
            // 
            // txtTenDangNhapDK
            // 
            this.txtTenDangNhapDK.Location = new System.Drawing.Point(355, 84);
            this.txtTenDangNhapDK.Name = "txtTenDangNhapDK";
            this.txtTenDangNhapDK.Size = new System.Drawing.Size(244, 30);
            this.txtTenDangNhapDK.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(191, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Sở thích du lịch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(191, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(191, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Họ và tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(191, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(187, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên đăng nhập";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(243, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlAuth);
            this.Name = "frmDangNhap";
            this.Text = "frmDangNhap";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.tabControlAuth.ResumeLayout(false);
            this.tabDangNhap.ResumeLayout(false);
            this.tabDangNhap.PerformLayout();
            this.tabDangKy.ResumeLayout(false);
            this.tabDangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAuth;
        private System.Windows.Forms.TabPage tabDangNhap;
        private System.Windows.Forms.TabPage tabDangKy;
        private System.Windows.Forms.Label lblTieuDeDN;
        private System.Windows.Forms.TextBox txtMatKhauDN;
        private System.Windows.Forms.TextBox txtEmailDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtSoThichDK;
        private System.Windows.Forms.TextBox txtEmailDK;
        private System.Windows.Forms.TextBox txtHoTenDK;
        private System.Windows.Forms.TextBox txtMatKhauDK;
        private System.Windows.Forms.TextBox txtTenDangNhapDK;
    }
}
namespace TravelHCMWithAI
{
    partial class Form1
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnHoSo = new System.Windows.Forms.Button();
            this.btnDaLuu = new System.Windows.Forms.Button();
            this.btnDiaDiem = new System.Windows.Forms.Button();
            this.btnLichTrinh = new System.Windows.Forms.Button();
            this.btnTroChuyenAI = new System.Windows.Forms.Button();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlKhungNhapTinNhan = new System.Windows.Forms.Panel();
            this.btnGuiTinNhan = new System.Windows.Forms.Button();
            this.txtNhapTinNhan = new System.Windows.Forms.TextBox();
            this.flpPromptChips = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPromptGoiY1 = new System.Windows.Forms.Button();
            this.btnPromptGoiY2 = new System.Windows.Forms.Button();
            this.btnPromptGoiY3 = new System.Windows.Forms.Button();
            this.rtbLichSuChat = new System.Windows.Forms.RichTextBox();
            this.pnlSidebar.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlKhungNhapTinNhan.SuspendLayout();
            this.flpPromptChips.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlSidebar.Controls.Add(this.btnHoSo);
            this.pnlSidebar.Controls.Add(this.btnDaLuu);
            this.pnlSidebar.Controls.Add(this.btnDiaDiem);
            this.pnlSidebar.Controls.Add(this.btnLichTrinh);
            this.pnlSidebar.Controls.Add(this.btnTroChuyenAI);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(134, 450);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnHoSo
            // 
            this.btnHoSo.Location = new System.Drawing.Point(3, 297);
            this.btnHoSo.Name = "btnHoSo";
            this.btnHoSo.Size = new System.Drawing.Size(131, 55);
            this.btnHoSo.TabIndex = 4;
            this.btnHoSo.Text = "👤 Hồ Sơ";
            this.btnHoSo.UseVisualStyleBackColor = true;
            this.btnHoSo.Click += new System.EventHandler(this.btnHoSo_Click);
            // 
            // btnDaLuu
            // 
            this.btnDaLuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDaLuu.Location = new System.Drawing.Point(0, 177);
            this.btnDaLuu.Name = "btnDaLuu";
            this.btnDaLuu.Size = new System.Drawing.Size(134, 54);
            this.btnDaLuu.TabIndex = 3;
            this.btnDaLuu.Text = "📌 Đã Lưu";
            this.btnDaLuu.UseVisualStyleBackColor = true;
            this.btnDaLuu.Click += new System.EventHandler(this.btnDaLuu_Click);
            // 
            // btnDiaDiem
            // 
            this.btnDiaDiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiaDiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDiaDiem.Location = new System.Drawing.Point(0, 118);
            this.btnDiaDiem.Name = "btnDiaDiem";
            this.btnDiaDiem.Size = new System.Drawing.Size(134, 59);
            this.btnDiaDiem.TabIndex = 2;
            this.btnDiaDiem.Text = "📍 Địa điểm";
            this.btnDiaDiem.UseVisualStyleBackColor = true;
            this.btnDiaDiem.Click += new System.EventHandler(this.btnDiaDiem_Click);
            // 
            // btnLichTrinh
            // 
            this.btnLichTrinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichTrinh.Location = new System.Drawing.Point(0, 59);
            this.btnLichTrinh.Name = "btnLichTrinh";
            this.btnLichTrinh.Size = new System.Drawing.Size(134, 59);
            this.btnLichTrinh.TabIndex = 1;
            this.btnLichTrinh.Text = "🗺️ Lịch trình";
            this.btnLichTrinh.UseVisualStyleBackColor = true;
            this.btnLichTrinh.Click += new System.EventHandler(this.btnLichTrinh_Click);
            // 
            // btnTroChuyenAI
            // 
            this.btnTroChuyenAI.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTroChuyenAI.Location = new System.Drawing.Point(0, 0);
            this.btnTroChuyenAI.Name = "btnTroChuyenAI";
            this.btnTroChuyenAI.Size = new System.Drawing.Size(134, 59);
            this.btnTroChuyenAI.TabIndex = 0;
            this.btnTroChuyenAI.Text = "💬 Chat AI";
            this.btnTroChuyenAI.UseVisualStyleBackColor = true;
            this.btnTroChuyenAI.Click += new System.EventHandler(this.btnTroChuyenAI_Click);
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.Controls.Add(this.pnlKhungNhapTinNhan);
            this.pnlMainContent.Controls.Add(this.flpPromptChips);
            this.pnlMainContent.Controls.Add(this.rtbLichSuChat);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(134, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Size = new System.Drawing.Size(611, 450);
            this.pnlMainContent.TabIndex = 1;
            // 
            // pnlKhungNhapTinNhan
            // 
            this.pnlKhungNhapTinNhan.Controls.Add(this.btnGuiTinNhan);
            this.pnlKhungNhapTinNhan.Controls.Add(this.txtNhapTinNhan);
            this.pnlKhungNhapTinNhan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlKhungNhapTinNhan.Location = new System.Drawing.Point(0, 350);
            this.pnlKhungNhapTinNhan.Name = "pnlKhungNhapTinNhan";
            this.pnlKhungNhapTinNhan.Size = new System.Drawing.Size(611, 100);
            this.pnlKhungNhapTinNhan.TabIndex = 2;
            // 
            // btnGuiTinNhan
            // 
            this.btnGuiTinNhan.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuiTinNhan.Location = new System.Drawing.Point(521, 0);
            this.btnGuiTinNhan.Name = "btnGuiTinNhan";
            this.btnGuiTinNhan.Size = new System.Drawing.Size(90, 100);
            this.btnGuiTinNhan.TabIndex = 1;
            this.btnGuiTinNhan.Text = "Gửi tin nhắn";
            this.btnGuiTinNhan.UseVisualStyleBackColor = true;
            // 
            // txtNhapTinNhan
            // 
            this.txtNhapTinNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNhapTinNhan.Location = new System.Drawing.Point(0, 0);
            this.txtNhapTinNhan.Multiline = true;
            this.txtNhapTinNhan.Name = "txtNhapTinNhan";
            this.txtNhapTinNhan.Size = new System.Drawing.Size(611, 100);
            this.txtNhapTinNhan.TabIndex = 0;
            this.txtNhapTinNhan.Text = "Nhập tin nhắn";
            // 
            // flpPromptChips
            // 
            this.flpPromptChips.Controls.Add(this.btnPromptGoiY1);
            this.flpPromptChips.Controls.Add(this.btnPromptGoiY2);
            this.flpPromptChips.Controls.Add(this.btnPromptGoiY3);
            this.flpPromptChips.Location = new System.Drawing.Point(40, 152);
            this.flpPromptChips.Name = "flpPromptChips";
            this.flpPromptChips.Size = new System.Drawing.Size(572, 243);
            this.flpPromptChips.TabIndex = 1;
            // 
            // btnPromptGoiY1
            // 
            this.btnPromptGoiY1.Location = new System.Drawing.Point(3, 3);
            this.btnPromptGoiY1.Name = "btnPromptGoiY1";
            this.btnPromptGoiY1.Size = new System.Drawing.Size(170, 23);
            this.btnPromptGoiY1.TabIndex = 0;
            this.btnPromptGoiY1.Text = "Gợi ý tour 1 ngày TP.HCM";
            this.btnPromptGoiY1.UseVisualStyleBackColor = true;
            // 
            // btnPromptGoiY2
            // 
            this.btnPromptGoiY2.Location = new System.Drawing.Point(179, 3);
            this.btnPromptGoiY2.Name = "btnPromptGoiY2";
            this.btnPromptGoiY2.Size = new System.Drawing.Size(171, 23);
            this.btnPromptGoiY2.TabIndex = 1;
            this.btnPromptGoiY2.Text = "Địa điểm ăn uống Quận 1";
            this.btnPromptGoiY2.UseVisualStyleBackColor = true;
            // 
            // btnPromptGoiY3
            // 
            this.btnPromptGoiY3.Location = new System.Drawing.Point(356, 3);
            this.btnPromptGoiY3.Name = "btnPromptGoiY3";
            this.btnPromptGoiY3.Size = new System.Drawing.Size(148, 23);
            this.btnPromptGoiY3.TabIndex = 2;
            this.btnPromptGoiY3.Text = "Quán cà phê view đẹp";
            this.btnPromptGoiY3.UseVisualStyleBackColor = true;
            // 
            // rtbLichSuChat
            // 
            this.rtbLichSuChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.rtbLichSuChat.Location = new System.Drawing.Point(0, 0);
            this.rtbLichSuChat.Name = "rtbLichSuChat";
            this.rtbLichSuChat.ReadOnly = true;
            this.rtbLichSuChat.Size = new System.Drawing.Size(611, 96);
            this.rtbLichSuChat.TabIndex = 0;
            this.rtbLichSuChat.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlKhungNhapTinNhan.ResumeLayout(false);
            this.pnlKhungNhapTinNhan.PerformLayout();
            this.flpPromptChips.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnHoSo;
        private System.Windows.Forms.Button btnDaLuu;
        private System.Windows.Forms.Button btnDiaDiem;
        private System.Windows.Forms.Button btnLichTrinh;
        private System.Windows.Forms.Button btnTroChuyenAI;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.FlowLayoutPanel flpPromptChips;
        private System.Windows.Forms.RichTextBox rtbLichSuChat;
        private System.Windows.Forms.Panel pnlKhungNhapTinNhan;
        private System.Windows.Forms.TextBox txtNhapTinNhan;
        private System.Windows.Forms.Button btnPromptGoiY1;
        private System.Windows.Forms.Button btnPromptGoiY2;
        private System.Windows.Forms.Button btnPromptGoiY3;
        private System.Windows.Forms.Button btnGuiTinNhan;
    }
}


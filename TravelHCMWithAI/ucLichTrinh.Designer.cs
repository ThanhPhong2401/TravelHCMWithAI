namespace TravelHCMWithAI
{
    partial class ucLichTrinh
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
            this.pnlBoLoc = new System.Windows.Forms.Panel();
            this.cklPhongCach = new System.Windows.Forms.CheckedListBox();
            this.btnTaoLichTrinh = new System.Windows.Forms.Button();
            this.cbPhuongTien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNganSach = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSoNgay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbKetQuaLichTrinh = new System.Windows.Forms.RichTextBox();
            this.pnlKetQua = new System.Windows.Forms.Panel();
            this.pnlBoLoc.SuspendLayout();
            this.pnlKetQua.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBoLoc
            // 
            this.pnlBoLoc.Controls.Add(this.cklPhongCach);
            this.pnlBoLoc.Controls.Add(this.btnTaoLichTrinh);
            this.pnlBoLoc.Controls.Add(this.cbPhuongTien);
            this.pnlBoLoc.Controls.Add(this.label4);
            this.pnlBoLoc.Controls.Add(this.label3);
            this.pnlBoLoc.Controls.Add(this.cbNganSach);
            this.pnlBoLoc.Controls.Add(this.label2);
            this.pnlBoLoc.Controls.Add(this.cbSoNgay);
            this.pnlBoLoc.Controls.Add(this.label1);
            this.pnlBoLoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBoLoc.Location = new System.Drawing.Point(0, 0);
            this.pnlBoLoc.Name = "pnlBoLoc";
            this.pnlBoLoc.Size = new System.Drawing.Size(352, 526);
            this.pnlBoLoc.TabIndex = 0;
            // 
            // cklPhongCach
            // 
            this.cklPhongCach.FormattingEnabled = true;
            this.cklPhongCach.Items.AddRange(new object[] {
            "Khám phá Lịch sử",
            "Khu đô thị sang trọng",
            "Khu du lịch văn hóa",
            "Ẩm thực đường phố",
            "Trung tâm mua sắm",
            ""});
            this.cklPhongCach.Location = new System.Drawing.Point(147, 239);
            this.cklPhongCach.Name = "cklPhongCach";
            this.cklPhongCach.Size = new System.Drawing.Size(187, 89);
            this.cklPhongCach.TabIndex = 0;
            // 
            // btnTaoLichTrinh
            // 
            this.btnTaoLichTrinh.Location = new System.Drawing.Point(91, 422);
            this.btnTaoLichTrinh.Name = "btnTaoLichTrinh";
            this.btnTaoLichTrinh.Size = new System.Drawing.Size(152, 33);
            this.btnTaoLichTrinh.TabIndex = 0;
            this.btnTaoLichTrinh.Text = "Tạo lịch trình với AI";
            this.btnTaoLichTrinh.UseVisualStyleBackColor = true;
            this.btnTaoLichTrinh.Click += new System.EventHandler(this.btnTaoLichTrinh_Click);
            // 
            // cbPhuongTien
            // 
            this.cbPhuongTien.FormattingEnabled = true;
            this.cbPhuongTien.Items.AddRange(new object[] {
            "Xe máy",
            "Ô tô",
            "Tàu Metro",
            "Xe buýt"});
            this.cbPhuongTien.Location = new System.Drawing.Point(166, 365);
            this.cbPhuongTien.Name = "cbPhuongTien";
            this.cbPhuongTien.Size = new System.Drawing.Size(130, 24);
            this.cbPhuongTien.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phương tiện di chuyển";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phong cách du lịch";
            // 
            // cbNganSach
            // 
            this.cbNganSach.FormattingEnabled = true;
            this.cbNganSach.Items.AddRange(new object[] {
            "Bình dân (<500)",
            "Trung bình (500k-1 triệu)",
            "Cao cấp (>1.5 triệu)"});
            this.cbNganSach.Location = new System.Drawing.Point(147, 139);
            this.cbNganSach.Name = "cbNganSach";
            this.cbNganSach.Size = new System.Drawing.Size(149, 24);
            this.cbNganSach.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngân sách dự kiến";
            // 
            // cbSoNgay
            // 
            this.cbSoNgay.FormattingEnabled = true;
            this.cbSoNgay.Items.AddRange(new object[] {
            "1 ngày",
            "2 ngày 1 đêm",
            "3 ngày 2 đêm"});
            this.cbSoNgay.Location = new System.Drawing.Point(153, 47);
            this.cbSoNgay.Name = "cbSoNgay";
            this.cbSoNgay.Size = new System.Drawing.Size(143, 24);
            this.cbSoNgay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số ngày tham quan";
            // 
            // rtbKetQuaLichTrinh
            // 
            this.rtbKetQuaLichTrinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbKetQuaLichTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rtbKetQuaLichTrinh.Location = new System.Drawing.Point(0, 0);
            this.rtbKetQuaLichTrinh.Name = "rtbKetQuaLichTrinh";
            this.rtbKetQuaLichTrinh.ReadOnly = true;
            this.rtbKetQuaLichTrinh.Size = new System.Drawing.Size(473, 526);
            this.rtbKetQuaLichTrinh.TabIndex = 0;
            this.rtbKetQuaLichTrinh.Text = "";
            // 
            // pnlKetQua
            // 
            this.pnlKetQua.Controls.Add(this.rtbKetQuaLichTrinh);
            this.pnlKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKetQua.Location = new System.Drawing.Point(352, 0);
            this.pnlKetQua.Name = "pnlKetQua";
            this.pnlKetQua.Size = new System.Drawing.Size(473, 526);
            this.pnlKetQua.TabIndex = 1;
            // 
            // ucLichTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlKetQua);
            this.Controls.Add(this.pnlBoLoc);
            this.Name = "ucLichTrinh";
            this.Size = new System.Drawing.Size(825, 526);
            this.pnlBoLoc.ResumeLayout(false);
            this.pnlBoLoc.PerformLayout();
            this.pnlKetQua.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBoLoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNganSach;
        private System.Windows.Forms.ComboBox cbSoNgay;
        private System.Windows.Forms.ComboBox cbPhuongTien;
        private System.Windows.Forms.Button btnTaoLichTrinh;
        private System.Windows.Forms.CheckedListBox cklPhongCach;
        private System.Windows.Forms.RichTextBox rtbKetQuaLichTrinh;
        private System.Windows.Forms.Panel pnlKetQua;
    }
}

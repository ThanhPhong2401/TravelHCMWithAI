namespace TravelHCMWithAI
{
    partial class ucDiaDiem
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.txtTimKiemDiaDiem = new System.Windows.Forms.TextBox();
            this.cbLoaiDiaDiem = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.flpDanhSachDiaDiem = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.txtTimKiemDiaDiem);
            this.pnlTop.Controls.Add(this.cbLoaiDiaDiem);
            this.pnlTop.Controls.Add(this.btnTimKiem);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(788, 65);
            this.pnlTop.TabIndex = 0;
            // 
            // txtTimKiemDiaDiem
            // 
            this.txtTimKiemDiaDiem.Location = new System.Drawing.Point(20, 10);
            this.txtTimKiemDiaDiem.Multiline = true;
            this.txtTimKiemDiaDiem.Name = "txtTimKiemDiaDiem";
            this.txtTimKiemDiaDiem.Size = new System.Drawing.Size(283, 30);
            this.txtTimKiemDiaDiem.TabIndex = 1;
            // 
            // cbLoaiDiaDiem
            // 
            this.cbLoaiDiaDiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLoaiDiaDiem.FormattingEnabled = true;
            this.cbLoaiDiaDiem.Items.AddRange(new object[] {
            "Tất cả",
            "Địa điểm tham quan",
            "Quán ăn đặc sản",
            "Văn hóa-Lịch sử",
            "Khu du lịch vui chơi-giải trí"});
            this.cbLoaiDiaDiem.Location = new System.Drawing.Point(508, 14);
            this.cbLoaiDiaDiem.Name = "cbLoaiDiaDiem";
            this.cbLoaiDiaDiem.Size = new System.Drawing.Size(220, 24);
            this.cbLoaiDiaDiem.TabIndex = 3;
            this.cbLoaiDiaDiem.SelectedIndexChanged += new System.EventHandler(this.cbLoaiDiaDiem_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(320, 10);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(104, 30);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // flpDanhSachDiaDiem
            // 
            this.flpDanhSachDiaDiem.AutoScroll = true;
            this.flpDanhSachDiaDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDanhSachDiaDiem.Location = new System.Drawing.Point(0, 65);
            this.flpDanhSachDiaDiem.Name = "flpDanhSachDiaDiem";
            this.flpDanhSachDiaDiem.Size = new System.Drawing.Size(788, 448);
            this.flpDanhSachDiaDiem.TabIndex = 4;
            this.flpDanhSachDiaDiem.Paint += new System.Windows.Forms.PaintEventHandler(this.flpDanhSachDiaDiem_Paint);
            // 
            // ucDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpDanhSachDiaDiem);
            this.Controls.Add(this.pnlTop);
            this.Name = "ucDiaDiem";
            this.Size = new System.Drawing.Size(788, 513);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TextBox txtTimKiemDiaDiem;
        private System.Windows.Forms.ComboBox cbLoaiDiaDiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSachDiaDiem;
    }
}

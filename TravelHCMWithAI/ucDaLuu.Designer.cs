namespace TravelHCMWithAI
{
    partial class ucDaLuu
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
            this.pnlTopDaLuu = new System.Windows.Forms.Panel();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.lblTieuDeDaLuu = new System.Windows.Forms.Label();
            this.flpDaLuu = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopDaLuu.SuspendLayout();
            this.flpDaLuu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopDaLuu
            // 
            this.pnlTopDaLuu.Controls.Add(this.btnXoaTatCa);
            this.pnlTopDaLuu.Controls.Add(this.lblTieuDeDaLuu);
            this.pnlTopDaLuu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopDaLuu.Location = new System.Drawing.Point(0, 0);
            this.pnlTopDaLuu.Name = "pnlTopDaLuu";
            this.pnlTopDaLuu.Size = new System.Drawing.Size(978, 100);
            this.pnlTopDaLuu.TabIndex = 0;
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoaTatCa.Location = new System.Drawing.Point(507, 29);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(293, 43);
            this.btnXoaTatCa.TabIndex = 3;
            this.btnXoaTatCa.Text = "Xóa lịch trình đã lưu";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // lblTieuDeDaLuu
            // 
            this.lblTieuDeDaLuu.AutoSize = true;
            this.lblTieuDeDaLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDeDaLuu.Location = new System.Drawing.Point(27, 40);
            this.lblTieuDeDaLuu.Name = "lblTieuDeDaLuu";
            this.lblTieuDeDaLuu.Size = new System.Drawing.Size(258, 29);
            this.lblTieuDeDaLuu.TabIndex = 1;
            this.lblTieuDeDaLuu.Text = "DANH SÁCH ĐÃ LƯU";
            // 
            // flpDaLuu
            // 
            this.flpDaLuu.AutoScroll = true;
            this.flpDaLuu.Controls.Add(this.flowLayoutPanel1);
            this.flpDaLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDaLuu.Location = new System.Drawing.Point(0, 100);
            this.flpDaLuu.Name = "flpDaLuu";
            this.flpDaLuu.Size = new System.Drawing.Size(978, 548);
            this.flpDaLuu.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(228, 118);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ucDaLuu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpDaLuu);
            this.Controls.Add(this.pnlTopDaLuu);
            this.Name = "ucDaLuu";
            this.Size = new System.Drawing.Size(978, 648);
            this.pnlTopDaLuu.ResumeLayout(false);
            this.pnlTopDaLuu.PerformLayout();
            this.flpDaLuu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopDaLuu;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Label lblTieuDeDaLuu;
        private System.Windows.Forms.FlowLayoutPanel flpDaLuu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

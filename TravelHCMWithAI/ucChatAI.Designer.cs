namespace TravelHCMWithAI
{
    partial class ucChatAI
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
            this.flpQuickPrompts = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGoiYTour = new System.Windows.Forms.Button();
            this.btnAnUong = new System.Windows.Forms.Button();
            this.btnCafe = new System.Windows.Forms.Button();
            this.btnVuiChoi = new System.Windows.Forms.Button();
            this.btnNewChat = new System.Windows.Forms.Button();
            this.rtbChatContent = new System.Windows.Forms.RichTextBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtInputMessage = new System.Windows.Forms.TextBox();
            this.flpQuickPrompts.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpQuickPrompts
            // 
            this.flpQuickPrompts.Controls.Add(this.btnGoiYTour);
            this.flpQuickPrompts.Controls.Add(this.btnAnUong);
            this.flpQuickPrompts.Controls.Add(this.btnCafe);
            this.flpQuickPrompts.Controls.Add(this.btnVuiChoi);
            this.flpQuickPrompts.Controls.Add(this.btnNewChat);
            this.flpQuickPrompts.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpQuickPrompts.Location = new System.Drawing.Point(0, 0);
            this.flpQuickPrompts.Name = "flpQuickPrompts";
            this.flpQuickPrompts.Size = new System.Drawing.Size(788, 80);
            this.flpQuickPrompts.TabIndex = 0;
            // 
            // btnGoiYTour
            // 
            this.btnGoiYTour.Location = new System.Drawing.Point(3, 3);
            this.btnGoiYTour.Name = "btnGoiYTour";
            this.btnGoiYTour.Size = new System.Drawing.Size(208, 23);
            this.btnGoiYTour.TabIndex = 0;
            this.btnGoiYTour.Text = "Gợi ý tour 1 ngày TP.HCM";
            this.btnGoiYTour.UseVisualStyleBackColor = true;
            this.btnGoiYTour.Click += new System.EventHandler(this.btnGoiYTour_Click);
            // 
            // btnAnUong
            // 
            this.btnAnUong.Location = new System.Drawing.Point(217, 3);
            this.btnAnUong.Name = "btnAnUong";
            this.btnAnUong.Size = new System.Drawing.Size(186, 23);
            this.btnAnUong.TabIndex = 1;
            this.btnAnUong.Text = "Địa điểm ăn uống Quận 1";
            this.btnAnUong.UseVisualStyleBackColor = true;
            this.btnAnUong.Click += new System.EventHandler(this.btnAnUong_Click);
            // 
            // btnCafe
            // 
            this.btnCafe.Location = new System.Drawing.Point(409, 3);
            this.btnCafe.Name = "btnCafe";
            this.btnCafe.Size = new System.Drawing.Size(154, 23);
            this.btnCafe.TabIndex = 2;
            this.btnCafe.Text = "Quán cafe view đẹp";
            this.btnCafe.UseVisualStyleBackColor = true;
            this.btnCafe.Click += new System.EventHandler(this.btnCafe_Click);
            // 
            // btnVuiChoi
            // 
            this.btnVuiChoi.Location = new System.Drawing.Point(569, 3);
            this.btnVuiChoi.Name = "btnVuiChoi";
            this.btnVuiChoi.Size = new System.Drawing.Size(172, 23);
            this.btnVuiChoi.TabIndex = 3;
            this.btnVuiChoi.Text = "Khu vui chơi sầm uất";
            this.btnVuiChoi.UseVisualStyleBackColor = true;
            this.btnVuiChoi.Click += new System.EventHandler(this.btnVuiChoi_Click);
            // 
            // btnNewChat
            // 
            this.btnNewChat.Location = new System.Drawing.Point(3, 32);
            this.btnNewChat.Name = "btnNewChat";
            this.btnNewChat.Size = new System.Drawing.Size(183, 31);
            this.btnNewChat.TabIndex = 4;
            this.btnNewChat.Text = "Thêm cuộc trò chuyện mới";
            this.btnNewChat.UseVisualStyleBackColor = true;
            this.btnNewChat.Click += new System.EventHandler(this.btnNewChat_Click);
            // 
            // rtbChatContent
            // 
            this.rtbChatContent.BackColor = System.Drawing.Color.White;
            this.rtbChatContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbChatContent.Location = new System.Drawing.Point(0, 80);
            this.rtbChatContent.Name = "rtbChatContent";
            this.rtbChatContent.ReadOnly = true;
            this.rtbChatContent.Size = new System.Drawing.Size(788, 413);
            this.rtbChatContent.TabIndex = 1;
            this.rtbChatContent.Text = "";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnSend);
            this.pnlBottom.Controls.Add(this.txtInputMessage);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 433);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(788, 60);
            this.pnlBottom.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Location = new System.Drawing.Point(713, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 60);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtInputMessage
            // 
            this.txtInputMessage.Location = new System.Drawing.Point(3, 3);
            this.txtInputMessage.Multiline = true;
            this.txtInputMessage.Name = "txtInputMessage";
            this.txtInputMessage.Size = new System.Drawing.Size(584, 54);
            this.txtInputMessage.TabIndex = 0;
            // 
            // ucChatAI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.rtbChatContent);
            this.Controls.Add(this.flpQuickPrompts);
            this.Name = "ucChatAI";
            this.Size = new System.Drawing.Size(788, 493);
            this.flpQuickPrompts.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpQuickPrompts;
        private System.Windows.Forms.RichTextBox rtbChatContent;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtInputMessage;
        private System.Windows.Forms.Button btnGoiYTour;
        private System.Windows.Forms.Button btnAnUong;
        private System.Windows.Forms.Button btnCafe;
        private System.Windows.Forms.Button btnVuiChoi;
        private System.Windows.Forms.Button btnNewChat;
    }
}

namespace TravelHCMWithAI
{
    partial class frmDetail
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
            this.rtbDetailContent = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbDetailContent
            // 
            this.rtbDetailContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDetailContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDetailContent.Location = new System.Drawing.Point(0, 0);
            this.rtbDetailContent.Name = "rtbDetailContent";
            this.rtbDetailContent.ReadOnly = true;
            this.rtbDetailContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDetailContent.Size = new System.Drawing.Size(800, 450);
            this.rtbDetailContent.TabIndex = 0;
            this.rtbDetailContent.Text = "";
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDetailContent);
            this.Name = "frmDetail";
            this.Text = "frmDetail";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox rtbDetailContent;
    }
}
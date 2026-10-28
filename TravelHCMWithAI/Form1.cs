using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelHCMWithAI
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnTroChuyenAI.PerformClick();
        }

        private void btnTroChuyenAI_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            ucChatAI uc = new ucChatAI();
            uc.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(uc);
        }

        private void btnLichTrinh_Click(object sender, EventArgs e)
        {
            // Xóa nội dung cũ trong panel chính
            pnlMainContent.Controls.Clear();

            // Khởi tạo UserControl lịch trình
            ucLichTrinh uc = new ucLichTrinh();
            uc.Dock = DockStyle.Fill;

            // Thêm vào panel chính của Form1
            pnlMainContent.Controls.Add(uc);
        }

        private void btnDiaDiem_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            // Khởi tạo UserControl Địa điểm
            ucDiaDiem uc = new ucDiaDiem();
            uc.Dock = DockStyle.Fill;

            // Đưa lên panel chính của Form1
            pnlMainContent.Controls.Add(uc);
        }

        private void btnDaLuu_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            ucDaLuu uc = new ucDaLuu();
            uc.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(uc);
        }

        private void btnHoSo_Click(object sender, EventArgs e)
        {
            pnlMainContent.Controls.Clear();

            ucHoSo uc = new ucHoSo();
            uc.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(uc);
        }

        private void HienThiKhungChatAI()
        {
            // Cho hiển thị các control Chat AI trên pnlMainContent
            rtbLichSuChat.Visible = true;
            flpPromptChips.Visible = true;
            pnlKhungNhapTinNhan.Visible = true;
        }
    }
}

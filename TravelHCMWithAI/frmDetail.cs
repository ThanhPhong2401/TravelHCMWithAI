using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelHCMWithAI
{
    public partial class frmDetail : Form
    {
        public frmDetail(string title, string content)
        {
            InitializeComponent();
        
            this.Text = title;
            this.Width = 700;
            this.Height = 500;
            this.StartPosition = FormStartPosition.CenterParent;

            rtbDetailContent.Multiline = true;
            rtbDetailContent.ReadOnly = true;
            rtbDetailContent.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            rtbDetailContent.Text = content;

        }
    }
}

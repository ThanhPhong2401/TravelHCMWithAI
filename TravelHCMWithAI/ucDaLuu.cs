using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TravelHCMWithAI
{
    public partial class ucDaLuu : UserControl
    {
        private string connectionString = "Server=localhost;Database=ChatBotAIDuLich;Uid=root;Pwd=1234;";

        public ucDaLuu()
        {
            InitializeComponent();
            LoadChatHistory();
        }

        private void LoadChatHistory()
        {
            if (string.IsNullOrEmpty(UserSession.CurrentEmail)) return;

            FlowLayoutPanel targetContainer = this.Controls["flpDaLuu"] as FlowLayoutPanel
                                              ?? this.Controls["flowLayoutPanel1"] as FlowLayoutPanel;

            if (targetContainer != null)
            {
                targetContainer.Controls.Clear();
                targetContainer.AutoScroll = true;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Lấy UserId
                    int currentUserId = -1;
                    string getUserIdQuery = "SELECT UserId FROM Users WHERE Email = @Email";
                    using (MySqlCommand cmdUser = new MySqlCommand(getUserIdQuery, conn))
                    {
                        cmdUser.Parameters.AddWithValue("@Email", UserSession.CurrentEmail);
                        object result = cmdUser.ExecuteScalar();
                        if (result != null) currentUserId = Convert.ToInt32(result);
                    }

                    if (currentUserId == -1) return;

                    // 2. Truy vấn lịch sử chat
                    string query = "SELECT ChatID, Message, Sender, CreatedAt FROM chathistory WHERE UserId = @UserId ORDER BY CreatedAt DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", currentUserId);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            foreach (DataRow row in dt.Rows)
                            {
                                int chatId = Convert.ToInt32(row["ChatID"]);
                                string message = row["Message"].ToString();
                                string sender = row["Sender"].ToString();
                                string time = row["CreatedAt"] != DBNull.Value
                                    ? Convert.ToDateTime(row["CreatedAt"]).ToString("dd/MM/yyyy HH:mm:ss")
                                    : "";

                                // Tạo Card Panel
                                Panel pnlCard = new Panel();
                                pnlCard.Width = 650;
                                pnlCard.Height = 120;
                                pnlCard.BorderStyle = BorderStyle.FixedSingle;
                                pnlCard.BackColor = Color.White;
                                pnlCard.Margin = new Padding(10);

                                // Tiêu đề Sender và Thời gian
                                Label lblSender = new Label();
                                lblSender.Text = $"{sender} ({time})";
                                lblSender.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                                lblSender.ForeColor = sender == "Bạn" ? Color.Teal : Color.DarkBlue;
                                lblSender.Location = new Point(15, 10);
                                lblSender.AutoSize = true;
                                pnlCard.Controls.Add(lblSender);

                                // Nội dung (cắt gọn nếu quá dài để hiển thị xem trước)
                                Label lblMessage = new Label();
                                lblMessage.Text = message;
                                lblMessage.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
                                lblMessage.Location = new Point(15, 35);
                                lblMessage.Width = 610;
                                lblMessage.Height = 45;
                                pnlCard.Controls.Add(lblMessage);

                                // Nút "Xem chi tiết" để xem toàn bộ nội dung dài
                                Button btnDetail = new Button();
                                btnDetail.Text = "Xem chi tiết";
                                btnDetail.Width = 90;
                                btnDetail.Height = 25;
                                btnDetail.Location = new Point(460, 85);
                                btnDetail.BackColor = Color.LightCyan;
                                btnDetail.FlatStyle = FlatStyle.Flat;
                                btnDetail.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
                                btnDetail.Tag = message;

                                btnDetail.Click += (s, e) => {
                                    Button clickedButton = s as Button;
                                    if (clickedButton != null && clickedButton.Tag != null)
                                    {
                                        string fullContent = clickedButton.Tag.ToString();

                                        // Mở thẳng Form chi tiết có thanh cuộn
                                        frmDetail detailForm = new frmDetail($"Chi tiết nội dung - {sender} ({time})", fullContent);
                                        detailForm.ShowDialog();
                                    }
                                };
                                pnlCard.Controls.Add(btnDetail);

                                // Nút Xóa từng dòng
                                Button btnDelete = new Button();
                                btnDelete.Text = "Xóa";
                                btnDelete.Width = 60;
                                btnDelete.Height = 25;
                                btnDelete.Location = new Point(565, 85);
                                btnDelete.BackColor = Color.MistyRose;
                                btnDelete.FlatStyle = FlatStyle.Flat;
                                btnDelete.Tag = chatId;
                                btnDelete.Click += BtnDelete_Click;
                                pnlCard.Controls.Add(btnDelete);

                                if (targetContainer != null)
                                {
                                    targetContainer.Controls.Add(pnlCard);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lịch sử chat: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                int chatId = Convert.ToInt32(btn.Tag);

                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa mục lịch sử này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(connectionString))
                        {
                            conn.Open();
                            string deleteQuery = "DELETE FROM chathistory WHERE ChatID = @ChatID";
                            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@ChatID", chatId);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        LoadChatHistory();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                    }
                }
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa toàn bộ lịch sử trò chuyện của tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        int userId = -1;
                        string getUid = "SELECT UserId FROM Users WHERE Email = @Email";
                        using (MySqlCommand cmdU = new MySqlCommand(getUid, conn))
                        {
                            cmdU.Parameters.AddWithValue("@Email", UserSession.CurrentEmail);
                            object res = cmdU.ExecuteScalar();
                            if (res != null) userId = Convert.ToInt32(res);
                        }

                        if (userId != -1)
                        {
                            string deleteAll = "DELETE FROM chathistory WHERE UserId = @UserId";
                            using (MySqlCommand cmdDel = new MySqlCommand(deleteAll, conn))
                            {
                                cmdDel.Parameters.AddWithValue("@UserId", userId);
                                cmdDel.ExecuteNonQuery();
                            }
                        }
                    }

                    LoadChatHistory();
                    MessageBox.Show("Đã xóa sạch lịch sử trò chuyện!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa tất cả: " + ex.Message);
                }
            }
        }
    }
}

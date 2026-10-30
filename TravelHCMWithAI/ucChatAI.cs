using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace TravelHCMWithAI
{
    public partial class ucChatAI : UserControl
    {
        private string connectionString = "Server=localhost;Database=ChatBotAIDuLich;Uid=root;Pwd=1234;";
        private string apiKey = "";
        private string userPreferences = "";
        private static readonly HttpClient httpClient = new HttpClient();
        public ucChatAI()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            if (string.IsNullOrEmpty(UserSession.CurrentEmail)) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT GeminiApiKey, TravelPreferences FROM Users WHERE Email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", UserSession.CurrentEmail);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                apiKey = reader["GeminiApiKey"]?.ToString();
                                userPreferences = reader["TravelPreferences"]?.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AppendChatMessage("Hệ thống", $"Lỗi tải cấu hình người dùng: {ex.Message}");
            }
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            string userPrompt = txtInputMessage.Text.Trim();
            if (string.IsNullOrEmpty(userPrompt)) return;

            // 1. Hiển thị tin nhắn của User lên khung chat
            AppendChatMessage("Bạn", userPrompt);
            txtInputMessage.Clear();

            // 2. Gọi API Gemini
            btnSend.Enabled = false;
            AppendChatMessage("AI Trợ lý", "Đang suy nghĩ...");

            string aiResponse = await CallGeminiApiAsync(userPrompt);
            aiResponse = CleanMarkdown(aiResponse);
            // Xóa dòng "Đang suy nghĩ..." và in câu trả lời thực tế
            RemoveLastLine();
            AppendChatMessage("AI Trợ lý", aiResponse);
            SaveChatHistoryToDatabase(userPrompt, aiResponse);
            btnSend.Enabled = true;
        }

        private void btnGoiYTour_Click(object sender, EventArgs e)
        {
            txtInputMessage.Text = "Gợi ý cho tôi tour du lịch 1 ngày tại TP.HCM chi tiết nhất.";
            btnSend_Click(sender, e);
        }

        private void btnAnUong_Click(object sender, EventArgs e)
        {
            txtInputMessage.Text = "Gợi ý danh sách các địa điểm ăn uống ngon nổi tiếng tại Quận 1.";
            btnSend_Click(sender, e);
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            txtInputMessage.Text = "Gợi ý những quán cà phê có view đẹp, không gian yên tĩnh ở Sài Gòn.";
            btnSend_Click(sender, e);
        }

        private void btnVuiChoi_Click(object sender, EventArgs e)
        {
            txtInputMessage.Text = "Gợi ý những khu vui chơi sầm uất bậc nhất Quận 1.";
            btnSend_Click(sender, e);
        }

        private async Task<string> CallGeminiApiAsync(string userQuery)
        {
            // Nếu chưa nhập API Key trong Database thì dùng chế độ mô phỏng Test
            if (string.IsNullOrEmpty(apiKey))
            {
                await Task.Delay(1000); // Giả lập độ trễ mạng 1s
                return $"[Chế độ Demo - Chưa cài GeminiApiKey trong DB]\nBạn vừa hỏi: '{userQuery}'.\n(Sở thích của bạn: {userPreferences}). Để kết nối AI thực tế, bạn hãy thêm Gemini API Key vào cột GeminiApiKey trong bảng Users nhé!";
            }

            try
            {
                string endpoint = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-3.6-flash:generateContent?key={apiKey}";

                // Prompt kịch bản cho AI đóng vai Trợ lý Du lịch TP.HCM
                string systemPrompt = $"Bạn là Trợ lý AI du lịch TP.Hồ Chí Minh. Người dùng có sở thích: '{userPreferences}'. Hãy trả lời thân thiện, hữu ích và tập trung vào địa điểm/ẩm thực TP.HCM. Yêu cầu của người dùng: {userQuery}";

                using (HttpClient client = new HttpClient())
                {
                    var requestBody = new
                    {
                        contents = new[]
                        {
                            new
                            {
                                parts = new[]
                                {
                                    new { text = systemPrompt }
                                }
                            }
                        }
                    };

                    string jsonContent = Newtonsoft.Json.JsonConvert.SerializeObject(requestBody);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(endpoint, content);
                    string responseString = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        JObject json = JObject.Parse(responseString);
                        string reply = json["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString();
                        return reply ?? "Không nhận được phản hồi từ AI.";
                    }
                    else
                    {
                        return $"Lỗi API ({response.StatusCode}): {responseString}";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Lỗi kết nối Gemini API: {ex.Message}";
            }
        }
              
        private void AppendChatMessage(string senderName, string message)
        {
            rtbChatContent.SelectionStart = rtbChatContent.TextLength;
            rtbChatContent.SelectionLength = 0;

            if (senderName == "Bạn")
            {
                rtbChatContent.SelectionColor = Color.DarkBlue;
                rtbChatContent.SelectionFont = new Font(rtbChatContent.Font, FontStyle.Bold);
            }
            else if (senderName == "AI Trợ lý")
            {
                rtbChatContent.SelectionColor = Color.Teal;
                rtbChatContent.SelectionFont = new Font(rtbChatContent.Font, FontStyle.Bold);
            }
            else
            {
                rtbChatContent.SelectionColor = Color.Red;
            }

            rtbChatContent.AppendText($"{senderName}: ");
            rtbChatContent.SelectionColor = Color.Black;
            rtbChatContent.SelectionFont = new Font(rtbChatContent.Font, FontStyle.Regular);
            rtbChatContent.AppendText($"{message}\n\n");

            // Tự động cuộn xuống dòng cuối cùng
            rtbChatContent.ScrollToCaret();
        }

        private void RemoveLastLine()
        {
            int lastIndex = rtbChatContent.Text.LastIndexOf("AI Trợ lý: Đang suy nghĩ...");
            if (lastIndex >= 0)
            {
                rtbChatContent.Text = rtbChatContent.Text.Remove(lastIndex);
            }
        }
        private string CleanMarkdown(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;

            // 1. Xóa các ký tự tiêu đề (#, ##, ###, ...)
            string cleaned = Regex.Replace(input, @"#+\s*", "");

            // 2. Xóa các ký tự in đậm/in nghiêng (* hoặc _)
            cleaned = Regex.Replace(cleaned, @"(\*\*|__|\*|_)", "");

            return cleaned;
        }
        private void SaveChatHistoryToDatabase(string userQuery, string aiResponse)
        {
            if (string.IsNullOrEmpty(UserSession.CurrentEmail)) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // 1. Lấy UserId của tài khoản đang đăng nhập từ bảng Users
                    int currentUserId = -1;
                    string getUidQuery = "SELECT UserId FROM Users WHERE Email = @Email";
                    using (MySqlCommand cmdU = new MySqlCommand(getUidQuery, conn))
                    {
                        cmdU.Parameters.AddWithValue("@Email", UserSession.CurrentEmail);
                        object res = cmdU.ExecuteScalar();
                        if (res != null)
                        {
                            currentUserId = Convert.ToInt32(res);
                        }
                    }

                    if (currentUserId == -1) return;

                    // 2. Lưu câu hỏi của User vào bảng chathistory (khớp đúng 5 cột: ChatID(AI), UserId, Message, Sender, CreatedAt)
                    string insertUserChat = "INSERT INTO chathistory (UserId, Message, Sender, CreatedAt) VALUES (@UserId, @Message, @Sender, NOW())";
                    using (MySqlCommand cmdInsUser = new MySqlCommand(insertUserChat, conn))
                    {
                        cmdInsUser.Parameters.AddWithValue("@UserId", currentUserId);
                        cmdInsUser.Parameters.AddWithValue("@Message", userQuery);
                        cmdInsUser.Parameters.AddWithValue("@Sender", "Bạn");
                        cmdInsUser.ExecuteNonQuery();
                    }

                    // 3. Lưu câu trả lời của AI vào bảng chathistory
                    string insertAiChat = "INSERT INTO chathistory (UserId, Message, Sender, CreatedAt) VALUES (@UserId, @Message, @Sender, NOW())";
                    using (MySqlCommand cmdInsAi = new MySqlCommand(insertAiChat, conn))
                    {
                        cmdInsAi.Parameters.AddWithValue("@UserId", currentUserId);
                        cmdInsAi.Parameters.AddWithValue("@Message", aiResponse);
                        cmdInsAi.Parameters.AddWithValue("@Sender", "AI Trợ lý");
                        cmdInsAi.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Ghi log lỗi ngầm nếu không lưu được
                Console.WriteLine("Lỗi lưu lịch sử chat: " + ex.Message);
            }
        }

        private void btnNewChat_Click(object sender, EventArgs e)
        {
            rtbChatContent.Clear(); // Hoặc xóa các control panel chat nếu bạn dùng Panel chứa các card chat

            // Khởi tạo lại lịch sử trò chuyện hoặc reset các biến trạng thái AI nếu cần
            MessageBox.Show("Đã bắt đầu cuộc trò chuyện mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

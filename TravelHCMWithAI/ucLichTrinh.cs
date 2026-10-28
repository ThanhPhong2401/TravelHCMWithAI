using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;
using System.Net.Http;

namespace TravelHCMWithAI
{
    public partial class ucLichTrinh : UserControl
    {
        private string connectionString = "Server=localhost;Database=ChatBotAIDuLich;Uid=root;Pwd=1234;";
        private string apiKey = "";

        public ucLichTrinh()
        {
            InitializeComponent();
            LoadApiKey();
        }
        private void LoadApiKey()
        {
            if (string.IsNullOrEmpty(UserSession.CurrentEmail)) return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT GeminiApiKey FROM Users WHERE Email = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", UserSession.CurrentEmail);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            apiKey = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải API Key: " + ex.Message);
            }
        }

        private async void btnTaoLichTrinh_Click(object sender, EventArgs e)
        {
            // 1. Lấy thông tin từ các điều khiển trên giao diện
            string soNgay = cbSoNgay.Text.Trim(); // ComboBox số ngày
            string nganSach = cbNganSach.Text.Trim(); // ComboBox ngân sách
            string phuongTien = cbPhuongTien.Text.Trim(); // ComboBox phương tiện

            string phongCach = "";
            foreach (var item in cklPhongCach.CheckedItems)
            {
                phongCach += item.ToString() + ", ";
            }
            if (phongCach.EndsWith(", ")) phongCach = phongCach.Substring(0, phongCach.Length - 2);

            // Kiểm tra nếu chưa nhập API Key
            if (string.IsNullOrEmpty(apiKey))
            {
                rtbKetQuaLichTrinh.Text = "[Lỗi]: Chưa cấu hình Gemini API Key trong tài khoản của bạn. Vui lòng cập nhật API Key để sử dụng tính năng này!";
                return;
            }

            // Khóa nút để tránh bấm nhiều lần
            btnTaoLichTrinh.Enabled = false;
            rtbKetQuaLichTrinh.Text = "⏳ AI đang phân tích và thiết kế lịch trình chi tiết riêng cho bạn, vui lòng đợi trong giây lát...";

            // 2. Xây dựng câu lệnh Prompt chuyên nghiệp gửi cho Gemini
            string prompt = $"Hãy đóng vai một chuyên gia hướng dẫn du lịch TP.HCM. Hãy lập một lịch trình du lịch chi tiết bằng tiếng Việt dựa trên các tiêu chí sau:\n" +
                            $"- Thời gian tham quan: {soNgay}\n" +
                            $"- Ngân sách dự kiến: {nganSach}\n" +
                            $"- Phong cách yêu thích: {phongCach}\n" +
                            $"- Phương tiện di chuyển chính: {phuongTien}\n\n" +
                            $"Yêu cầu trình bày rõ ràng theo từng ngày, chia theo các buổi (Sáng, Trưa, Chiều, Tối), kèm theo tên địa điểm cụ thể, gợi ý món ăn/hoạt động đặc trưng và mẹo di chuyển phù hợp tại TP.HCM.";

            // 3. Gọi Gemini API bất đồng bộ
            string aiResponse = await CallGeminiApiForItineraryAsync(prompt);

            // 4. Hiển thị kết quả lên RichTextBox
            rtbKetQuaLichTrinh.Text = aiResponse;
            btnTaoLichTrinh.Enabled = true;
        }
        private async Task<string> CallGeminiApiForItineraryAsync(string userPrompt)
        {
            try
            {
                string endpoint = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-3.8-flash:generateContent?key={apiKey}";

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
                                    new { text = userPrompt }
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
                return $"Lỗi kết nối: {ex.Message}";
            }
        }

    }
}

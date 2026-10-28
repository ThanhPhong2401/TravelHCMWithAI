using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TravelHCMWithAI
{
    public partial class frmDangNhap : Form
    {
        private string connectionString = "Server=localhost;Database=ChatBotAIDuLich;Uid=root;Pwd=1234;Charset=utf8mb4;";

        // Biến toàn cục lưu UserId sau khi đăng nhập thành công
        public static int CurrentUserId = 0;
        public static string CurrentFullName = "";
        public frmDangNhap()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtEmailDN.Focus();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string email  = txtEmailDN.Text.Trim();
            string password = txtMatKhauDN.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email và Mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT UserId, FullName FROM Users WHERE Email = @email AND Password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        UserSession.CurrentEmail = email;
                        CurrentUserId = Convert.ToInt32(reader["UserId"]);
                        CurrentFullName = reader["FullName"].ToString();

                        MessageBox.Show($"Đăng nhập thành công! Chào mừng {CurrentFullName}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Mở Trang chủ (Form1) và ẩn Form Đăng nhập
                        Form1 mainForm = new Form1();
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Email hoặc mật khẩu không chính xác!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string username = txtTenDangNhapDK.Text.Trim();
            string password = txtMatKhauDK.Text.Trim();
            string fullName = txtHoTenDK.Text.Trim();
            string email = txtEmailDK.Text.Trim();
            string preferences = txtSoThichDK.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // 1. Kiểm tra Tên đăng nhập hoặc Email đã tồn tại chưa
                    string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @username OR Email = @email";
                    MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@username", username);
                    checkCmd.Parameters.AddWithValue("@email", email);

                    long count = (long)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Tên đăng nhập hoặc Email đã được sử dụng. Vui lòng chọn tên khác!", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // 2. Thêm người dùng mới vào bảng Users
                    string insertQuery = @"INSERT INTO Users (Username, Password, FullName, Email, TravelPreferences) 
                                         VALUES (@username, @password, @fullName, @email, @preferences)";

                    MySqlCommand insertCmd = new MySqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@username", username);
                    insertCmd.Parameters.AddWithValue("@password", password);
                    insertCmd.Parameters.AddWithValue("@fullName", fullName);
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.Parameters.AddWithValue("@preferences", preferences);

                    int result = insertCmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công! Hãy đăng nhập để bắt đầu trải nghiệm.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Tự động làm sạch các ô nhập
                        XoaThongTinDangKy();

                        // Chuyển người dùng sang Tab Đăng nhập
                        tabControlAuth.SelectedTab = tabDangNhap;
                        txtEmailDN.Text = email; // Điền sẵn email vừa đăng ký
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đăng ký: " + ex.Message, "Lỗi MySQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void XoaThongTinDangKy()
        {
            txtTenDangNhapDK.Clear();
            txtMatKhauDK.Clear();
            txtHoTenDK.Clear();
            txtEmailDK.Clear();
            txtSoThichDK.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

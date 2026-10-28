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
    public partial class ucHoSo : UserControl
    {
        private string connectionString = "Server=localhost;Database=ChatBotAIDuLich;Uid=root;Pwd=1234;";
        public ucHoSo()
        {
            InitializeComponent();
            LoadUserProfile();
        }
        private void LoadUserProfile()
        {
            // Kiểm tra xem đã có phiên đăng nhập chưa
            if (string.IsNullOrEmpty(UserSession.CurrentEmail))
            {
                MessageBox.Show("Chưa nhận diện được phiên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    // Câu lệnh SELECT lấy đúng các cột trong bảng users theo email đã đăng nhập
                    string query = "SELECT Username, Fullname, Email, TravelPreferences, Avatar FROM users WHERE Email = @email";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", UserSession.CurrentEmail);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đổ dữ liệu thực tế từ DB lên các control giao diện
                                txtUsername.Text = reader["Username"].ToString();
                                txtFullName.Text = reader["Fullname"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                rtbSoThich.Text = reader["TravelPreferences"].ToString();
                                if (reader["Avatar"] != DBNull.Value)
                                {
                                    string avatarPath = reader["Avatar"].ToString();
                                    if (!string.IsNullOrEmpty(avatarPath) && System.IO.File.Exists(avatarPath))
                                    {
                                        picAvatar.Image = Image.FromFile(avatarPath);
                                        picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                                    }
                                }
                            }
                        }
                    }
                }

                // Đặt txtUsername ở chế độ ReadOnly để bảo vệ tên đăng nhập
                txtUsername.ReadOnly = true;
                txtUsername.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nạp thông tin hồ sơ: {ex.Message}", "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string currentAvatarPath = "";
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            openFile.Title = "Chọn ảnh đại diện mới";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    currentAvatarPath = openFile.FileName; // Lưu lại đường dẫn file vừa chọn
                    picAvatar.Image = Image.FromFile(currentAvatarPath);
                    picAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Không thể mở file ảnh: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string preferences = rtbSoThich.Text.Trim(); // Lấy giá trị từ rtbSoThich

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Họ và tên và Email không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE users SET Fullname = @fullname, Email = @email, TravelPreferences = @preference, Avatar = @avatar WHERE Email = @currentEmail";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@fullname", fullName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@preference", preferences);
                        cmd.Parameters.AddWithValue("@avatar", currentAvatarPath);
                        cmd.Parameters.AddWithValue("@currentEmail", UserSession.CurrentEmail);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            // Cập nhật lại Session nếu người dùng đổi email mới
                            UserSession.CurrentEmail = email;
                            MessageBox.Show("Cập nhật thông tin hồ sơ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật: {ex.Message}", "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất khỏi tài khoản không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 1. Xóa thông tin phiên đăng nhập hiện tại
                UserSession.CurrentEmail = null;

                // 2. Ẩn hoặc đóng cửa sổ chính (Form1) hiện tại
                Form mainForm = this.FindForm();
                if (mainForm != null)
                {
                    mainForm.Hide();
                }

                // 3. Mở lại Form đăng nhập ban đầu
                frmDangNhap loginForm = new frmDangNhap();
                loginForm.ShowDialog();

                // 4. Khi form đăng nhập đóng lại, thoát hẳn ứng dụng hoặc xử lý tiếp tùy ý
                if (mainForm != null)
                {
                    mainForm.Close();
                }
            }
        }
    }
}

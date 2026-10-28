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
    public partial class ucDiaDiem : UserControl
    {
        private DataTable dtDiaDiem;
        public ucDiaDiem()
        {
            InitializeComponent();
            KhoiTaoDuLieuMau();
            HienThiDanhSach(dtDiaDiem);
        }


        private void KhoiTaoDuLieuMau()
        {
            dtDiaDiem = new DataTable();
            dtDiaDiem.Columns.Add("TenDiaDiem", typeof(string));
            dtDiaDiem.Columns.Add("Loai", typeof(string));
            dtDiaDiem.Columns.Add("DiaChi", typeof(string));
            dtDiaDiem.Columns.Add("MoTa", typeof(string));

            // --- 1. ĐỊA ĐIỂM THAM QUAN ---
            dtDiaDiem.Rows.Add("Nhà thờ Đức Bà", "Địa điểm tham quan", "Công xã Paris, Bến Nghé, Quận 1", "Biểu tượng kiến trúc đặc sắc và lâu đời tại trung tâm Sài Gòn.");
            dtDiaDiem.Rows.Add("Bến cảng Nhà Rồng", "Địa điểm tham quan", "01 Nguyễn Tất Thành, Phường 12, Quận 4", "Nơi lưu dấu sự kiện Chủ tịch Hồ Chí Minh ra đi tìm đường cứu nước.");
            dtDiaDiem.Rows.Add("Hồ Con Rùa", "Địa điểm tham quan", "Công trường Quốc tế, Phường 6, Quận 3", "Điểm hẹn quen thuộc về đêm với không gian thoáng đãng và nhiều món ăn vặt.");

            // --- 2. QUÁN ĂN ĐẶC SẢN ---
            dtDiaDiem.Rows.Add("Cơm tấm Ba Ghiền", "Quán ăn đặc sản", "84 Đặng Văn Ngữ, Phú Nhuận", "Quán cơm tấm trứ danh với miếng sườn nướng đậm đà, thơm phức.");
            dtDiaDiem.Rows.Add("Bánh mì Huỳnh Hoa", "Quán ăn đặc sản", "26 Lê Thị Riêng, Bến Thành, Quận 1", "Tiệm bánh mì 'đắt nhất Sài Gòn' với phần nhân pate và chả vô cùng ngập tràn.");
            dtDiaDiem.Rows.Add("Phở Hòa Pasteur", "Quán ăn đặc sản", "260C Pasteur, Phường 8, Quận 3", "Tiệm phở gia truyền lâu đời nức lòng thực khách trong và ngoài nước.");

            // --- 3. VĂN HÓA - LỊCH SỬ ---
            dtDiaDiem.Rows.Add("Bưu điện Trung tâm Sài Gòn", "Văn hóa-Lịch sử", "2 Công xã Paris, Bến Nghé, Quận 1", "Công trình mang phong cách kiến trúc Pháp cổ kính kết hợp nét Á Đông.");
            dtDiaDiem.Rows.Add("Dinh Thống Nhất", "Văn hóa-Lịch sử", "135 Nam Kỳ Khởi Nghĩa, Bến Thành, Quận 1", "Di tích lịch sử quốc gia đặc biệt, nơi lưu giữ nhiều dấu ấn thời gian.");
            dtDiaDiem.Rows.Add("Bảo tàng Chứng tích Chiến tranh", "Văn hóa-Lịch sử", "28 Võ Văn Tần, Phường 6, Quận 3", "Nơi trưng bày các tư liệu và hiện vật lịch sử quý giá từ cuộc kháng chiến.");

            // --- 4. KHU DU LỊCH VUI CHƠI - GIẢI TRÍ ---
            dtDiaDiem.Rows.Add("Thảo Cầm Viên Sài Gòn", "Khu du lịch vui chơi-giải trí", "2 Nguyễn Bỉnh Khiêm, Bến Nghé, Quận 1", "Khu bảo tồn động thực vật lâu đời, không gian xanh mát giữa lòng thành phố.");
            dtDiaDiem.Rows.Add("Phố đi bộ Nguyễn Huệ", "Khu du lịch vui chơi-giải trí", "Đường Nguyễn Huệ, Bến Nghé, Quận 1", "Nơi diễn ra các hoạt động vui chơi, giải trí và sự kiện lớn về đêm.");
            dtDiaDiem.Rows.Add("Công viên Văn hóa Đầm Sen", "Khu du lịch vui chơi-giải trí", "3 Hòa Bình, Phường 3, Quận 11", "Khu vui chơi giải trí phức hợp với nhiều trò chơi cảm giác mạnh và hồ bơi lớn.");
        }

        // Hàm dựng Card giao diện cho từng địa điểm và đưa vào FlowLayoutPanel
        private void HienThiDanhSach(DataTable dt)
        {
            flpDanhSachDiaDiem.Controls.Clear(); // Xóa các card cũ trước khi nạp mới

            foreach (DataRow row in dt.Rows)
            {
                string ten = row["TenDiaDiem"].ToString();
                string loai = row["Loai"].ToString();
                string diachi = row["DiaChi"].ToString();
                string mota = row["MoTa"].ToString();

                // Tạo một Panel làm khung thẻ Card
                Panel card = new Panel();
                card.Width = 260;
                card.Height = 180;
                card.BackColor = Color.White;
                card.BorderStyle = BorderStyle.FixedSingle;
                card.Margin = new Padding(12);

                // Label hiển thị Tên Địa Điểm
                Label lblTen = new Label();
                lblTen.Text = ten;
                lblTen.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblTen.ForeColor = Color.DarkSlateBlue;
                lblTen.Location = new Point(10, 10);
                lblTen.AutoSize = false;
                lblTen.Width = 238;
                lblTen.Height = 25;

                // Label hiển thị Loại (Danh mục)
                Label lblLoai = new Label();
                lblLoai.Text = $"🏷️ {loai}";
                lblLoai.Font = new Font("Segoe UI", 8.5f, FontStyle.Italic);
                lblLoai.ForeColor = Color.Gray;
                lblLoai.Location = new Point(10, 38);
                lblLoai.AutoSize = true;

                // Label hiển thị Địa Chỉ
                Label lblDiaChi = new Label();
                lblDiaChi.Text = $"📍 {diachi}";
                lblDiaChi.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lblDiaChi.ForeColor = Color.DimGray;
                lblDiaChi.Location = new Point(10, 62);
                lblDiaChi.AutoSize = false;
                lblDiaChi.Width = 238;
                lblDiaChi.Height = 35;

                // Label hiển thị Mô Tả ngắn
                Label lblMoTa = new Label();
                lblMoTa.Text = mota;
                lblMoTa.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lblMoTa.ForeColor = Color.Black;
                lblMoTa.Location = new Point(10, 102);
                lblMoTa.AutoSize = false;
                lblMoTa.Width = 238;
                lblMoTa.Height = 65;

                // Thêm các control con vào Card Panel
                card.Controls.Add(lblTen);
                card.Controls.Add(lblLoai);
                card.Controls.Add(lblDiaChi);
                card.Controls.Add(lblMoTa);

                // Thêm Card vào FlowLayoutPanel chính
                flpDanhSachDiaDiem.Controls.Add(card);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            ThucHienLocVaTimKiem();
        }

        private void cbLoaiDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThucHienLocVaTimKiem();
        }

        private void ThucHienLocVaTimKiem()
        {
            string tuKhoa = txtTimKiemDiaDiem.Text.Trim().ToLower();
            string loaiChon = cbLoaiDiaDiem.SelectedItem?.ToString() ?? "Tất cả";

            string filterExpression = "";

            // Xử lý lọc theo danh mục
            if (loaiChon != "Tất cả")
            {
                filterExpression += $"Loai = '{loaiChon}'";
            }

            // Xử lý lọc theo từ khóa nhập vào ô tìm kiếm
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                if (filterExpression != "") filterExpression += " AND ";
                filterExpression += $"TenDiaDiem LIKE '%{tuKhoa}%'";
            }

            // Lọc dữ liệu trong DataTable
            DataRow[] rows = dtDiaDiem.Select(filterExpression);
            DataTable dtFiltered = dtDiaDiem.Clone();
            foreach (DataRow r in rows)
            {
                dtFiltered.ImportRow(r);
            }

            HienThiDanhSach(dtFiltered);
        }

        private void flpDanhSachDiaDiem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

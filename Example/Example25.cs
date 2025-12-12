using System;
using System.Drawing; // Cần thiết để dùng Point, Size, Color
using System.Windows.Forms;

namespace Example
{
    public partial class Example25 : Form
    {
        // 1. Khai báo các đối tượng và biến toàn cục (Slide 162)
        PictureBox pb = new PictureBox();
        // Dùng rõ System.Windows.Forms.Timer để tránh lỗi trùng tên với System.Threading.Timer
        System.Windows.Forms.Timer tmGame = new System.Windows.Forms.Timer();

        // Tọa độ hiện tại của bóng
        int xBall = 0;
        int yBall = 0;

        // Độ thay đổi (tốc độ) di chuyển mỗi lần Tick
        int xDelta = 5;
        int yDelta = 5;

        public Example25()
        {
            InitializeComponent();
        }

        // 2. Cấu hình Timer và PictureBox khi Form bắt đầu chạy (Slide 163)
        // Bạn cần gán sự kiện Load này vào Form (xem Bước 4)
        private void Example25_Load_1(object sender, EventArgs e)
        {
            // Cấu hình Timer
            tmGame.Interval = 10; // Tốc độ chạy (số càng nhỏ càng nhanh)
            tmGame.Tick += new EventHandler(tmGame_Tick); // Gán sự kiện Tick
            tmGame.Start(); // Bắt đầu chạy ngay

            // Cấu hình PictureBox (Quả bóng)
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Size = new Size(50, 50); // Kích thước bóng
            pb.Location = new Point(xBall, yBall);

            // --- Tùy chọn hiển thị ---
            // Cách 1: Dùng ảnh từ file (như Slide 163). Hãy bỏ comment nếu bạn có file ảnh.
            pb.ImageLocation = @"D:\LTwindows\LTWindows\Example\Images\download.jpg";

            // Cách 2: Nếu không có ảnh, dùng màu đỏ để thay thế (để test)
            //pb.BackColor = Color.Red;
            // ------------------------

            // Quan trọng: Thêm bóng vào Form
            this.Controls.Add(pb);
        }

        // 3. Xử lý chuyển động và va chạm (Slide 163)
        void tmGame_Tick(object sender, EventArgs e)
        {
            // Thay đổi tọa độ
            xBall += xDelta;
            yBall += yDelta;

            // Kiểm tra va chạm chiều Ngang (Trái/Phải)
            // ClientSize.Width là chiều rộng lọt lòng của Form (không tính viền)
            if (xBall > this.ClientSize.Width - pb.Width || xBall <= 0)
            {
                xDelta = -xDelta; // Đảo chiều di chuyển ngang
            }

            // Kiểm tra va chạm chiều Dọc (Trên/Dưới)
            if (yBall > this.ClientSize.Height - pb.Height || yBall <= 0)
            {
                yDelta = -yDelta; // Đảo chiều di chuyển dọc
            }

            // Cập nhật vị trí mới cho PictureBox
            pb.Location = new Point(xBall, yBall);
        }
    }
}
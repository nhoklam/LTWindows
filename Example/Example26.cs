using System;
using System.Drawing; // Để dùng Point, Size, Color, Image
using System.Windows.Forms;

namespace Example
{
    public partial class Example26 : Form
    {
        // 1. Khai báo biến và đối tượng
        PictureBox pbEgg = new PictureBox();

        // Sử dụng System.Windows.Forms.Timer để tránh nhầm lẫn với các loại Timer khác
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();

        int xEgg = 300;   // Vị trí ngang
        int yEgg = 0;     // Vị trí dọc
        int yDelta = 3;   // Tốc độ rơi
        // int xDelta = 3; // Biến này chưa dùng đến trong bài hứng trứng rơi thẳng, có thể bỏ qua

        public Example26()
        {
            InitializeComponent();
            // Gán sự kiện Load thủ công để đảm bảo nó chạy
            this.Load += new EventHandler(Example26_Load);
        }

        // 2. Cấu hình ban đầu
        // Thêm dấu ? sau object (object?) để sửa cảnh báo Nullability nếu project của bạn bật chế độ này
        private void Example26_Load(object? sender, EventArgs e)
        {
            // Cấu hình Timer
            tmEgg.Interval = 10;
            tmEgg.Tick += new EventHandler(tmEgg_Tick);
            tmEgg.Start();

            // Cấu hình PictureBox
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;

            // Thêm vào Form
            this.Controls.Add(pbEgg);

            // Tải ảnh (Dùng đường dẫn tuyệt đối như bạn đã làm)
            try
            {
                pbEgg.Image = Image.FromFile(@"D:\LTwindows\LTWindows\Example\Images\egg.jpg");
            }
            catch
            {
                // Nếu lỗi ảnh thì dùng màu vàng đè lên
                pbEgg.BackColor = Color.Gold;
            }
        }

        // 3. Xử lý rơi và va chạm
        void tmEgg_Tick(object? sender, EventArgs e)
        {
            // Trứng rơi xuống
            yEgg += yDelta;

            // Kiểm tra va chạm đáy
            if (yEgg > this.ClientSize.Height - pbEgg.Height || yEgg <= 0)
            {
                try
                {
                    pbEgg.Image = Image.FromFile(@"D:\LTwindows\LTWindows\Example\Images\egg_broken.jpg");
                }
                catch
                {
                    pbEgg.BackColor = Color.Gray;
                }

                // Dừng timer hoặc reset lại vị trí ở đây nếu muốn
                // tmEgg.Stop(); 
            }

            // Cập nhật vị trí
            pbEgg.Location = new Point(xEgg, yEgg);
        }
    }
}
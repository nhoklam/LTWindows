using System;
using System.Drawing;
using System.Windows.Forms;

namespace Example
{
    public partial class Example27 : Form
    {
        // --- PHẦN 1: KHAI BÁO BIẾN (Slide 167 + Slide 173) ---

        // Đối tượng Quả trứng (Bài 26)
        PictureBox pbEgg = new PictureBox();
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();
        int xEgg = 300;
        int yEgg = 0;
        int yDelta = 3;

        // Đối tượng Cái giỏ (Bài 27 - Slide 173)
        PictureBox pbBasket = new PictureBox();
        int xBasket = 300;
        int yBasket = 380; // Vị trí giỏ nằm dưới đáy (Slide để 500, mình chỉnh 380 cho vừa Form nhỏ)
        int xDeltaBasket = 10; // Tốc độ di chuyển của giỏ

        public Example27()
        {
            InitializeComponent();

            // Gán sự kiện Load và KeyDown thủ công
            this.Load += new EventHandler(Example27_Load);
            this.KeyDown += new KeyEventHandler(Example27_KeyDown);
        }

        // --- PHẦN 2: CẤU HÌNH BAN ĐẦU (Slide 168 + Slide 174) ---
        private void Example27_Load(object? sender, EventArgs e)
        {
            // 1. Cấu hình Timer cho trứng rơi
            tmEgg.Interval = 10;
            tmEgg.Tick += new EventHandler(tmEgg_Tick);
            tmEgg.Start();

            // 2. Cấu hình Quả trứng
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(50, 50);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.BackColor = Color.Transparent;
            this.Controls.Add(pbEgg);

            // 3. Cấu hình Cái giỏ (Slide 174)
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(80, 80);
            pbBasket.Location = new Point(xBasket, yBasket);
            pbBasket.BackColor = Color.Transparent;
            this.Controls.Add(pbBasket);

            // Tải hình ảnh (Dùng đường dẫn tuyệt đối hoặc tương đối)
            try
            {
                pbEgg.Image = Image.FromFile(@"D:\LTwindows\LTWindows\Example\Images\egg.jpg");
                pbBasket.Image = Image.FromFile(@"D:\LTwindows\LTWindows\Example\Images\basket.jpg");
            }
            catch
            {
                pbEgg.BackColor = Color.Gold;    // Màu thay thế nếu thiếu ảnh
                pbBasket.BackColor = Color.Blue; // Màu thay thế nếu thiếu ảnh
            }
        }

        // --- PHẦN 3: XỬ LÝ TRỨNG RƠI (Bài 26) ---
        void tmEgg_Tick(object? sender, EventArgs e)
        {
            yEgg += yDelta;

            // Nếu chạm đáy thì vỡ (hoặc reset để chơi tiếp)
            if (yEgg > this.ClientSize.Height - pbEgg.Height)
            {
                // Reset trứng lên trên cùng để chơi tiếp vòng lặp vô tận
                yEgg = 0;
                // Random vị trí rơi mới cho thú vị
                Random rnd = new Random();
                xEgg = rnd.Next(0, this.ClientSize.Width - pbEgg.Width);
            }

            pbEgg.Location = new Point(xEgg, yEgg);

            // (Nâng cao: Bạn có thể thêm code kiểm tra va chạm giữa Trứng và Giỏ ở đây để tính điểm)
        }

        // --- PHẦN 4: ĐIỀU KHIỂN GIỎ BẰNG PHÍM (Slide 174) ---
        private void Example27_KeyDown(object? sender, KeyEventArgs e)
        {
            // Kiểm tra phím Mũi tên Phải (Key Code 39)
            // Và kiểm tra biên phải để không chạy ra ngoài màn hình
            if (e.KeyValue == 39 && (xBasket < this.ClientSize.Width - pbBasket.Width))
            {
                xBasket += xDeltaBasket;
            }

            // Kiểm tra phím Mũi tên Trái (Key Code 37)
            // Và kiểm tra biên trái (x > 0)
            if (e.KeyValue == 37 && xBasket > 0)
            {
                xBasket -= xDeltaBasket;
            }

            // Cập nhật vị trí giỏ
            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}
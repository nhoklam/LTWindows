using System;
using System.Drawing; // <-- Cần để dùng Point và Size
using System.Windows.Forms;

namespace Example
{
    public partial class Example23 : Form
    {
        // 1. Khai báo PictureBox và tọa độ (Slide 153)
        // PictureBox này được tạo bằng code, chưa có trên giao diện
        PictureBox pb = new PictureBox();
        int x = 50; // Tôi đặt mặc định 50 cho dễ nhìn (Slide để 0)
        int y = 50;

        public Example23()
        {
            InitializeComponent();
        }

        // 2. Sự kiện chọn file ảnh (Slide 153)
        private void btFile_Click(object sender, EventArgs e)
        {
            // Thiết lập thuộc tính cho PictureBox
            pb.SizeMode = PictureBoxSizeMode.StretchImage; // Co giãn ảnh
            pb.Size = new Size(100, 100);                  // Kích thước 100x100
            pb.Location = new Point(x, y);                 // Vị trí ban đầu

            // QUAN TRỌNG: Thêm PictureBox vào danh sách điều khiển của Form thì nó mới hiện ra
            this.Controls.Add(pb);

            // Mở hộp thoại chọn ảnh
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; // Lọc file ảnh

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Gán ảnh vào PictureBox
                pb.ImageLocation = dlg.FileName;
            }
        }

        // 3. Sự kiện bấm nút Trái (Slide 154)
        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10; // Giảm tọa độ X để dịch sang trái
            pb.Location = new Point(x, y);
        }

        // 4. Sự kiện bấm nút Phải (Slide 154)
        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10; // Tăng tọa độ X để dịch sang phải
            pb.Location = new Point(x, y);
        }
    }
}
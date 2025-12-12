using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example19 : Form
    {
        public Example19()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            // 1. Chế độ hiển thị ảnh: Co giãn ảnh cho vừa khung (Slide 129)
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            // 2. Khởi tạo hộp thoại mở file
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";

            // Lọc chỉ hiển thị file ảnh .jpg (Slide 129)
            // Cú pháp: "Tên hiển thị|*.duoi_file"
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|All files (*.*)|*.*";

            // 3. Hiển thị hộp thoại và kiểm tra nếu người dùng chọn OK
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // 4. Gán đường dẫn file ảnh vào PictureBox
                pbImage.ImageLocation = dlg.FileName;
            }
        }
    }
}
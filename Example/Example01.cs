using System;
using System.Windows.Forms;
// THÊM 2 DÒNG NÀY (Rất quan trọng, thiếu sẽ báo lỗi đỏ):
using System.IO;                 // Để dùng StreamWriter
using System.Xml.Serialization;  // Để dùng XmlSerializer


namespace Example
{
    public partial class Example01 : Form
    {
        string path = @"D:\form.xml";
        public Example01()
        {
            InitializeComponent();
        }
        public void Write(InfoWindows iw)
        {
            // Tạo đối tượng chuyển đổi sang XML
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));

            // Tạo luồng ghi file vào đường dẫn 'path'
            StreamWriter file = new StreamWriter(path);

            // Thực hiện ghi
            writer.Serialize(file, iw);

            // Đóng file lại để hoàn tất (quan trọng!)
            file.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            // 1. Tạo mới object chứa thông tin
            InfoWindows iw = new InfoWindows();

            // 2. Gán chiều rộng, cao hiện tại vào object
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;

            // 3. Gọi hàm lưu xuống ổ cứng
            Write(iw);
        }
    }
}

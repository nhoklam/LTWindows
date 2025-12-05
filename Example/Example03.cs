using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;                 // Để dùng StreamWriter, StreamReader
using System.Xml.Serialization;  // Để dùng XmlSerializer

namespace Example
{
    public partial class Example03 : Form
    {
        // Đường dẫn file lưu cấu hình (bạn có thể đổi ổ D: nếu máy không có)
        string path = @"D:\form_config.xml";
        InfoWindows iw = new InfoWindows();

        public Example03()
        {
            InitializeComponent();
        }

        // Hàm ghi dữ liệu ra file XML
        public void Write(InfoWindows iw)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
                using (StreamWriter file = new StreamWriter(path))
                {
                    writer.Serialize(file, iw);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }

        // Hàm đọc dữ liệu từ file XML
        public InfoWindows Read()
        {
            try
            {
                if (!File.Exists(path)) return null;

                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                using (StreamReader file = new StreamReader(path))
                {
                    return (InfoWindows)reader.Deserialize(file);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        // Sự kiện Form Load: Đọc file và khôi phục vị trí, kích thước
        private void Example03_Load(object sender, EventArgs e)
        {
            InfoWindows savedInfo = Read();
            if (savedInfo != null)
            {
                this.Width = savedInfo.Width;
                this.Height = savedInfo.Height;
                this.Location = savedInfo.Location; // Khôi phục vị trí
            }
        }

        // Sự kiện Form Closing: Lưu lại vị trí, kích thước hiện tại
        private void Example03_FormClosing(object sender, FormClosingEventArgs e)
        {
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            iw.Location = this.Location; // Lưu vị trí hiện tại

            Write(iw);
        }
    }
}
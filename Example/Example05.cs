using System;
using System.Windows.Forms;
using System.IO; // <-- Bắt buộc thêm dòng này để dùng StreamWriter

namespace Example
{
    public partial class Example05 : Form
    {
        public Example05()
        {
            InitializeComponent();
        }

        private void Example05_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                // Tạo đối tượng ghi file. 
                // Tham số 'true' nghĩa là ghi nối tiếp (append), không xóa dữ liệu cũ.
                StreamWriter sw = new StreamWriter(@"D:\Key_Logger.txt", true);

                // Ghi phím vừa bấm vào file
                sw.Write(e.KeyCode.ToString() + " ");

                // Đóng file để hoàn tất ghi (Quan trọng)
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message);
            }
        }
    }
}
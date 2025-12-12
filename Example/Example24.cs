using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example24 : Form
    {
        // Biến đếm thời gian (giây)
        int second = 0;

        public Example24()
        {
            InitializeComponent();
        }

        // Sự kiện nút Start: Bắt đầu đếm
        private void btStart_Click(object sender, EventArgs e)
        {
            tmStopwatch.Interval = 1000; // 1000ms = 1 giây (mỗi giây nhảy 1 lần)
            tmStopwatch.Start();         // Kích hoạt Timer
        }

        // Sự kiện nút Stop: Dừng đếm
        private void btStop_Click(object sender, EventArgs e)
        {
            tmStopwatch.Stop();          // Vô hiệu hóa Timer
        }

        // Sự kiện Tick: Chạy mỗi khi hết khoảng thời gian Interval (mỗi giây)
        private void tmStopwatch_Tick(object sender, EventArgs e)
        {
            second++; // Tăng giây lên 1

            // Hiển thị ra màn hình
            // Code gốc Slide 159 chỉ hiện số nguyên:
            lblDisplay.Text = second.ToString();

            // Mở rộng (Optional): Nếu muốn hiện dạng 00:00 (phút:giây) cho đẹp như hình Slide 158:
            // TimeSpan t = TimeSpan.FromSeconds(second);
            // lblDisplay.Text = string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
        }
    }
}
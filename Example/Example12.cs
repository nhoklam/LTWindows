using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example12 : Form
    {
        public Example12()
        {
            InitializeComponent();
        }

        // Sự kiện Form Load: Thiết lập giá trị mặc định khi chạy chương trình
        private void Example12_Load(object sender, EventArgs e)
        {
            // Chọn mục thứ 3 (index tính từ 0 nên 2 là mục thứ 3: "Quản trị kinh doanh")
            cb_Faculty.SelectedIndex = 2;
        }

        // Sự kiện khi người dùng thay đổi lựa chọn trong ComboBox
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy chỉ số (index) của mục được chọn
            int index = cb_Faculty.SelectedIndex;
            tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
        }

        // Sự kiện click nút OK
        private void btOK_Click(object sender, EventArgs e)
        {
            // Lấy nội dung chữ (Item) của mục được chọn
            string item = cb_Faculty.SelectedItem.ToString();
            tbDisplay.Text = "Bạn là sinh viên khoa : " + item;
        }
    }
}
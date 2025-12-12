using System;
using System.Collections; // <-- Bắt buộc có dòng này để dùng ArrayList (Slide 100)
using System.Windows.Forms;

namespace Example
{
    public partial class Example13 : Form
    {
        public Example13()
        {
            InitializeComponent();
        }

        // Hàm tạo dữ liệu giả lập (Slide 100)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Faculty f = new Faculty();
            f.Id = "K01";
            f.Name = "Công nghệ thông tin";
            f.Quantity = 1200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K02";
            f.Name = "Quản trị kinh doanh";
            f.Quantity = 4200;
            lst.Add(f);

            f = new Faculty();
            f.Id = "K03"; // Slide ghi K02 nhưng tôi sửa thành K03 cho hợp lý
            f.Name = "Kế toán tài chính";
            f.Quantity = 5200;
            lst.Add(f);

            return lst;
        }

        // Sự kiện Load Form (Slide 100)
        private void Example13_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            // Gán nguồn dữ liệu cho ComboBox
            cb_Faculty.DataSource = lst;

            // Chọn thuộc tính 'Name' của class Faculty để HIỂN THỊ lên màn hình
            cb_Faculty.DisplayMember = "Name";
        }

        // Sự kiện thay đổi giá trị chọn (Slide 101)
        // Lưu ý: Trong Designer tôi đã gán sự kiện SelectedIndexChanged trỏ vào hàm này cho tiện
        private void cb_Faculty_SelectedValueChanged(object sender, EventArgs e)
        {
            // Khi chọn item, ta muốn lấy 'Id' của khoa
            cb_Faculty.ValueMember = "Id";
            string id = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có mã : " + id;
        }

        // Sự kiện bấm nút OK (Slide 101)
        private void btOK_Click(object sender, EventArgs e)
        {
            // Khi bấm OK, ta lại muốn lấy 'Name' của khoa
            cb_Faculty.ValueMember = "Name";
            string name = cb_Faculty.SelectedValue.ToString();
            tbDisplay.Text = "Bạn đã chọn khoa có tên : " + name;
        }

        // Sự kiện bấm nút Clear (tự thêm cho hoàn thiện giao diện)
        private void btClear_Click(object sender, EventArgs e)
        {
            tbDisplay.Clear();
        }
    }
}
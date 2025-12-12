using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example16 : Form
    {
        // Biến đếm số thứ tự sinh viên (1, 2, 3...)
        int count = 0;

        public Example16()
        {
            InitializeComponent();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            // Tăng số thứ tự
            count++;

            // 1. Lấy thông tin Tên
            string name = tbName.Text;

            // 2. Lấy thông tin Giới tính
            string gender = "Nam";
            if (rbFemale.Checked)
            {
                gender = "Nữ";
            }

            // 3. Lấy thông tin Ngày sinh (định dạng ngắn dd/MM/yyyy)
            string dob = dtpDob.Value.ToShortDateString();

            // 4. Lấy thông tin Khoa
            string faculty = cbFaculty.SelectedItem.ToString();

            // 5. Tạo chuỗi hiển thị theo định dạng trong Slide 112
            // Sử dụng \r\n để xuống dòng và \t để thụt đầu dòng (nếu cần)
            string result = count + ". " + name + "\r\n" +
                            "   -Giới tính: " + gender + "\r\n" +
                            "   -Ngày Sinh: " + dob + "\r\n" +
                            "   -Khoa: " + faculty + "\r\n"; // Thêm dòng trống để ngăn cách

            // 6. Nối chuỗi này vào TextBox hiển thị
            tbDisplay.Text += result;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Bắt buộc phải có thư viện này để làm việc với SQL Server

namespace ADO_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Nút Đọc dữ liệu (Read) - Slide 22
        private void btRead_Click(object sender, EventArgs e)
        {
            // Tạo kết nối
            SqlConnection conn = new SqlConnection();
            // Lưu ý: Bạn cần thay 'localhost' bằng tên Server của bạn nếu khác.
            // Ví dụ: .\SQLEXPRESS hoặc DESKTOP-XXXX\SQLEXPRESS
            conn.ConnectionString = @"Data Source=localhost; Initial Catalog=sale; User Id=sa; Password=sa";

            conn.Open(); // Mở kết nối

            // Tạo câu lệnh SQL
            SqlCommand cmd = new SqlCommand("select * from customer", conn);

            // Thực thi và trả về bộ đọc dữ liệu
            SqlDataReader reader = cmd.ExecuteReader();

            // Xóa dữ liệu cũ trên lưới trước khi nạp mới (để tránh bị nhân đôi dòng)
            dgvCustomer.Rows.Clear();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    // Lấy dữ liệu theo thứ tự cột: 0 là id, 1 là name
                    dgvCustomer.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }

            conn.Close(); // Đóng kết nối
        }

        // 2. Nút Thêm (Insert) - Slide 19
        private void btNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost; Initial Catalog=sale; User Id=sa; Password=sa";

            conn.Open();

            SqlCommand cmd = new SqlCommand();
            // Thêm dữ liệu cứng: ID = 5, Name = 'Nguyen Van X'
            cmd.CommandText = "insert into Customer values(5, 'Nguyen Van X')";
            cmd.Connection = conn;

            cmd.ExecuteNonQuery(); // Thực thi lệnh Insert/Update/Delete

            conn.Close();

            // Thông báo nhỏ để biết đã chạy xong
            MessageBox.Show("Đã thêm thành công!");
        }

        // 3. Nút Xóa (Delete) - Slide 20
        private void btDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost; Initial Catalog=sale; User Id=sa; Password=sa";

            conn.Open();

            // Xóa khách hàng có ID = 2
            SqlCommand cmd = new SqlCommand("delete from Customer where id = 2", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Đã xóa thành công ID = 2!");
        }

        // 4. Nút Sửa (Edit/Update) - Slide 21
        private void btEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=localhost; Initial Catalog=sale; User Id=sa; Password=sa";

            conn.Open();

            // Sửa tên khách hàng có ID = 5 thành 'Nguyen Van Z'
            SqlCommand cmd = new SqlCommand("update customer set Name= 'Nguyen Van Z' where id = 5", conn);

            cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Đã sửa thành công ID = 5!");
        }

        // 5. Nút Thoát
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
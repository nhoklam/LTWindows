using System;
using System.Collections; // <-- Cần thêm dòng này để dùng ArrayList (Slide 123)
using System.Windows.Forms;

namespace Example
{
    public partial class Example18 : Form
    {
        public Example18()
        {
            InitializeComponent();
        }

        // Hàm tạo dữ liệu giả lập (Slide 123)
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ cha pi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            return lst;
        }

        // Sự kiện Load Form (Slide 124)
        private void Example18_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            // Gán nguồn dữ liệu là danh sách đối tượng Song
            lbSong.DataSource = lst;

            // Chỉ hiển thị tên bài hát lên ListBox
            lbSong.DisplayMember = "Name";
        }

        // Sự kiện Click nút > (Slide 124)
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Ép kiểu mục đang chọn về object Song
            Song song = (Song)lbSong.SelectedItem;

            // Lấy thông tin chi tiết
            string id = song.Id.ToString();
            string name = song.Name;
            string author = song.Author;

            // Hiển thị chuỗi tổng hợp sang ListBox bên phải
            lbFavorite.Items.Add(id + " - " + name + " - " + author);
        }
    }
}
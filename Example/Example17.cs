using System;
using System.Windows.Forms;

namespace Example
{
    public partial class Example17 : Form
    {
        public Example17()
        {
            InitializeComponent();
        }

        // 1. Chuyển 1 bài hát từ Trái sang Phải (Nút >)
        private void btSelect_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có bài nào đang được chọn không
            if (lbSong.SelectedItem != null)
            {
                // Thêm vào danh sách phải
                lbFavorite.Items.Add(lbSong.SelectedItem);
                // Xóa khỏi danh sách trái (Slide 118)
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        // 2. Chuyển 1 bài hát từ Phải sang Trái (Nút <)
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                lbSong.Items.Add(lbFavorite.SelectedItem);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // 3. Chuyển TẤT CẢ từ Trái sang Phải (Nút >>)
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            // Duyệt ngược từ cuối danh sách lên đầu (Slide 119 gợi ý dùng vòng for)
            // Duyệt ngược giúp tránh lỗi thay đổi index khi xóa phần tử
            for (int i = lbSong.Items.Count - 1; i >= 0; i--)
            {
                lbFavorite.Items.Add(lbSong.Items[i]);
                lbSong.Items.RemoveAt(i);
            }
        }

        // 4. Chuyển TẤT CẢ từ Phải sang Trái (Nút <<)
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbFavorite.Items.Count - 1; i >= 0; i--)
            {
                lbSong.Items.Add(lbFavorite.Items[i]);
                lbFavorite.Items.RemoveAt(i);
            }
        }

        // 5. Sự kiện Double Click bên Trái (Slide 119)
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Lấy vị trí index từ tọa độ chuột (để tránh click vào vùng trắng cũng chạy)
            int index = this.lbSong.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(index);
            }
        }

        // 6. Sự kiện Double Click bên Phải
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbFavorite.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbFavorite.Items[index].ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(index);
            }
        }
    }
}
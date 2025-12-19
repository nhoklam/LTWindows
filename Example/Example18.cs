using System;
using System.Collections;
using System.Windows.Forms;

namespace Example
{
    public partial class Example18 : Form
    {
        public Example18()
        {
            InitializeComponent();
        }

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

        private void Example18_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            lbSong.DataSource = lst;

            lbSong.DisplayMember = "Name";
        }

        private void btSelect_Click(object sender, EventArgs e)
        {
            Song song = (Song)lbSong.SelectedItem;

            string id = song.Id.ToString();
            string name = song.Name;
            string author = song.Author;

            lbFavorite.Items.Add(id + " - " + name + " - " + author);
        }
    }
}
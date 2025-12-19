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

        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                lbFavorite.Items.Add(lbSong.SelectedItem);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                lbSong.Items.Add(lbFavorite.SelectedItem);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbSong.Items.Count - 1; i >= 0; i--)
            {
                lbFavorite.Items.Add(lbSong.Items[i]);
                lbSong.Items.RemoveAt(i);
            }
        }

        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbFavorite.Items.Count - 1; i >= 0; i--)
            {
                lbSong.Items.Add(lbFavorite.Items[i]);
                lbFavorite.Items.RemoveAt(i);
            }
        }

        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbSong.IndexFromPoint(e.Location);

            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string song = lbSong.Items[index].ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(index);
            }
        }

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
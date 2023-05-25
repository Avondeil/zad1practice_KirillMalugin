using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Zadanie3
{
    public partial class Form1 : Form
    {
        private Playlist playlist;
        public Form1()
        {
            InitializeComponent();
            playlist = new Playlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            playlist.BackSong();
            UpdateCurrentSongDisplay();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string author = textBox1.Text;
            string title = textBox2.Text;
            string filename = "";
            Song song = new Song(author, title, filename);
            playlist.AddSong(song);
            listBox1.Items.Add(song);

            MessageBox.Show("Песня добавлена в плейлист");
        }

        private void UpdateCurrentSongDisplay()
        {
            Song currentSong = playlist.CurrentSong();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string itemText = listBox1.Items[i].ToString();
                if (itemText == $"{currentSong.Title} от {currentSong.Author}")
                {
                    listBox1.SetSelected(i, true);
                    return;
                }
            }
            button4.Enabled = playlist.list.Count > 1;
            button3.Enabled = playlist.list.Count > 1;

        }


    
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < playlist.list.Count)
            {
                playlist.currentIndex = selectedIndex;
                UpdateCurrentSongDisplay();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            playlist.NextSong();
            UpdateCurrentSongDisplay();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            playlist.ClearPlaylist();
            listBox1.Items.Clear();
            MessageBox.Show("Плейлист успешно очищен!", "Сообщение");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playlist.currentIndex = 0;
            UpdateCurrentSongDisplay();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             try
            {
                int selectedIndex = listBox1.SelectedIndex;
                if (selectedIndex >= 0 && selectedIndex < playlist.list.Count)
                {
                    playlist.list.RemoveAt(selectedIndex);
                    listBox1.Items.RemoveAt(selectedIndex);
                    UpdateCurrentSongDisplay();
                }
            }   
                catch
                {
                MessageBox.Show("Песня удалена из плейлиста");
                }
        }
    }
}

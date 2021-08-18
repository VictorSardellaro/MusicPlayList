using MusicPlayList.Repositories;
using MusicPlayList.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayList
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (rb_Add.Checked)
            {
                //DbHandler.CreateAuthor();                

                string playListTitle = tb_PlaylistTitle.Text;
                string author = tb_Singer.Text;
                string nSong = tb_NSong.Text;
                string genre = tb_Genre.Text;
                DateTime duration = DateTime.Parse(mtb_DSong.Text);

                AuthorRepository.CreateAuthor(author);
                MusicRepository.CreateMusic(nSong , genre, duration);




                //try catch

                if (Validation.DataCheck(playListTitle, author, nSong, genre))
                {
                    

                    var listViewItem = HandleView.AddListView(playListTitle, author, nSong, genre, (duration.ToString()));
                    lv_Mlist.Items.Add(listViewItem);

                }
                else
                {
                    MessageBox.Show("Some of the fields are empty, please fill in all fields correctly", "Error:");
                }

            }

            else if (rb_Update.Checked)
            {
                //DbHandler.UpdateAuthor();
            }

            else
            {
                MessageBox.Show("Select at least one option, Add or Update", "Error:");
            }


        }


    }
}

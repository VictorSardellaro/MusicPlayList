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

                string playListTitle = tb_PlaylistTitle.Text;
                int authorId = 2;
                //int authorId = int.Parse(tb_Singer.Text);
                string nSong = tb_NSong.Text;
                int genreId = 2;
                //int genreId = int.Parse(tb_Genre.Text);
                DateTime duration = DateTime.Parse(mtb_DSong.Text);

                MusicRepository.CreateMusic(nSong, duration, genreId, authorId);


                if (Validation.DataCheck(playListTitle, authorId.ToString(), nSong, genreId.ToString()))
                {

                    var listViewItem = HandleView.AddListView(playListTitle, authorId.ToString(), nSong, genreId.ToString(), (duration.ToString()));
                    lv_Mlist.Items.Add(listViewItem);

                }
                else
                {
                    MessageBox.Show("Some of the fields are empty, please fill in all fields correctly", "Error:");
                }

            }

            else if (rb_Update.Checked)
            {
                //update
            }

            else
            {
                MessageBox.Show("Select at least one option, Add or Update", "Error:");
            }


        }
        
        private void cb_Author_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {
                using (MusicPlaylistEntities db = new MusicPlaylistEntities())
                {
                    
                    cb_Author.DataSource = db.Authors.ToList();
                    cb_Author.DisplayMember = "AuthorName";
                    cb_Author.ValueMember = "AuthorId";
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cb_Genre_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                using (MusicPlaylistEntities db = new MusicPlaylistEntities())
                {

                    cb_Author.DataSource = db.Genres.ToList();
                    cb_Author.DisplayMember = "GenreName";
                    cb_Author.ValueMember = "GenreId";


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
    }




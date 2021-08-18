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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            //DbHandler.CreateAuthor();
            //DbHandler.UpdateAuthor();
            DbHandler.DeleteAuthor();
            


            string playListTitle = tb_PlaylistTitle.Text;
            string singer = tb_Singer.Text;
            string nSong = tb_NSong.Text;
            string genre = tb_Genre.Text;
            string duration = mtb_DSong.Text;


            //try para capturar o erro retornado do banco

            if (Validation.DataCheck(playListTitle, singer, nSong, genre))
            {
                
                var listViewItem = HandleView.AddListView(playListTitle, singer, nSong, genre, duration);
                lv_Mlist.Items.Add(listViewItem);

            }
            else
            {
                MessageBox.Show("Some of the fields are empty, please fill in all fields correctly", "Error:");
            }           


            
        }

        private void btn_Updt_Click(object sender, EventArgs e)
        {

        }
    }
}

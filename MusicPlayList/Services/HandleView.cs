using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayList.Services
{
    class HandleView
    {
        public static void AddListView(string tb_PlaylistTitle, string tb_Singer, string tb_NSong, string tb_Genre, string duration)
        {

            ListViewItem listViewItem = new ListViewItem(tb_PlaylistTitle);
            listViewItem.SubItems.Add(tb_PlaylistTitle);
            listViewItem.SubItems.Add(tb_Singer);
            listViewItem.SubItems.Add(tb_NSong);
            listViewItem.SubItems.Add(tb_Genre);
            listViewItem.SubItems.Add(duration);

            //items.Add(listViewItem);

        }

        public static void ClearAll()
        {

        }
    }
}

using System.Windows.Forms;

namespace MusicPlayList.Services
{
    class HandleView
    {
        public static ListViewItem AddListView(string tb_PlaylistTitle, string tb_Singer, string tb_NSong, string tb_Genre, string duration)
        {

            ListViewItem listViewItem = new ListViewItem();
            listViewItem.SubItems.Add(tb_PlaylistTitle);
            listViewItem.SubItems.Add(tb_Singer);
            listViewItem.SubItems.Add(tb_Genre);
            listViewItem.SubItems.Add(tb_NSong);            
            listViewItem.SubItems.Add(duration);

            return listViewItem;

        }

        public static void ClearAll()
        {

        }
    }
}

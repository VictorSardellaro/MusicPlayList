

namespace MusicPlayList.Services
{
    class Validation
    {
        public static bool DataCheck(string tb_PlaylistTitle, string tb_Singer, string tb_NSong, string tb_Genre)
        {

            if (!string.IsNullOrEmpty(tb_PlaylistTitle) &&
                !string.IsNullOrEmpty(tb_Singer) &&
                !string.IsNullOrEmpty(tb_NSong) &&
                !string.IsNullOrEmpty(tb_Genre))
                return true;
            else
                return false;
        }
    }
}

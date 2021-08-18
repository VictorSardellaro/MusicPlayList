using Dapper.Contrib.Extensions;


namespace MusicPlayList.Models
{    
        [Table("[Playlist]")]
        public class Playlist
        {
        public int Id { get; set; }
        public string PlaylistTitle { get; set; }        

        }    
}

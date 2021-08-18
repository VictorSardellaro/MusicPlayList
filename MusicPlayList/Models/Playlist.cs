using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayList.Models
{    
        [Table("[Playlist]")]
        public class Playlist
        {
        
        public string Title { get; set; }
        //pending MusicID and PlaylistID

        }    
}

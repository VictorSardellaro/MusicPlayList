﻿using Dapper.Contrib.Extensions;
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
        public int Id { get; set; }
        public string PlaylistTitle { get; set; }        

        }    
}

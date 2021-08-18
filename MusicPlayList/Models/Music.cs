using System;
using Dapper.Contrib.Extensions;

namespace MusicPlayList.Models
{
    [Table("[Music]")]
    public class Music
    {
        public int Id { get; set; }
        public string MusicTitle { get; set; }
        public string Genre { get; set; }
        public DateTime Duration { get; set; }

    }
}



using System;
using Dapper.Contrib.Extensions;

namespace MusicPlayList.Models
{
    [Table("[Music]")]
    public class Music
    {
        public int Id { get; set; }
        public string MusicTitle { get; set; }        
        public DateTime MusicDuration { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }

    }
}



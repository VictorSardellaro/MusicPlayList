using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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



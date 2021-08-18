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
        public string Id { get; set; }
        public string Title { get; set; }
        public DateTime Duration { get; set; }

    }
}



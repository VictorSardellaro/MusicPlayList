using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayList.Models
{
    [Table("[Genre]")]
    public class Genre
    {
        public string Id { get; set; }
        public string Name { get; set; }

    }
}



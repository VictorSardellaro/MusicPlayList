using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace MusicPlayList.Models
{
    [Table("[Author]")]
    public class Author
    {        
        public int AuthorId { get; set; }        
        public string AuthorName { get; set; }
    }
}


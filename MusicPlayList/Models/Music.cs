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
            public string Name { get; set; }
            
        }
    }



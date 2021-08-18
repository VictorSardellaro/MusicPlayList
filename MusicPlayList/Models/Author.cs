using Dapper.Contrib.Extensions;

namespace MusicPlayList.Models
{
    [Table("[Author]")]
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}


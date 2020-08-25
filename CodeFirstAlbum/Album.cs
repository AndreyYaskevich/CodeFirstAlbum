using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAlbum
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YerOfCreating { get; set; }
        public ICollection<Song> Songs { get; set; }

        public Album()
        {
            Songs = new List<Song>();
        }
    }
}

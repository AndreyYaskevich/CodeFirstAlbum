using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstAlbum
{
    class MusicContext : DbContext
    {
        public MusicContext()
            : base("DbConnection")
        { }

        DbSet<Song> Songs { get; set; }
        DbSet<Album> Albums { get; set; }

    }
}

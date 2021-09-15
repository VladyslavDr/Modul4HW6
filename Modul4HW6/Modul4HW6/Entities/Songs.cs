using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.Entities
{
    public class Songs
    {
        public virtual int SongsId { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Duration { get; set; }
        public virtual DateTime ReleasedData { get; set; }
        public virtual int GenresId { get; set; }
        public virtual Genres Genres { get; set; }
        public virtual List<ArtistsSongs> Artists { get; set; } = new List<ArtistsSongs>();
    }
}

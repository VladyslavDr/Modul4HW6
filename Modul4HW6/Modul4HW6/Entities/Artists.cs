using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.Entities
{
    public class Artists
    {
        public virtual int ArtistsId { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime DateOfBirth { get; set; }
        public virtual string Phone { get; set; }
        public virtual string Email { get; set; }
        public virtual string InstagramUrl { get; set; }
        public virtual List<ArtistsSongs> Songs { get; set; } = new List<ArtistsSongs>();
    }
}

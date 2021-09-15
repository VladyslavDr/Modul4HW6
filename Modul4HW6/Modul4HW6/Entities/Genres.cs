using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW6.Entities
{
    public class Genres
    {
        public virtual int GenresId { get; set; }
        public virtual string Title { get; set; }
        public virtual List<Songs> Songs { get; set; } = new List<Songs>();
    }
}

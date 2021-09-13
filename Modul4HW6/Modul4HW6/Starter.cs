using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;
using Modul4HW6.DataAccess;
using Modul4HW6.Entities;
using Modul4HW6;

namespace Modul4HW6
{
    public class Starter
    {
        private AppConfigService _appConfig = new AppConfigService();

        public void Run()
        {
            var dbContext = new DbContextOptionsBuilder<ApplicationContext>();
            dbContext.UseSqlServer(_appConfig.ConnectionString);
            dbContext.UseLazyLoadingProxies();

            using (var db = new ApplicationContext(dbContext.Options))
            {
                /*
                // task1
                var query1 = db.ArtistsSongs
               .Include(x => x.Songs)
                    .ThenInclude(x => x.Genres)
               .Include(x => x.Artists)
               .Select(x => new
               {
                   SongName = x.Songs.Title,
                   ArtistName = x.Artists.Name,
                   Genre = x.Songs.Genres.Title
               });
                */

                /*
                // task2
                var query2 = db.Songs
                    .Include(x => x.Genres)
                    .GroupBy(x => x.Genres.Title)
                    .Select(x => new
                    {
                        Genres = x.Key,
                        Count = x.Count()
                    })
                    .ToList();
                */
                var artist = db.Artists
                    .OrderByDescending(x => x.DateOfBirth)
                    .First();

                var song = db.Songs
                    .Where(x => x.ReleasedData < artist.DateOfBirth);

                foreach (var item in song)
                {
                    Console.WriteLine($"{item.Title}");
                }

                /*
                // task2
                foreach (var item in query2)
                {
                    Console.WriteLine($"{item.Genres}: {item.Count}");
                }
                */

                /*
                // task1
                foreach (var item in query1)
                {
                    Console.WriteLine($"{item.ArtistName}, {item.Genre}, {item.SongName}");
                }
                */
            }

            Console.WriteLine("End");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Modul4HW6.Entities;
using Modul4HW6.DataAccess.Configurations;

namespace Modul4HW6.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<Artists> Employers { get; set; }
        public DbSet<ArtistsSongs> EmployeeProjects { get; set; }
        public DbSet<Songs> Offices { get; set; }
        public DbSet<Genres> Titles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistsConfigurations());
            modelBuilder.ApplyConfiguration(new ArtistsSongsConfigurations());
            modelBuilder.ApplyConfiguration(new SongsConfigurations());
            modelBuilder.ApplyConfiguration(new GenresConfigurations());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer("Server=localhost;Database=HW6DB;Integrated Security=SSPI");
        }
    }
}

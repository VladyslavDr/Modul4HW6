using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modul4HW6.Entities;

namespace Modul4HW6.DataAccess.Configurations
{
    public class GenresConfigurations : IEntityTypeConfiguration<Genres>
    {
        public void Configure(EntityTypeBuilder<Genres> builder)
        {
            builder.ToTable("Genres").HasKey(p => p.GenresId);
            builder.Property(p => p.GenresId).HasColumnName("Id").IsRequired();
            builder.Property(p => p.Title).HasColumnName("Title").HasMaxLength(50).IsRequired();
            builder.HasData(
                new Genres()
                {
                    GenresId = 1,
                    Title = "Rok"
                },
                new Genres()
                {
                    GenresId = 2,
                    Title = "Rap"
                },
                new Genres()
                {
                    GenresId = 3,
                    Title = "Pop"
                },
                new Genres()
                {
                    GenresId = 4,
                    Title = "Classic"
                },
                new Genres()
                {
                    GenresId = 5,
                    Title = "jas"
                });
        }
    }
}

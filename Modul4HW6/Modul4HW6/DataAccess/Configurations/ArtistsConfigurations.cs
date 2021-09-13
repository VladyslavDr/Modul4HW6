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
    public class ArtistsConfigurations : IEntityTypeConfiguration<Artists>
    {
        public void Configure(EntityTypeBuilder<Artists> builder)
        {
            builder.ToTable("Artists").HasKey(p => p.ArtistsId);
            builder.Property(p => p.ArtistsId).HasColumnName("Id");
            builder.Property(p => p.Name).HasColumnName("Name").IsRequired();
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
            builder.Property(p => p.Phone).HasColumnName("Phone").HasMaxLength(20);
            builder.Property(p => p.Email).HasColumnName("Email").HasMaxLength(50);
            builder.Property(p => p.InstagramUrl).HasColumnName("InstagramUrl").HasMaxLength(255);
            builder.HasData(
                new Artists()
                {
                    ArtistsId = 1,
                    Name = "Oleg",
                    DateOfBirth = new DateTime(2007, 7, 7, 0, 0, 0),
                    Email = "OlegPisnyar228@mail.ru",
                    Phone = "+380993255632",
                    InstagramUrl = "https://www.instagram.com/OlegPisnyar"
                },
                new Artists()
                {
                    ArtistsId = 2,
                    Name = "Boria",
                    DateOfBirth = new DateTime(1961, 1, 28, 0, 0, 0),
                    Email = "BoriaNagibator@mail.ru",
                    Phone = "+380999865002",
                    InstagramUrl = "https://www.instagram.com/BoriaNagibator1961"
                },
                new Artists()
                {
                    ArtistsId = 3,
                    Name = "Olexa",
                    DateOfBirth = new DateTime(1999, 2, 12, 0, 0, 0),
                    Email = "OlexandraLampovna1991@mail.ru",
                    Phone = "+380667899945",
                    InstagramUrl = "https://www.instagram.com/Lampovna11"
                },
                new Artists()
                {
                    ArtistsId = 4,
                    Name = "Den",
                    DateOfBirth = new DateTime(1988, 6, 3, 0, 0, 0),
                    Email = "Din_Don@mail.ru",
                    Phone = "+380665593712",
                    InstagramUrl = "https://www.instagram.com/DonDon1988ProMaxMegaUltra"
                },
                new Artists()
                {
                    ArtistsId = 5,
                    Name = "Mary",
                    DateOfBirth = new DateTime(1998, 9, 17, 0, 0, 0),
                    Email = "MaryMore@mail.ru",
                    Phone = "+380986347196",
                    InstagramUrl = "https://www.instagram.com/InstaProKa4kaMary"
                });
        }
    }
}

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
    public class SongsConfigurations : IEntityTypeConfiguration<Songs>
    {
        public void Configure(EntityTypeBuilder<Songs> builder)
        {
            builder.ToTable("Songs").HasKey(p => p.SongsId);
            builder.Property(p => p.SongsId).HasColumnName("Id").IsRequired();
            builder.Property(p => p.Title).HasColumnName("Title").HasMaxLength(50).IsRequired();
            builder.Property(p => p.Duration).HasColumnName("Duration").IsRequired();
            builder.Property(p => p.ReleasedData).HasColumnName("ReleasedData").IsRequired();
            builder.HasOne(d => d.Genres)
                .WithMany(p => p.Songs)
                .HasForeignKey(d => d.GenresId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
                new Songs()
                {
                    SongsId = 1,
                    Duration = 5.1M,
                    ReleasedData = new DateTime(2005, 5, 10, 0, 0, 0),
                    Title = "Oduvan4ik",
                    GenresId = 1
                },
                new Songs()
                {
                    SongsId = 2,
                    Duration = 4.055M,
                    ReleasedData = new DateTime(2020, 2, 3, 0, 0, 0),
                    Title = "Mu-mu-mu",
                    GenresId = 2
                },
                new Songs()
                {
                    SongsId = 3,
                    Duration = 2.17M,
                    ReleasedData = new DateTime(2019, 8, 5, 0, 0, 0),
                    Title = "NigaGan",
                    GenresId = 3
                },
                new Songs()
                {
                    SongsId = 4,
                    Duration = 5.02M,
                    ReleasedData = new DateTime(2018, 11, 9, 0, 0, 0),
                    Title = "PoleRodimoeMoe",
                    GenresId = 4
                },
                new Songs()
                {
                    SongsId = 5,
                    Duration = 2.16M,
                    ReleasedData = new DateTime(2001, 6, 3, 0, 0, 0),
                    Title = "2GusiaUbabusi",
                    GenresId = 5
                });
        }
    }
}

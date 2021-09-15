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
    public class ArtistsSongsConfigurations : IEntityTypeConfiguration<ArtistsSongs>
    {
        public void Configure(EntityTypeBuilder<ArtistsSongs> builder)
        {
            builder.HasOne(d => d.Artists)
                .WithMany(p => p.Songs)
                .HasForeignKey(d => d.ArtistsId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            builder.HasOne(d => d.Songs)
                .WithMany(p => p.Artists)
                .HasForeignKey(d => d.SongsId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
            builder.HasData(
                new ArtistsSongs()
                {
                    ArtistsSongsId = 1,
                    ArtistsId = 1,
                    SongsId = 1
                },
                new ArtistsSongs()
                {
                    ArtistsSongsId = 2,
                    ArtistsId = 2,
                    SongsId = 2
                },
                new ArtistsSongs()
                {
                    ArtistsSongsId = 3,
                    ArtistsId = 2,
                    SongsId = 3
                },
                new ArtistsSongs()
                {
                    ArtistsSongsId = 4,
                    ArtistsId = 2,
                    SongsId = 4
                },
                new ArtistsSongs()
                {
                    ArtistsSongsId = 5,
                    ArtistsId = 2,
                    SongsId = 1
                },
                new ArtistsSongs()
                {
                    ArtistsSongsId = 6,
                    ArtistsId = 4,
                    SongsId = 4
                },
                new ArtistsSongs()
                {
                    ArtistsSongsId = 7,
                    ArtistsId = 5,
                    SongsId = 4
                },
                new ArtistsSongs()
                {
                    ArtistsSongsId = 8,
                    ArtistsId = 5,
                    SongsId = 5
                });
        }
    }
}

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
        }
    }
}

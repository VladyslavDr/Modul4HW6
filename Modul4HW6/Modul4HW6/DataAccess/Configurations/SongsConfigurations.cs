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
        }
    }
}

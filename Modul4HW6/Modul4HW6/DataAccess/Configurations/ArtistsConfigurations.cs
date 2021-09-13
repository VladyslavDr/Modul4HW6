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
        }
    }
}

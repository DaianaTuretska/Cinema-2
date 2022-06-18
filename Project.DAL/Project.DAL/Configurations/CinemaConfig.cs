using Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Configurations
{
    public class CinemaConfig : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.name_cinema)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.city)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.address)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(e => e.is_active)
                  .IsRequired();

        }
    }
}

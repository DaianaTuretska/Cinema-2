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
    public class PlaceConfig : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.row)
                   .IsRequired();

            builder.Property(e => e.place)
                 .IsRequired();

            builder.Property(e => e.status)
                  .HasMaxLength(10)
                  .IsRequired();

            builder.HasOne(e => e.Cinema)
               .WithMany(d => d.Places)
               .HasForeignKey(k => k.cinema_id);

            builder.Property(e => e.cost)
                 .IsRequired();

        }
    }
}

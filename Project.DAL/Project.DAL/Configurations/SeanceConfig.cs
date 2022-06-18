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
    public class SeanceConfig : IEntityTypeConfiguration<Seance>
    {
        public void Configure(EntityTypeBuilder<Seance> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Movie)
                .WithMany(d => d.Seances)
                .HasForeignKey(e => e.movie_id);

            builder.HasOne(e => e.Cinema)
                .WithMany(d => d.Seances)
                .HasForeignKey(e => e.cinema_id);


            builder.Property(e => e.date)
               .IsRequired();

            builder.Property(e => e.time)
                .IsRequired();
        }
    }
}

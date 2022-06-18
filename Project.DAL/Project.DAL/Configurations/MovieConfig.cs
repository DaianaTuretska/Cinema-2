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
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.title)
                  .HasMaxLength(100)
                  .IsRequired();


            builder.Property(e => e.age_bracket)
                   .IsRequired();

            builder.Property(e => e.duraction)
                 .HasMaxLength(10)
                 .IsRequired();

            builder.Property(e => e.description)
                 .HasMaxLength(200)
                 .IsRequired();

            builder.Property(e => e.start_rental_date)
                   .IsRequired();

            builder.Property(e => e.end_rental_date)
                    .IsRequired();



        }
    }
}

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
    public class MovieGenreConfig : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Movie)
                .WithMany(d => d.MovieGenres)
                .HasForeignKey(e => e.movie_id);

            builder.HasOne(e => e.Genre)
              .WithMany(d => d.MovieGenres)
              .HasForeignKey(e => e.genre_id);

        }
    }
}

using Project.DAL.Entities;
using Project.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Seeding
{
    public class MovieGenreSeeding : ISeeder<MovieGenre>
    {
        private static readonly List<MovieGenre> tourCategories = new List<MovieGenre>()
        {
            new MovieGenre()
            {
                Id = 1,
                movie_id = 1,
                genre_id = 2,
            }
        };

        public void Seed(EntityTypeBuilder<MovieGenre> builder) => builder.HasData(tourCategories);
    }
}

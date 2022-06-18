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
    public class MovieSeeding : ISeeder<Movie>
    {
        private static readonly List<Movie> sells = new List<Movie>()
        {
            new Movie()
            {
                Id = 1,
                title="Matrix",
                age_bracket =18,

                duraction="Lana Wachowski, Lilly Wachowski",
                description = "The world of the Matrix is ​​an illusion that exists only in the endless dream of doomed humanity. The cold world of the future, in which people are just batteries in computer systems.",
                start_rental_date = new DateTime(2021,6 ,11,11,0,0),
                end_rental_date = new DateTime(2021,6 ,11,11,0,0),
               
            }
        };

        public void Seed(EntityTypeBuilder<Movie> builder) => builder.HasData(sells);
    }
}

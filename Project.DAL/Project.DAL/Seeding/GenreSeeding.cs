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
    public class GenreSeeding : ISeeder<Genre>
    {
        private static readonly List<Genre> tours = new List<Genre>()
        {
            new Genre()
            {
                Id = 1,
                name = "Romantic",       
            }
        };

        public void Seed(EntityTypeBuilder<Genre> builder) => builder.HasData(tours);
    }
}

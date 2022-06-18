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
    public class CinemaSeeding : ISeeder<Cinema>
    {
        private static readonly List<Cinema> countries = new List<Cinema>()
        {
            new Cinema()
            {
                Id = 1,
                name_cinema = "SmartCinena",
                city = "Chernivtsi",
                address = "Golovna 112",
                is_active = true,
                

            }
        };

        public void Seed(EntityTypeBuilder<Cinema> builder) => builder.HasData(countries);
    }
}

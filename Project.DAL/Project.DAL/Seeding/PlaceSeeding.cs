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
    public class PlaceSeeding : ISeeder<Place>
    {
        private static readonly List<Place> nutritions = new List<Place>()
        {
            new Place()
            {
                Id = 1,
                row = 1,
                place =2,
                status = "active",
                cinema_id = 1,
                cost = 120,            }
        };

        public void Seed(EntityTypeBuilder<Place> builder) => builder.HasData(nutritions);
    }
}

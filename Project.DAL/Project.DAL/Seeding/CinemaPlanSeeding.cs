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
    public class CinemaPlanSeeding : ISeeder<CinemaPlan>
    {
        private static readonly List<CinemaPlan> hotels = new List<CinemaPlan>()
        {
            new CinemaPlan()
            {
                Id = 1,
                cinema_id = 1,
                row_number = 1,
                place_number = 1,
            }
        };

        public void Seed(EntityTypeBuilder<CinemaPlan> builder) => builder.HasData(hotels);
    }
}
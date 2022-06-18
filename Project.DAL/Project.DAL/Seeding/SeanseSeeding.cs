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
    public class SeanceSeeding : ISeeder<Seance>
    {
        private static readonly List<Seance> discounts = new List<Seance>()
        {
            new Seance()
            {
                Id = 1,
                cinema_id = 1 ,
                movie_id = 1,
                date = new DateTime(2021,6 ,11,11,0,0),
                time = new DateTime(2021,6 ,11,11,0,0),
            }
        };

        public void Seed(EntityTypeBuilder<Seance> builder) => builder.HasData(discounts);
    }
}

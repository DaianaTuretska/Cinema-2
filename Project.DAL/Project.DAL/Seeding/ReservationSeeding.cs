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
    public class ReservationSeeding : ISeeder<Reservation>
    {
        private static readonly List<Reservation> discounts = new List<Reservation>()
        {
            new Reservation()
            {
                Id = 1,
                customer_id = "1",
                seance_id = 1,
                place_id =1 ,
                reserv_date = new DateTime(2021,6 ,11,10,0,0),
            }
        };

        public void Seed(EntityTypeBuilder<Reservation> builder) => builder.HasData(discounts);
    }
}

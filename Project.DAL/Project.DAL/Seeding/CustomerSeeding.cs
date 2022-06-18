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
    public class CustomerSeeding : ISeeder<Customer>
    {
        private static readonly List<Customer> clients = new List<Customer>()
        {
            new Customer()
            {
                Id = "1",
                first_name = "aLEX",
                last_name = "a",
                age = "18",
                RefreshToken = "token",
                RefreshTokenExpiryTime = new DateTime(2022, 06, 12)
            },
        };

        public void Seed(EntityTypeBuilder<Customer> builder) => builder.HasData(clients);
    }
}


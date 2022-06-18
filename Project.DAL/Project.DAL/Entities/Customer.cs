using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Customer: IdentityUser
    {

        public string first_name { get; set; }
        public string last_name { get; set; }
        public string age { get; set; }
      
        public Reservation Reservation { get; set; }
        public List<Reservation> Reservations { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

    }
}

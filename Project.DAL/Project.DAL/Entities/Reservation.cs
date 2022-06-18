using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
     public class Reservation : Entity
    {
       
        public string customer_id { get; set; }

        public Customer Customer { get; set; }
        public int seance_id { get; set; }

        public Seance Seance { get; set; }
        public int place_id { get; set; }

        public Place Place { get; set; }
        public DateTime reserv_date { get; set; }

      
    }
}

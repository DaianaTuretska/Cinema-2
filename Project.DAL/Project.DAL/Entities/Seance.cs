using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Seance : Entity
    {

        public int cinema_id { get; set; }
        public Cinema Cinema { get; set; }
        public int movie_id { get; set; }

        public Movie Movie { get; set; }
        public DateTime date { get; set; }
        public DateTime time { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}

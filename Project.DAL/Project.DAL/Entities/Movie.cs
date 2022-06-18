using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Movie : Entity
    {

        public string title { get; set; }
        public int age_bracket { get; set; }
        public string duraction { get; set; }
        public string description { get; set; }
        public DateTime  start_rental_date { get; set; }
        public DateTime end_rental_date { get; set; }

        public List<Seance> Seances { get; set; }
        public List<MovieGenre> MovieGenres { get; set; }
    }
}

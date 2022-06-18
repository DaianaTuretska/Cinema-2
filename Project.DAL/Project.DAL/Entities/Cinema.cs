using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class Cinema : Entity
    {
        public string name_cinema { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public bool is_active { get; set; }

        public List<Seance> Seances { get; set; }

        public List<CinemaPlan> CinemaPlans { get; set; }
        public List<Place> Places { get; set; }

    }
}

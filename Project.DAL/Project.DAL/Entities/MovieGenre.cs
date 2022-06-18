using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class MovieGenre : Entity
    {

        public int movie_id { get; set; }
        public Movie Movie { get; set; }
        public Genre Genre { get; set; }
        public int genre_id { get; set; }

    }
}

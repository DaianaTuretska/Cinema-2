using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Entities
{
    public class CinemaPlan : Entity
    {

        public int cinema_id { get; set; }

        public Cinema Cinema { get; set; }
        public int row_number { get; set; }
        public int place_number { get; set; }

    }
}

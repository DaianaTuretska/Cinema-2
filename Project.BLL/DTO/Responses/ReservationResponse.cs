using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Responses
{
    public class ReservationResponse
    {

        public string customer_id { get; set; }
        public int seance_id { get; set; }

        public int place_id { get; set; }
        public DateTime reserv_date { get; set; }
    }
}

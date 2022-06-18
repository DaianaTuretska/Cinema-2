using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DTO.Responses
{
    public class PlaceResponse
    {

        public int row { get; set; }
        public int place { get; set; }
        public string status { get; set; }
        public int cinema_id { get; set; }
        public int cost { get; set; }
    }
}

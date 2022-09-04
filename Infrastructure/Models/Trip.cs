using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public class Trip
    {
        public int ID { get; set; }
        public string busId { get; set; }
        public string userEmail { get; set; }
        public int price { get; set; }
        public int tripType { get; set; }
        public List<Seat> seats { get; set; }
    }
}

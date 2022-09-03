using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
    public class ReservedTicketDto
    {
        public string userEmail { get; set; }
        public string busId { get; set; }
        public int price { get; set; }
        public List<SeatDto> tickets { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.DTOs
{
    public class TicketRequestDto
    {
        public string userEmail { get; set; }
        public string tripRoute { get; set; }
        public string[] seats { get; set; }
    }
}

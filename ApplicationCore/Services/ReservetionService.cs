using ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ReservetionService : IReservetionService
    {
        public List<FrequentReservedDto> FrequentReserved()
        {
            List<FrequentReservedDto> list = new List<FrequentReservedDto>();
            list.Add(new FrequentReservedDto() { email = "Mahmou", frequentBook = "Asw" });
            return list;
        }

        public ReservedTicketDto ReserveSeats(TicketRequestDto ticketRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}

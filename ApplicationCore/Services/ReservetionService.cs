using ApplicationCore.DTOs;
using ApplicationCore.Enums;
using ApplicationCore.Helpers;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class ReservetionService : IReservetionService
    {
        public readonly ITripRepository _tripRepository;
        public ReservetionService(ITripRepository tripRepository)
        {
            _tripRepository = tripRepository;
        }
        public List<FrequentReservedDto> FrequentReserved()
        {
            List<FrequentReservedDto> frequentList = null;
            var trips = _tripRepository.GetFrequentReserved();
            if (trips?.Count() > 0)
            {
                frequentList = new List<FrequentReservedDto>();
                foreach (var trip in trips)
                {
                    frequentList.Add(
                            new FrequentReservedDto()
                            {
                                email = trip.userEmail,
                                frequentBook = trip.tripType == ((int)TripType.Short) ? TripType.Short.ToDescriptionString() : TripType.Long.ToDescriptionString()
                            }
                        );
                }
            }
            return frequentList;
        }

        public ReservedTicketDto ReserveSeats(TicketRequestDto ticketRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}

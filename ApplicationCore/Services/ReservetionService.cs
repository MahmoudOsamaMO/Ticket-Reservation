using ApplicationCore.DTOs;
using ApplicationCore.Enums;
using ApplicationCore.Helpers;
using AutoMapper;
using Infrastructure.Interfaces;
using Infrastructure.Models;
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
        private readonly IMapper _mapper;
        public ReservetionService(ITripRepository tripRepository, IMapper mapper)
        {
            _tripRepository = tripRepository;
            _mapper = mapper;
        }
        public async Task<List<FrequentReservedDto>> FrequentReserved()
        {
            List<FrequentReservedDto> frequentList = null;
            var trips = await _tripRepository.GetFrequentReserved();
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

        public async Task<ReservedTicketDto> ReserveSeats(TicketRequestDto ticketRequestDto)
        {
            try
            {
                if (ticketRequestDto != null && ticketRequestDto.seats.Any())
                {
                    List<Seat> seats = new List<Seat>();
                    foreach (var seat in ticketRequestDto.seats)
                    {
                        seats.Add(new Seat() { name = seat });
                    }
                    var requTrip = new Trip()
                    {
                        userEmail = ticketRequestDto.userEmail,
                        tripType = ticketRequestDto.tripRoute == TripType.Short.ToDescriptionString() ? ((int)TripType.Short) : ((int)TripType.Long),
                        seats = seats,
                        busId = ticketRequestDto.tripRoute == TripType.Short.ToDescriptionString() ? "bus1" : "bus2",
                    };
                    var trip = await _tripRepository.ReserveTrip(requTrip);
                    var reservedTicketDto = _mapper.Map<ReservedTicketDto>(trip);
                    return reservedTicketDto;
                }
                return null;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}

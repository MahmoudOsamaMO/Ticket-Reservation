using ApplicationCore.DTOs;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ApplicationCore.Profiles
{
    public class TripProfile : Profile
    {
        public TripProfile()
        {
            CreateMap<Seat, SeatDto>();
            CreateMap<Trip, ReservedTicketDto>();
        }
    }
}

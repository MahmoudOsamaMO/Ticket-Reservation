using ApplicationCore.DTOs;
using ApplicationCore.Services;
using AutoMapper;
using Infrastructure.Interfaces;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace WeakCapUnitTests
{
    public class ReservetionServiceTests
    {
        private readonly Mock<IMapper> _mapper;
        private readonly Mock<ITripRepository> _tripRepository;
        List<Trip> trips = new List<Trip>();
        List<Seat> seats = new List<Seat>();

        public ReservetionServiceTests()
        {
            _tripRepository = new Mock<ITripRepository>();
            _mapper = new Mock<IMapper>();
        }

        [SetUp]
        public void Setup()
        {
            SetupTrips();
            SetupSeats();
            _tripRepository.Setup(repo => repo.GetFrequentReserved()).Returns(Task.FromResult((IEnumerable<Trip>)trips));
        }



        [Test]
        public async Task Get_frequent_tickets_success()
        {
            //Arrange
            var reservetionService = new ReservetionService(_tripRepository.Object,_mapper.Object);

            //Act
            var freqReserved =  reservetionService.FrequentReserved();

            //Assert
            Assert.IsNotNull(freqReserved);
            Assert.AreEqual(freqReserved.Result.Count(),5);
        }


        [Test]
        public async Task Get_reserve_ticket_success()
        {
            //Arrange
            var reservetionService = new ReservetionService(_tripRepository.Object, _mapper.Object);
            _tripRepository.Setup(repo => repo.ReserveTrip(It.IsAny<Trip>()))
                .Returns(Task.FromResult(trips.FirstOrDefault()));
            _mapper.Setup(m => m.Map<ReservedTicketDto>(It.IsAny<Trip>())).Returns(new ReservedTicketDto() { busId = trips.FirstOrDefault().busId });

            //Act
            var reservedTickets = reservetionService.ReserveSeats( new ApplicationCore.DTOs.TicketRequestDto() { userEmail = "mahmoud@gmail.com", seats = new string[] { "A01", "A02", "A03" } , tripRoute = "Cairo-Alexandria" });

            //Assert
            Assert.IsNotNull(reservedTickets.Result);
            Assert.AreEqual(reservedTickets.Result.busId, trips.FirstOrDefault().busId);
        }

        [Test]

        public async Task Reserve_ticket_NoCapacity()
        {
            //Arrange
            var reservetionService = new ReservetionService(_tripRepository.Object, _mapper.Object);
            _tripRepository.Setup(repo => repo.ReserveTrip(It.IsAny<Trip>()))
                .Throws(new Exception("no capacity in the bus"));
            _mapper.Setup(m => m.Map<ReservedTicketDto>(It.IsAny<Trip>())).Returns(new ReservedTicketDto() { busId = trips.FirstOrDefault().busId });

            //Act
            var reservedTickets = reservetionService.ReserveSeats(new ApplicationCore.DTOs.TicketRequestDto() { userEmail = "mahmoud@gmail.com", seats = new string[] { "A01", "A02", "A03" }, tripRoute = "Cairo-Alexandria" });

            //Assert
            
            Assert.AreEqual((reservedTickets).Exception.InnerException.Message ,"no capacity in the bus");
        }


        #region setup functions
        public void SetupTrips()
        {
            trips.Add(new Trip
            {
                ID = 1,
                busId = "bus1",
                userEmail = "mahmoud@gmail.com",
                price = 10,
                tripType = 0,
            });
            trips.Add(new Trip
            {
                ID = 2,
                busId = "bus1",
                userEmail = "mahmoud@gmail.com",
                price = 10,
                tripType = 0,
            });
            trips.Add(new Trip
            {
                ID = 3,
                busId = "bus2",
                userEmail = "mahmoud@gmail.com",
                price = 10,
                tripType = 1,
            });
            trips.Add(new Trip
            {
                ID = 4,
                busId = "bus2",
                userEmail = "Yehia@gmail.com",
                price = 10,
                tripType = 1,
            });
            trips.Add(new Trip
            {
                ID = 5,
                busId = "bus2",
                userEmail = "Yehia@gmail.com",
                price = 10,
                tripType = 1,
            });
        }

        private void SetupSeats()
        {
            seats.Add(new Seat
            {
                busId = "bus1",
                seatId = 1,
                name = "A01",
                isReserved = true,
                tripId = 1,
            });
            seats.Add(new Seat
            {
                busId = "bus1",
                seatId = 2,
                name = "A02",
                isReserved = true,
                tripId = 1,
            });
            for (int i = 3; i < 10; i++)
            {
                seats.Add(new Seat
                {
                    busId = "bus1",
                    seatId = i,
                    name = "A0" + i.ToString(),
                    isReserved = true,
                    tripId = 2,
                });
            }
            for (int i = 10; i <= 20; i++)
            {
                seats.Add(new Seat
                {
                    busId = "bus1",
                    seatId = i,
                    name = "A" + i.ToString(),
                    isReserved = false,
                    tripId = null,
                });
            }
            for (int i = 0; i <= 9; i++)
            {
                seats.Add(new Seat
                {
                    busId = "bus2",
                    seatId = i + 21,
                    name = "A0" + i.ToString(),
                    isReserved = false,
                    tripId = null,
                });
            }
            for (int i = 10; i <= 20; i++)
            {
                seats.Add(new Seat
                {
                    busId = "bus2",
                    seatId = i + 21,
                    name = "A" + i.ToString(),
                    isReserved = false,
                    tripId = null,
                });
            }
        }
        #endregion
    }
}
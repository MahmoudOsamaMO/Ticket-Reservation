using ApplicationCore.DTOs;
using ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Core.Types;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace WakeCapTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    //[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")]
    public class TicketsController : Controller
    {
        private readonly ILogger<TicketsController> _logger;
        private readonly IReservetionService _reservetionService;

        public TicketsController(ILogger<TicketsController> logger, IReservetionService reservetionService)
        {
            _logger = logger;
            _reservetionService = reservetionService;
        }
        // GET: TicketsController
        [HttpGet(Name = "GetMostFrequent")]
        public async Task<IEnumerable<FrequentReservedDto>> Get()
        {
            var freqTeips = await _reservetionService.FrequentReserved();
            _logger.LogInformation("Frequent Reserved fetched from the database");
            return freqTeips;
        }

        [HttpPost]
        public async Task<IActionResult> ReserveTicket([FromBody] TicketRequestDto ticketRequestDto)
        {
            if (ticketRequestDto == null)
            {
                _logger.LogError("ticketRequestDto object sent from client is null.");
                return BadRequest("ticketRequestDto object is null");
            }
            var ticket = await _reservetionService.ReserveSeats(ticketRequestDto);

            return Ok(ticket);
        }

    }
}

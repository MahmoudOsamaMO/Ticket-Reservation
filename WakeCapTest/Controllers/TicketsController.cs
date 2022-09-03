using ApplicationCore.DTOs;
using ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WakeCapTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
        public IEnumerable<FrequentReservedDto> Get()
        {
            return _reservetionService.FrequentReserved();
        }

    }
}

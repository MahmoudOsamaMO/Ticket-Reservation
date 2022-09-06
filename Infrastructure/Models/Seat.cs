using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Models
{
    public class Seat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int seatId { get; set; }
        public string name { get; set; }
        public int? tripId { get; set; }
        public string busId { get; set; }
        public bool? isReserved { get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }
    }
}
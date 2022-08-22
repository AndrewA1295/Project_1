using AscendingAirlinesAPI.DTO;
using System.Text.Json.Serialization;

namespace AscendingAirlinesAPI.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int FlightId { get; set; }
        public int PassengerId { get; set; }
        public string ConfirmationNumber { get; set; }

        [JsonIgnore]
        public virtual Flight Flight { get; set; }

        [JsonIgnore]
        public virtual Passenger Passenger { get; set; }
        

        //public string Name { get; set; }

        ////public string? Description { get; set; }

        //public virtual ICollection<Flight> Flights { get; set; }

        //public Booking() { }

        //public Booking(BookingDTO dto)
        //{
        //    this.Name = dto.Name;
        //}



    }
}
                                                                                                                                                                                                 
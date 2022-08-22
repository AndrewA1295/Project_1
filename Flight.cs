namespace AscendingAirlinesAPI.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public string ArrivalDateTime { get; set; }
        public string DepartureDateTime { get; set; }
        public string ArrivalAirport { get; set; }
        public string DepartureAirport { get; set; }
        public int MaxCapacity { get; set; }

        //Navigation Property
        public virtual ICollection<Booking> Bookings { get; set; }
        

    }
}

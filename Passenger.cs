namespace AscendingAirlinesAPI.Models
{
    public class Passenger
    {
        public int PassengerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }
                 
            
        //Navigation Property
        public virtual ICollection<Booking>? Bookings { get; set; }

    }
}

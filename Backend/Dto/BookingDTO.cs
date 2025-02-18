namespace Backend.Models
{
    public class BookingDTO
    {
        public Guid BookingID { get; set; }
        public Guid CustomerId { get; set; }
        public String PaymentId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public DateTime TotalPrice { get; set; }
        public int NoOfAdults { get; set; }
        public String BookingStatus { get; set; }
        public DateTime BookingDate { get; set; }
    }
}

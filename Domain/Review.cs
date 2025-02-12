namespace AnyReservationTemp.Domain
{
    public class Review : BaseDomainModel
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }  // Navigation Property
        public int ReservationId { get; set; }
    }
}

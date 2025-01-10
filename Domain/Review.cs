namespace AnyReservationTemp.Domain
{
    public class Review : BaseDomainModel
    {
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public int ReservationId { get; set; }
    }
}

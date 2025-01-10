namespace AnyReservationTemp.Domain
{
    public class RestaurantTable : BaseDomainModel
    {
        public int NumOfSeats { get; set; }
        public string? Type { get; set; }
        public int ReservedTableDetailsId { get; set; }
    }
}

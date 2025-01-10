namespace AnyReservationTemp.Domain
{
    public class ReservedTableDetail : BaseDomainModel
    {
        public int RestaurantTableId { get; set; }
        public int ReservationId { get; set; }
    }
}

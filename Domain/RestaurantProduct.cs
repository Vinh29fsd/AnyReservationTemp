namespace AnyReservationTemp.Domain
{
    public class RestaurantProduct : BaseDomainModel
    {
        public int ProductId { get; set; }
        public int RestaurantId { get; set; }
    }
}

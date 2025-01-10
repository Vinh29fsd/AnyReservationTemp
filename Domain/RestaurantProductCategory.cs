namespace AnyReservationTemp.Domain
{
    public class RestaurantProductCategory : BaseDomainModel
    {
        public int ProductCategoryId { get; set; }
        public int RestaurantId { get; set; }
    }
}

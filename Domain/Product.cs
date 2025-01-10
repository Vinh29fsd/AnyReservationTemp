namespace AnyReservationTemp.Domain
{
    public class Product : BaseDomainModel
    {
        public double Cost { get; set; }
        public int Quantity { get; set; }
        public int ProductCategoryId { get; set; }
    }
}

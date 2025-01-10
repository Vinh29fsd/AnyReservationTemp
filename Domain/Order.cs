namespace AnyReservationTemp.Domain
{
    public class Order : BaseDomainModel
    {
        public DateTime OrderDateTime { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
    }
}

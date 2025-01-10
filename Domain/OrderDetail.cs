namespace AnyReservationTemp.Domain
{
    public class OrderDetail : BaseDomainModel
    {
        public int Quantity { get; set; }
        public double TotalAmount { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
    }
}

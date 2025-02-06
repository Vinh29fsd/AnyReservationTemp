namespace AnyReservationTemp.Domain
{
    public class Order : BaseDomainModel
    {
        public double TotalAmount { get; set; }
        public int ResevationId { get; set; }
    }
}

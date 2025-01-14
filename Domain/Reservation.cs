namespace AnyReservationTemp.Domain
{
    public class Reservation : BaseDomainModel
    {
        public int NumOfCustomer { get; set; }
        public DateTime DateReserved { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int RestaurantId { get; set; }
        public int CustomerId { get; set; }
        public int TableNo { get; set; }
        public int ProgressId { get; set; }
    }
}

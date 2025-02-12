namespace AnyReservationTemp.Domain
{
    public class Member : BaseDomainModel
    {
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public string? MembershipLevel { get; set; } = "Basic"; // Default membership level

        public DateTime JoinDate { get; set; } = DateTime.UtcNow;
    }
}

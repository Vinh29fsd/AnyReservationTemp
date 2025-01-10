namespace AnyReservationTemp.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Contact { get; set; }
        public string? EmailAddress { get; set; }
    }
}

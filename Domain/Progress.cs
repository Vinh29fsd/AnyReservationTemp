namespace AnyReservationTemp.Domain
{
    public class Progress : BaseDomainModel
    {
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public int StatusId { get; set; }
    }
}

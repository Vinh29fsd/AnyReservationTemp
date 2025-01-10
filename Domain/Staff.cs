using System.Globalization;

namespace AnyReservationTemp.Domain
{
    public class Staff : BaseDomainModel
    {
        public string NRIC { get; set; }
        public int RestaurantId { get; set; }
    }
}

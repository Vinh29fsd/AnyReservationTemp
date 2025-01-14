using Microsoft.AspNetCore.Identity;

namespace AnyReservationTemp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class AnyReservationTempUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}

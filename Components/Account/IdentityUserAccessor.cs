using AnyReservationTemp.Data;
using Microsoft.AspNetCore.Identity;

namespace AnyReservationTemp.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<AnyReservationTempUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<AnyReservationTempUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}

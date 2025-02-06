using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class UserClaimSeed : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
        {
            builder.HasData(
                new IdentityUserClaim<string>
                {
                    Id = 4,
                    UserId = "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa",
                    ClaimType = "staffId",
                    ClaimValue = "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa"
                },
                new IdentityUserClaim<string>
                {
                    Id = 5,
                    UserId = "41b73075-dea9-4fba-9a4f-0331abd78f72",
                    ClaimType = "staffId",
                    ClaimValue = "41b73075-dea9-4fba-9a4f-0331abd78f72"
                });
        }
    }
}

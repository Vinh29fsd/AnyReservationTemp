using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class UserRoleSeed : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                { 
                    RoleId = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                    UserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "c23fbbe3-4c80-4e70-9874-985d9030ef94",
                    UserId = "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "c23fbbe3-4c80-4e70-9874-985d9030ef94",
                    UserId = "41b73075-dea9-4fba-9a4f-0331abd78f72"
                });
        }
    }
}

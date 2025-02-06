using AnyReservationTemp.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class UserSeed : IEntityTypeConfiguration<AnyReservationTempUser>
    {
        public void Configure(EntityTypeBuilder<AnyReservationTempUser> builder)
        {
            var hasher = new PasswordHasher<AnyReservationTempUser>();
            builder.HasData(
                new AnyReservationTempUser 
                {
                    Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "ADMIN@LOCALHOST.COM",
                    FirstName = "Admin",
                    LastName = "User",
                    UserName = "admin@localhost.com",
                    NormalizedUserName = "ADMIN@LOCALHOST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true // Set to true, otherwise you won't be able to login
                },
                new AnyReservationTempUser
                {
                    Id = "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa",
                    Email = "staff@restaurant.com",
                    NormalizedEmail = "STAFF@RESTAURANT.COM",
                    FirstName = "Staff",
                    LastName = "User",
                    UserName = "staff@restaurant.com",
                    NormalizedUserName = "STAFF@RESTAURANT.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                },
                new AnyReservationTempUser
                {
                    Id = "41b73075-dea9-4fba-9a4f-0331abd78f72",
                    Email = "staff@anyrestaurant.com",
                    NormalizedEmail = "STAFF@ANYRESTAURANT.COM",
                    FirstName = "Staff",
                    LastName = "User",
                    UserName = "staff@anyrestaurant.com",
                    NormalizedUserName = "STAFF@ANYRESTAURANT.COM",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                });
        }
    }
}

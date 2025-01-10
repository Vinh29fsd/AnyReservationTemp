using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class StaffSeed : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
            new Staff
            {
                Id = 1,
                Name = "James Roger",
                Contact = "9546 2365",
                EmailAddress = "workJames@gmail.com",
                NRIC = "T0047564I",
            }
            );
        }
    }
}

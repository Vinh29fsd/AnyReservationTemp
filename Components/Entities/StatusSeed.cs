using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class StatusSeed : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.HasData(
                new Status 
                {
                    Id = 1,
                    Description = "Approved"
                },
                new Status
                {
                    Id = 2,
                    Description = "Pending"
                },
                new Status
                {
                    Id= 3,
                    Description = "Rejected"
                }
                );
        }
    }
}

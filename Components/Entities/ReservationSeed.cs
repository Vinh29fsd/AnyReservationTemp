using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class ReservationSeed : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasData(
            new Reservation { 
            Id = 1,
            Name = "Ho Vo Vinh",
            Contact = "9661 0401",
            EmailAddress = "vovinhho@gmail.com",
            NumOfCustomer = 1,
            DateReserved = DateTime.Now,
            StartTime = DateTime.Now,
            EndTime = DateTime.Now.AddHours(3),
            },
            new Reservation
            {
                Id = 2,
                Name = "Owen Lau",
                Contact = "8858 6939",
                EmailAddress = "owenlau@gmail.com",
                NumOfCustomer = 2,
                DateReserved = DateTime.Now.AddHours(9),
                StartTime = DateTime.Now.AddHours(9),
                EndTime = DateTime.Now.AddHours(12),
            }
            );
        }
    }
}

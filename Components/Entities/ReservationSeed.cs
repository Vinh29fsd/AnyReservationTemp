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
            }    
            );
        }
    }
}

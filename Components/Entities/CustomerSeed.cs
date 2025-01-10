using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class CustomerSeed : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
            new Customer { 
            Id = 1,
            Name = "Owen Lau Jun Kai",
            Contact = "8858 6939",
            EmailAddress = "owen@gmail.com"
            },
            new Customer {
            Id = 2,
            Name = "Ho Vo Vinh",
            Contact = "9661 0401",
            EmailAddress = "vovinhho@gmail.com"
            }
            );
        }
    }
}

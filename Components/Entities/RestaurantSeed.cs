using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class RestaurantSeed : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasData(
            new Restaurant { 
                Id = 1,
                Name = "BreadBoard",
                Contact = "+65 6780 4191",
                EmailAddress = "studentservices@tp.edu.sg",
                Location = "21 Tampines Ave 4"
            },
            new Restaurant
            {
                Id = 2,
                Name = "Brewing Grounds",
                Contact = "+65 6780 4191",
                EmailAddress = "studentservices@tp.edu.sg",
                Location = "21 Tampines Ave 4"
            },
            new Restaurant
            {
                Id = 3,
                Name = "Wolfgang Puck",
                Contact = "+65 6780 4191",
                EmailAddress = "studentservices@tp.edu.sg",
                Location = "21 Tampines Ave 4"
            },
            new Restaurant
            {
                Id = 4,
                Name = "ShortCircuit",
                Contact = "+65 6780 4191",
                EmailAddress = "studentservices@tp.edu.sg",
                Location = "21 Tampines Ave 4"
            },
            new Restaurant
            {
                Id = 5,
                Name = "The Bistro Bar",
                Contact = "+65 6780 4191",
                EmailAddress = "studentservices@tp.edu.sg",
                Location = "21 Tampines Ave 4"
            }
            );
        }
    }
}

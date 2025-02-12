using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class ReviewSeed : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
            new Review
            {
                Id = 10,
                RestaurantId = 1,
                Name = "Owen",
                Contact = "+65 88586939",
                EmailAddress = "owenlau@gmail.com",
                Rating = 4,
                Comment = "Good service!",
            },
            new Review
            {
                Id = 40,
                RestaurantId = 1,
                Name = "Owen",
                Contact = "+65 88586939",
                EmailAddress = "owenlau@gmail.com",
                Rating = 5,
                Comment = "Good food too!",
            },
            new Review
            {
                Id = 30,
                RestaurantId =2,
                Name = "tp student",
                Contact = "+65 72642847",
                EmailAddress = "tpstudent@gmail.com",
                Rating = 2,
                Comment = "bad service",
            }
            );
        }
    }
}

using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class RestaurantProductSeed : IEntityTypeConfiguration<RestaurantProduct>
    {
        public void Configure(EntityTypeBuilder<RestaurantProduct> builder)
        {
            builder.HasData(
                new RestaurantProduct
                {
                    Id = 1,
                    RestaurantId = 1,
                    ProductId = 3,
                },
                new RestaurantProduct
                {
                    Id = 2,
                    RestaurantId = 6,
                    ProductId = 20,
                },
                new RestaurantProduct
                {
                    Id = 4,
                    RestaurantId = 5,
                    ProductId = 19,
                },
                new RestaurantProduct
                {
                    Id = 5,
                    RestaurantId = 2,
                    ProductId = 18,
                },
                new RestaurantProduct
                {
                    Id = 6,
                    RestaurantId = 5,
                    ProductId = 17,
                },
                new RestaurantProduct
                {
                    Id = 7,
                    RestaurantId = 3,
                    ProductId = 16,
                },
                new RestaurantProduct
                {
                    Id = 8,
                    RestaurantId = 3,
                    ProductId = 15,
                },
                new RestaurantProduct
                {
                    Id = 10,
                    RestaurantId = 3,
                    ProductId = 14,
                },
                new RestaurantProduct
                {
                    Id = 11,
                    RestaurantId = 4,
                    ProductId = 13,
                },
                new RestaurantProduct
                {
                    Id = 12,
                    RestaurantId = 4,
                    ProductId = 12,
                },
                new RestaurantProduct
                {
                    Id = 13,
                    RestaurantId = 2,
                    ProductId = 11,
                },
                new RestaurantProduct
                {
                    Id = 14,
                    RestaurantId = 2,
                    ProductId = 10,
                },
                new RestaurantProduct
                {
                    Id = 15,
                    RestaurantId = 5,
                    ProductId = 9,
                },
                new RestaurantProduct
                {
                    Id = 16,
                    RestaurantId = 5,
                    ProductId = 8,
                },
                new RestaurantProduct
                {
                    Id = 17,
                    RestaurantId = 1,
                    ProductId = 7,
                },
                new RestaurantProduct
                {
                    Id = 18,
                    RestaurantId = 1,
                    ProductId = 6,
                },
                new RestaurantProduct
                {
                    Id = 19,
                    RestaurantId = 5,
                    ProductId = 5,
                },
                new RestaurantProduct
                {
                    Id = 20,
                    RestaurantId = 5,
                    ProductId = 4,
                },
                new RestaurantProduct
                {
                    Id = 21,
                    RestaurantId = 3,
                    ProductId = 2,
                },
                new RestaurantProduct
                {
                    Id = 22,
                    RestaurantId = 1,
                    ProductId = 1,
                });
        }
    }
}

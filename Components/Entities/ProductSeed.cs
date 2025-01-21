using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product 
                {
                    Id = 1,
                    Cost = 2.5,
                    Quantity = 50,
                    Name = "Coke",
                    ProductCategoryId = 5,
                },
                new Product
                { 
                    Id = 2,
                    Cost = 15,
                    Name = "Sparkling Rose",
                    Quantity = 25,
                    ProductCategoryId = 5,
                },
                new Product
                {
                    Id = 3,
                    Cost = 2.5,
                    Quantity = 30,
                    Name = "Sprite",
                    ProductCategoryId = 5,
                },
                new Product
                {
                    Id = 4,
                    Cost = 5,
                    Quantity = 50,
                    Name = "Chocolate Milkshake",
                    ProductCategoryId = 5,
                },
                new Product
                {
                    Id = 5,
                    Cost = 10,
                    Quantity = 20,
                    Name = "Strawberry Blast with Cherry",
                    ProductCategoryId = 5,
                },
                new Product
                {
                    Id = 6,
                    Cost = 6.5,
                    Quantity = 50,
                    Name = "Chicken Chop",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 7,
                    Cost = 13,
                    Quantity = 10,
                    Name = "Mala Xiang Guo",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 8,
                    Cost = 26,
                    Quantity = 15,
                    Name = "Fresh Oyster",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 9,
                    Cost = 54,
                    Quantity = 23,
                    Name = "Beef Wellington",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 10,
                    Cost = 23,
                    Quantity = 13,
                    Name = "Sausage Platter",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 11,
                    Cost = 29,
                    Quantity = 15,
                    Name = "Crabmeat Pasta",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 12,
                    Cost = 22.5,
                    Quantity = 15,
                    Name = "Salmon don",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 13,
                    Cost = 10,
                    Quantity = 16,
                    Name = "Cai Fan Special",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 14,
                    Cost = 252,
                    Quantity = 10,
                    Name = "Wagyu Beef",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 15,
                    Cost = 128,
                    Quantity = 16,
                    Name = "Classic Ribeye",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 16,
                    Cost = 28,
                    Quantity = 32,
                    Name = "Crispy Sliced Onion Rings",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 17,
                    Cost = 20,
                    Quantity = 16,
                    Name = "French Fries",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 18,
                    Cost = 14,
                    Quantity = 16,
                    Name = "Mentaiko Fries",
                    ProductCategoryId = 2,
                },
                new Product
                {
                    Id = 19,
                    Cost = 12,
                    Quantity = 16,
                    Name = "Calamari",
                    ProductCategoryId = 2,
                });

        }
    }
}

using AnyReservationTemp.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyReservationTemp.Components.Entities
{
    public class ProductCategorySeed : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasData(
                new ProductCategory
                {
                    Id = 1,
                    Category = "Appetizer"
                },
                new ProductCategory
                {
                    Id = 2,
                    Category = "Main"
                },
                new ProductCategory
                {
                    Id = 3,
                    Category = "Sides"
                },
                new ProductCategory
                {
                    Id = 4,
                    Category = "Dessert"
                },
                new ProductCategory
                {
                    Id = 5,
                    Category = "Drinks"
                });
        }
    }
}

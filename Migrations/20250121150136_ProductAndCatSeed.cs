using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class ProductAndCatSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantProductId",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbd552f3-045b-407e-b893-e5b9c1c5c5f3", "AQAAAAIAAYagAAAAEOAU5I1nECypFgdiZhNXXk4HtWFt/UDfnEcNoLwrAL8PBS6bNgYV6R9Po0c6YSM3pA==", "a591216c-4ab3-448a-8b87-c3e0580d1756" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Contact", "Cost", "EmailAddress", "Name", "ProductCategoryId", "Quantity" },
                values: new object[,]
                {
                    { 1, null, 2.5, null, "Coke", 5, 50 },
                    { 2, null, 15.0, null, "Sparkling Rose", 5, 25 },
                    { 3, null, 2.5, null, "Sprite", 5, 30 },
                    { 4, null, 5.0, null, "Chocolate Milkshake", 5, 50 },
                    { 5, null, 10.0, null, "Strawberry Blast with Cherry", 5, 20 },
                    { 6, null, 6.5, null, "Chicken Chop", 2, 50 },
                    { 7, null, 13.0, null, "Mala Xiang Guo", 2, 10 },
                    { 8, null, 26.0, null, "Fresh Oyster", 2, 15 },
                    { 9, null, 54.0, null, "Beef Wellington", 2, 23 },
                    { 10, null, 23.0, null, "Sausage Platter", 2, 13 },
                    { 11, null, 29.0, null, "Crabmeat Pasta", 2, 15 },
                    { 12, null, 22.5, null, "Salmon don", 2, 15 },
                    { 13, null, 10.0, null, "Cai Fan Special", 2, 16 },
                    { 14, null, 252.0, null, "Wagyu Beef", 2, 10 },
                    { 15, null, 128.0, null, "Classic Ribeye", 2, 16 },
                    { 16, null, 28.0, null, "Crispy Sliced Onion Rings", 2, 32 },
                    { 17, null, 20.0, null, "French Fries", 2, 16 },
                    { 18, null, 14.0, null, "Mentaiko Fries", 2, 16 },
                    { 19, null, 12.0, null, "Calamari", 2, 16 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Category", "Contact", "EmailAddress", "Name" },
                values: new object[,]
                {
                    { 1, "Appetizer", null, null, null },
                    { 2, "Main", null, null, null },
                    { 3, "Sides", null, null, null },
                    { 4, "Dessert", null, null, null },
                    { 5, "Drinks", null, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 21, 23, 1, 35, 258, DateTimeKind.Local).AddTicks(9841), new TimeOnly(23, 1, 35, 258).Add(TimeSpan.FromTicks(9866)), new TimeOnly(23, 1, 35, 258).Add(TimeSpan.FromTicks(9857)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "RestaurantProductId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1863a890-df35-4e8a-9781-2a75debc1755", "AQAAAAIAAYagAAAAEKfXVZThRFL1jZOCzFxWkGzILeSDt7NuqX/eMWSbLtpXkwxS5maUn/bvQ56gHUiLUg==", "18f4389a-0667-47db-8a9a-5b88f984777f" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 21, 8, 14, 53, 139, DateTimeKind.Local).AddTicks(9669), new TimeOnly(8, 14, 53, 139).Add(TimeSpan.FromTicks(9691)), new TimeOnly(8, 14, 53, 139).Add(TimeSpan.FromTicks(9682)) });
        }
    }
}

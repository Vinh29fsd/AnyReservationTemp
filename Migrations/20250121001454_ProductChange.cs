using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class ProductChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductCategoryId",
                table: "RestaurantProductCategory",
                newName: "ProductId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantProductId",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "RestaurantProductCategory",
                newName: "ProductCategoryId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6eecdb1-60b2-4a66-99aa-2f0456fe7c9f", "AQAAAAIAAYagAAAAELwjQHRdJbwBlz1A/iQAOQ0TJq8HP2Wd6iJOPAMQhmqk1D+eiydQf9OFP05Ebd5efQ==", "80ec2ce2-de76-4ffc-a416-d51dbdfe5fbc" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 20, 8, 7, 28, 126, DateTimeKind.Local).AddTicks(8366), new TimeOnly(8, 7, 28, 126).Add(TimeSpan.FromTicks(8390)), new TimeOnly(8, 7, 28, 126).Add(TimeSpan.FromTicks(8381)) });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class productUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19c12951-2a1f-41f5-8938-71b7f9c08408", "AQAAAAIAAYagAAAAEGDW9rRF4VpauGMAwg3EPgSvh4sDhiAqiFx+VyyYNT8YiQ/PJNAihhtXn72LSwt4ig==", "22bfc4a1-77ef-4ca3-85fd-9f9ec2e13662" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "983b1e5d-ef88-4c1b-bac1-56e00d5e6387", "AQAAAAIAAYagAAAAEAxcLcpbZHQjuRogVkgAj79Mi3FyJ3B7TjyU/Qm/HmK3jFE2F/GOY6HMx010qxH6KQ==", "f3151740-c60f-4626-91bd-872333b50781" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41b73075-dea9-4fba-9a4f-0331abd78f72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3714827-65c6-4261-9c14-2c138fe80f11", "AQAAAAIAAYagAAAAEPdh1XySjMh3o6KbY9FE6akuWrAOIiB6Jae5IbMVIXz5h9vHfPLOlpaYtvNcBKUQ3g==", "d9f81ccb-8489-4eb7-af53-ca8bc31aac54" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 5, 18, 7, 28, 668, DateTimeKind.Local).AddTicks(6753), new TimeOnly(18, 7, 28, 668).Add(TimeSpan.FromTicks(6776)), new TimeOnly(18, 7, 28, 668).Add(TimeSpan.FromTicks(6767)) });

            migrationBuilder.InsertData(
                table: "RestaurantProductCategory",
                columns: new[] { "Id", "Contact", "EmailAddress", "Name", "ProductId", "RestaurantId" },
                values: new object[,]
                {
                    { 1, null, null, null, 3, 1 },
                    { 2, null, null, null, 20, 6 },
                    { 4, null, null, null, 19, 5 },
                    { 5, null, null, null, 18, 2 },
                    { 6, null, null, null, 17, 5 },
                    { 7, null, null, null, 16, 3 },
                    { 8, null, null, null, 15, 3 },
                    { 10, null, null, null, 14, 3 },
                    { 11, null, null, null, 13, 4 },
                    { 12, null, null, null, 12, 4 },
                    { 13, null, null, null, 11, 2 },
                    { 14, null, null, null, 10, 2 },
                    { 15, null, null, null, 9, 5 },
                    { 16, null, null, null, 8, 5 },
                    { 17, null, null, null, 7, 1 },
                    { 18, null, null, null, 6, 1 },
                    { 19, null, null, null, 5, 5 },
                    { 20, null, null, null, 4, 5 },
                    { 21, null, null, null, 2, 3 },
                    { 22, null, null, null, 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "RestaurantProductCategory",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9c753ff-7164-4acb-a387-675d4f0b04bb", "AQAAAAIAAYagAAAAENDIUslKaaEKjSw1u4VZfebXPePiTaZl+Okf846ncDKbP0vtb5BsKjJb7YiGAcXz8g==", "37401fcf-d40a-493e-a51e-92b32f56b345" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d0e1ab1-25f7-44b2-b0bb-067ed9437fbc", "AQAAAAIAAYagAAAAEHSL5weXtaRVN/kqjQXOfaqxQm8T1EWjJTErh/x4cDgr5BgF8fcQCK8cU04m6DaPCA==", "6e8f8880-4f7e-423f-915a-ed59b6da56bc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41b73075-dea9-4fba-9a4f-0331abd78f72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c1c3db6d-795c-4193-b6f0-d479338c10b7", "AQAAAAIAAYagAAAAEIeiW7iNHCiOd0pQBnvIa+3nHU3TzAaLfsg0N5CUCJHQxHEkt9CgLGaMUsjZ5feQtw==", "a973ee06-5b32-405a-8942-2141e94aae30" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 4, 23, 2, 2, 809, DateTimeKind.Local).AddTicks(983), new TimeOnly(23, 2, 2, 809).Add(TimeSpan.FromTicks(1006)), new TimeOnly(23, 2, 2, 809).Add(TimeSpan.FromTicks(997)) });
        }
    }
}

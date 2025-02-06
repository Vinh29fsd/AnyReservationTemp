using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantUserClaims_RestaurantDBupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c23fbbe3-4c80-4e70-9874-985d9030ef94", null, "RestaurantStaff", "RESTAURANTSTAFF" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d0e1ab1-25f7-44b2-b0bb-067ed9437fbc", "AQAAAAIAAYagAAAAEHSL5weXtaRVN/kqjQXOfaqxQm8T1EWjJTErh/x4cDgr5BgF8fcQCK8cU04m6DaPCA==", "6e8f8880-4f7e-423f-915a-ed59b6da56bc" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa", 0, "d9c753ff-7164-4acb-a387-675d4f0b04bb", "staff@restaurant.com", true, "Staff", "User", false, null, "STAFF@RESTAURANT.COM", "STAFF@RESTAURANT.COM", "AQAAAAIAAYagAAAAENDIUslKaaEKjSw1u4VZfebXPePiTaZl+Okf846ncDKbP0vtb5BsKjJb7YiGAcXz8g==", null, false, "37401fcf-d40a-493e-a51e-92b32f56b345", false, "staff@restaurant.com" },
                    { "41b73075-dea9-4fba-9a4f-0331abd78f72", 0, "c1c3db6d-795c-4193-b6f0-d479338c10b7", "staff@anyrestaurant.com", true, "Staff", "User", false, null, "STAFF@ANYRESTAURANT.COM", "STAFF@ANYRESTAURANT.COM", "AQAAAAIAAYagAAAAEIeiW7iNHCiOd0pQBnvIa+3nHU3TzAaLfsg0N5CUCJHQxHEkt9CgLGaMUsjZ5feQtw==", null, false, "a973ee06-5b32-405a-8942-2141e94aae30", false, "staff@anyrestaurant.com" }
                });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 4, 23, 2, 2, 809, DateTimeKind.Local).AddTicks(983), new TimeOnly(23, 2, 2, 809).Add(TimeSpan.FromTicks(1006)), new TimeOnly(23, 2, 2, 809).Add(TimeSpan.FromTicks(997)) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedBy", "UpdatedBy" },
                values: new object[] { null, null });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 4, "staffId", "b85ea83c-73db-4113-9bc3-e82c67f8aa63", "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa" },
                    { 5, "staffId", "734fe429-2610-47b4-b2e3-2b027086b57f", "41b73075-dea9-4fba-9a4f-0331abd78f72" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c23fbbe3-4c80-4e70-9874-985d9030ef94", "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa" },
                    { "c23fbbe3-4c80-4e70-9874-985d9030ef94", "41b73075-dea9-4fba-9a4f-0331abd78f72" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c23fbbe3-4c80-4e70-9874-985d9030ef94", "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c23fbbe3-4c80-4e70-9874-985d9030ef94", "41b73075-dea9-4fba-9a4f-0331abd78f72" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c23fbbe3-4c80-4e70-9874-985d9030ef94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41b73075-dea9-4fba-9a4f-0331abd78f72");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Restaurant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db27d3b3-3c8c-405d-82a5-40ec19624bef", "AQAAAAIAAYagAAAAEIPM27ACfJmRP3tMOpvzizk1FMIOJVM3pGay81RFTydXfQDSe+CoFX5oMd4qoFEhZQ==", "b28a1c23-ab12-4107-bdb0-a9f008e12f8d" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 51, 3, 521, DateTimeKind.Local).AddTicks(5591), new TimeOnly(18, 51, 3, 521).Add(TimeSpan.FromTicks(5611)), new TimeOnly(18, 51, 3, 521).Add(TimeSpan.FromTicks(5604)) });
        }
    }
}

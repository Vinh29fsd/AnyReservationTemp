using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantSeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cbbe817-a48b-424e-8a8e-d67ee2d580e1", "AQAAAAIAAYagAAAAEH/RCVARBXXhnojqe2DAMiFbIa+61EQfpfopPTYcDtGEpMjN98QxwngbPdqpSXYhNg==", "f61d578f-5e6b-4ae8-9b57-f3ca40565461" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 43, 2, 211, DateTimeKind.Local).AddTicks(630), new TimeOnly(12, 43, 2, 211).Add(TimeSpan.FromTicks(653)), new TimeOnly(12, 43, 2, 211).Add(TimeSpan.FromTicks(646)) });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Contact", "EmailAddress", "Location", "Name" },
                values: new object[,]
                {
                    { 2, "+65 6780 4191", "studentservices@tp.edu.sg", "21 Tampines Ave 4", "Brewing Grounds" },
                    { 3, "+65 6780 4191", "studentservices@tp.edu.sg", "21 Tampines Ave 4", "Wolfgang Puck" },
                    { 4, "+65 6780 4191", "studentservices@tp.edu.sg", "21 Tampines Ave 4", "ShortCircuit" },
                    { 5, "+65 6780 4191", "studentservices@tp.edu.sg", "21 Tampines Ave 4", "The Bistro Bar" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08a78bd5-40bb-45c1-abb6-53e6c7bc8d43", "AQAAAAIAAYagAAAAEGx6MOFxwRjglEoc+6d7t/xxZxvJdSb1pPz27Jdj8Klk9rnlJhqvBn9ktC8FWssOLg==", "faecddeb-3004-4f06-8daa-6bd43fb42541" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 15, 22, 12, 16, 123, DateTimeKind.Local).AddTicks(7326), new TimeOnly(22, 12, 16, 123).Add(TimeSpan.FromTicks(7351)), new TimeOnly(22, 12, 16, 123).Add(TimeSpan.FromTicks(7344)) });
        }
    }
}

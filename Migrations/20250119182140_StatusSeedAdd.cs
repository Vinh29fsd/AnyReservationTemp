using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class StatusSeedAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "723f3099-37ad-4fb8-ae27-1e4eff8da30a", "AQAAAAIAAYagAAAAEMumTV4jFWggj4qv/RSM7jAbdtv8zc89m/DXpj00gD5RF5BG9ah671087MdGIaSfnQ==", "f153c3ed-3a1e-4575-9d4b-221d59a193d1" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 20, 2, 21, 39, 762, DateTimeKind.Local).AddTicks(9834), new TimeOnly(2, 21, 39, 762).Add(TimeSpan.FromTicks(9857)), new TimeOnly(2, 21, 39, 762).Add(TimeSpan.FromTicks(9849)) });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "Id", "Contact", "Description", "EmailAddress", "Name" },
                values: new object[,]
                {
                    { 1, null, "Approved", null, null },
                    { 2, null, "Pending", null, null },
                    { 3, null, "Rejected", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Status",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "659b1659-766a-482d-a389-9133b862f3de", "AQAAAAIAAYagAAAAEC5rgiUOEaodNUVip0+n45iQ4Shr1CRa7mY+6PxAUPf+3rDt5sMeo2lTUd2lO02bhA==", "bc3b981b-952e-46e6-95b3-3bd0d434106f" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 20, 1, 38, 31, 186, DateTimeKind.Local).AddTicks(2480), new TimeOnly(1, 38, 31, 186).Add(TimeSpan.FromTicks(2500)), new TimeOnly(1, 38, 31, 186).Add(TimeSpan.FromTicks(2493)) });
        }
    }
}

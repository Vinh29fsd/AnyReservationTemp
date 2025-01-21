using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class StatusSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59711a78-2260-4d07-aa91-42868ce25dfd", "AQAAAAIAAYagAAAAEBxacr6zsMQDM2vsJfmBzEGUMDzKLKb6fXb/OLUa+Z+Q7q+WiBoZubFS5J0k/HSXBw==", "55292ee3-e978-4347-8bb7-242a328fa52d" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 19, 18, 45, 42, 870, DateTimeKind.Local).AddTicks(7730), new TimeOnly(18, 45, 42, 870).Add(TimeSpan.FromTicks(7752)), new TimeOnly(18, 45, 42, 870).Add(TimeSpan.FromTicks(7744)) });
        }
    }
}

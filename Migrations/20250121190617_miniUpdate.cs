using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class miniUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0375162e-ffeb-46cb-9fbf-3f0c28e3e236", "AQAAAAIAAYagAAAAEOuw1oaZwnQ1eL4d6cQAtXNOq9p0WtWseCdA7b3G/E1jHU8xKTxLiom5K2IveKh3ow==", "3ecef1a6-05ef-4b52-b98f-1df618370c33" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 22, 3, 6, 16, 124, DateTimeKind.Local).AddTicks(2499), new TimeOnly(3, 6, 16, 124).Add(TimeSpan.FromTicks(2521)), new TimeOnly(3, 6, 16, 124).Add(TimeSpan.FromTicks(2512)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4095c038-d158-4384-a5da-e474c2ce2e02", "AQAAAAIAAYagAAAAENftzunl7K7LIc6zU7LzcXhwbqt9fywwC+PEOtqBGq63rVW7Zw37n6iggzQu8v5ENw==", "c9dc41df-8ccd-4da3-8876-68691a444a3e" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 22, 2, 49, 59, 854, DateTimeKind.Local).AddTicks(4968), new TimeOnly(2, 49, 59, 854).Add(TimeSpan.FromTicks(4993)), new TimeOnly(2, 49, 59, 854).Add(TimeSpan.FromTicks(4984)) });
        }
    }
}

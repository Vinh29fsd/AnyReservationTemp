using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 10, 9, 48, 13, 937, DateTimeKind.Local).AddTicks(6655), new DateTime(2025, 1, 10, 12, 48, 13, 937, DateTimeKind.Local).AddTicks(6671), new DateTime(2025, 1, 10, 9, 48, 13, 937, DateTimeKind.Local).AddTicks(6670) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 8, 11, 28, 45, 363, DateTimeKind.Local).AddTicks(3202), new DateTime(2025, 1, 8, 14, 28, 45, 363, DateTimeKind.Local).AddTicks(3215), new DateTime(2025, 1, 8, 11, 28, 45, 363, DateTimeKind.Local).AddTicks(3215) });
        }
    }
}

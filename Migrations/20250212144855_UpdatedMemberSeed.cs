using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMemberSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e929827-baea-4459-ae7e-af2f16ce49d8", "AQAAAAIAAYagAAAAEJXDnJ5KQhG8D3NcVPVG6d1oi0aDuw61GO7PWY/LH0e172nKm4vJo0p+ZUVFL2HsPg==", "af360a6c-9d42-4fd3-bc40-9ab5fdf3da42" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 12, 22, 48, 54, 475, DateTimeKind.Local).AddTicks(5081), new DateTime(2025, 2, 13, 1, 48, 54, 475, DateTimeKind.Local).AddTicks(5095), new DateTime(2025, 2, 12, 22, 48, 54, 475, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 13, 7, 48, 54, 475, DateTimeKind.Local).AddTicks(5102), new DateTime(2025, 2, 13, 10, 48, 54, 475, DateTimeKind.Local).AddTicks(5104), new DateTime(2025, 2, 13, 7, 48, 54, 475, DateTimeKind.Local).AddTicks(5103) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eecb9d6-4ea8-423d-99b6-1004a12f403b", "AQAAAAIAAYagAAAAEC7GJPCQDgxU7FZ4mhZ5YoBEvIn29FJ/YZEjzlz1N+/xaPqBtADX8qWkWRxN/7/1qA==", "15797c1d-897c-429a-953f-9f866fae682e" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 12, 22, 44, 17, 177, DateTimeKind.Local).AddTicks(864), new DateTime(2025, 2, 13, 1, 44, 17, 177, DateTimeKind.Local).AddTicks(882), new DateTime(2025, 2, 12, 22, 44, 17, 177, DateTimeKind.Local).AddTicks(882) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 13, 7, 44, 17, 177, DateTimeKind.Local).AddTicks(888), new DateTime(2025, 2, 13, 10, 44, 17, 177, DateTimeKind.Local).AddTicks(889), new DateTime(2025, 2, 13, 7, 44, 17, 177, DateTimeKind.Local).AddTicks(888) });
        }
    }
}

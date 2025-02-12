using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMemberSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eed7a1b3-15dc-46b5-ae41-ada85f569b65", "AQAAAAIAAYagAAAAEESwTGuSLtkQ8H/SxQPDkj2inKl35jHEkLKExtjfXCPGohZJtUHlzHy/DwOP3OiFew==", "1370110e-2e51-440b-9b4d-4d8b5ceccfa1" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 12, 22, 39, 57, 176, DateTimeKind.Local).AddTicks(8261), new DateTime(2025, 2, 13, 1, 39, 57, 176, DateTimeKind.Local).AddTicks(8274), new DateTime(2025, 2, 12, 22, 39, 57, 176, DateTimeKind.Local).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 13, 7, 39, 57, 176, DateTimeKind.Local).AddTicks(8281), new DateTime(2025, 2, 13, 10, 39, 57, 176, DateTimeKind.Local).AddTicks(8282), new DateTime(2025, 2, 13, 7, 39, 57, 176, DateTimeKind.Local).AddTicks(8281) });
        }
    }
}

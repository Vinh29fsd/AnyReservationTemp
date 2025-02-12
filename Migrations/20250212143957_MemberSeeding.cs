using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class MemberSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e879ee3-3187-475b-b7d9-39f257f48d8c", "AQAAAAIAAYagAAAAEIczBQQgWCq46yh9jyxFCRnSxQ/4BEdMjHpQ2xbrmn+hcDmKqNQtYtNX48bUV67C1A==", "536a5dd2-dfcf-473b-8499-9ad4ea4e9dc5" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 12, 22, 15, 46, 2, DateTimeKind.Local).AddTicks(6094), new DateTime(2025, 2, 13, 1, 15, 46, 2, DateTimeKind.Local).AddTicks(6108), new DateTime(2025, 2, 12, 22, 15, 46, 2, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 13, 7, 15, 46, 2, DateTimeKind.Local).AddTicks(6113), new DateTime(2025, 2, 13, 10, 15, 46, 2, DateTimeKind.Local).AddTicks(6115), new DateTime(2025, 2, 13, 7, 15, 46, 2, DateTimeKind.Local).AddTicks(6114) });
        }
    }
}

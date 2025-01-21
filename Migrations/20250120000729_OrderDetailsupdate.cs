using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class OrderDetailsupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderDetail",
                newName: "ReservationId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6eecdb1-60b2-4a66-99aa-2f0456fe7c9f", "AQAAAAIAAYagAAAAELwjQHRdJbwBlz1A/iQAOQ0TJq8HP2Wd6iJOPAMQhmqk1D+eiydQf9OFP05Ebd5efQ==", "80ec2ce2-de76-4ffc-a416-d51dbdfe5fbc" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 20, 8, 7, 28, 126, DateTimeKind.Local).AddTicks(8366), new TimeOnly(8, 7, 28, 126).Add(TimeSpan.FromTicks(8390)), new TimeOnly(8, 7, 28, 126).Add(TimeSpan.FromTicks(8381)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "OrderDetail",
                newName: "OrderId");

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
        }
    }
}

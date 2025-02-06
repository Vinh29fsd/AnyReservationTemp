using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "OrderDetail",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "159cd86e-7362-47e6-97bc-06282bbfe3c4", "AQAAAAIAAYagAAAAED4lfgYPalWmNG8dBVB+rvQAhgBXBUOLXHcjm8ZnYqpCi1SMqLyCymIOsGaYjb3y+A==", "2dd19b50-a876-4029-a7eb-dad7c758a249" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 22, 4, 34, 21, 427, DateTimeKind.Local).AddTicks(7953), new TimeOnly(4, 34, 21, 427).Add(TimeSpan.FromTicks(7982)), new TimeOnly(4, 34, 21, 427).Add(TimeSpan.FromTicks(7973)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductId",
                table: "OrderDetail",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}

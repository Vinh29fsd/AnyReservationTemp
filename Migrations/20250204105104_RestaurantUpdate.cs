using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db27d3b3-3c8c-405d-82a5-40ec19624bef", "AQAAAAIAAYagAAAAEIPM27ACfJmRP3tMOpvzizk1FMIOJVM3pGay81RFTydXfQDSe+CoFX5oMd4qoFEhZQ==", "b28a1c23-ab12-4107-bdb0-a9f008e12f8d" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 4, 18, 51, 3, 521, DateTimeKind.Local).AddTicks(5591), new TimeOnly(18, 51, 3, 521).Add(TimeSpan.FromTicks(5611)), new TimeOnly(18, 51, 3, 521).Add(TimeSpan.FromTicks(5604)) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "/UI photos/breadboard.png");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "/UI photos/restaurant_logo.png");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "/UI photos/Wolfgang_Puck_logo.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "/UI photos/Short_Circuit_Logo.jpg");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: "/UI photos/bisto_bar_logo.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "790901e6-209b-4da8-8802-b362b71931a4", "AQAAAAIAAYagAAAAEGCnvH9HSZXY3raaN9ik3OafG0K2ZexcJH7InHBdoCeudbL5c1p409xrerFXPL8SjQ==", "9db8cbe2-977e-405d-87cd-2aa93f0d5acd" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 23, 15, 2, 46, 372, DateTimeKind.Local).AddTicks(9924), new TimeOnly(15, 2, 46, 372).Add(TimeSpan.FromTicks(9943)), new TimeOnly(15, 2, 46, 372).Add(TimeSpan.FromTicks(9935)) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImagePath",
                value: null);
        }
    }
}

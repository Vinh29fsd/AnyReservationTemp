using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class ReservationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Reservation",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreatedBy", "DateCreated", "DateReserved", "DateUpdated", "EndTime", "StartTime", "UpdatedBy" },
                values: new object[] { null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 19, 18, 45, 42, 870, DateTimeKind.Local).AddTicks(7730), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeOnly(18, 45, 42, 870).Add(TimeSpan.FromTicks(7752)), new TimeOnly(18, 45, 42, 870).Add(TimeSpan.FromTicks(7744)), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Reservation");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c49b5b8f-52c2-4847-85c8-b658812c45a6", "AQAAAAIAAYagAAAAEGhAdXsajn3iCStJPMoh73Y7sN12iRGF/M5QQGyEb7+Tsr+gav24srIs8lpz6Skxdw==", "918c41c4-c00b-44b5-b470-21292d8d24e5" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 17, 13, 13, 54, 554, DateTimeKind.Local).AddTicks(1057), new TimeOnly(13, 13, 54, 554).Add(TimeSpan.FromTicks(1090)), new TimeOnly(13, 13, 54, 554).Add(TimeSpan.FromTicks(1080)) });
        }
    }
}

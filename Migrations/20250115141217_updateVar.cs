using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class updateVar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "StartTime",
                table: "Reservation",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "EndTime",
                table: "Reservation",
                type: "time",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08a78bd5-40bb-45c1-abb6-53e6c7bc8d43", "AQAAAAIAAYagAAAAEGx6MOFxwRjglEoc+6d7t/xxZxvJdSb1pPz27Jdj8Klk9rnlJhqvBn9ktC8FWssOLg==", "faecddeb-3004-4f06-8daa-6bd43fb42541" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 15, 22, 12, 16, 123, DateTimeKind.Local).AddTicks(7326), new TimeOnly(22, 12, 16, 123).Add(TimeSpan.FromTicks(7351)), new TimeOnly(22, 12, 16, 123).Add(TimeSpan.FromTicks(7344)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "Reservation",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(TimeOnly),
                oldType: "time");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "193d67cb-e6db-45ef-8326-832201fc6568", "AQAAAAIAAYagAAAAEMYcINUhtWhmj4lNdGduGDP960HEkH/Je2rXWv1CvjLL9/m2IJaKj8/WBzBQAGqrYA==", "1ab3c8dd-ba2f-4a20-a9cc-cfbbb3f8b62b" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 14, 23, 0, 21, 903, DateTimeKind.Local).AddTicks(7445), new DateTime(2025, 1, 15, 2, 0, 21, 903, DateTimeKind.Local).AddTicks(7458), new DateTime(2025, 1, 14, 23, 0, 21, 903, DateTimeKind.Local).AddTicks(7458) });
        }
    }
}

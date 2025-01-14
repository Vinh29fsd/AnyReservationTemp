using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class RevertImagePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ImagePath",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "ImagePath",
                table: "Restaurant",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5090afab-7e85-4270-9f50-229849d70a17", "AQAAAAIAAYagAAAAEL1RaOqVhqFQKlo3NmzDpJLDDsndEBQ6ho1QnI5klxPh9lfRdJTWFUsjPJAmmGA3DA==", "ba15c442-4766-4578-8112-af0820a44391" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 15, 27, 15, 468, DateTimeKind.Local).AddTicks(9203), new TimeOnly(15, 27, 15, 468).Add(TimeSpan.FromTicks(9224)), new TimeOnly(15, 27, 15, 468).Add(TimeSpan.FromTicks(9216)) });

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

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3480a2e3-c99f-4b5f-9eb2-fa7a24b88bdf", "AQAAAAIAAYagAAAAEGHj6SloBGNjLnAE2a6sBCB1/A5TfQHLGZj4HM+6DScAchF/XI7WkyxCl5ZjCt/j9g==", "6b2ff6ec-72f0-4403-8fc9-c4cd6656ee98" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 56, 21, 47, DateTimeKind.Local).AddTicks(7202), new TimeOnly(12, 56, 21, 47).Add(TimeSpan.FromTicks(7223)), new TimeOnly(12, 56, 21, 47).Add(TimeSpan.FromTicks(7217)) });

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
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Restaurant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cbbe817-a48b-424e-8a8e-d67ee2d580e1", "AQAAAAIAAYagAAAAEH/RCVARBXXhnojqe2DAMiFbIa+61EQfpfopPTYcDtGEpMjN98QxwngbPdqpSXYhNg==", "f61d578f-5e6b-4ae8-9b57-f3ca40565461" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 16, 12, 43, 2, 211, DateTimeKind.Local).AddTicks(630), new TimeOnly(12, 43, 2, 211).Add(TimeSpan.FromTicks(653)), new TimeOnly(12, 43, 2, 211).Add(TimeSpan.FromTicks(646)) });
        }
    }
}

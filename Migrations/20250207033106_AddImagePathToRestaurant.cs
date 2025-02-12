using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class AddImagePathToRestaurant : Migration
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
                values: new object[] { "da0a4537-0caf-43de-b0f2-f8d736bc3b71", "AQAAAAIAAYagAAAAEGTnULjVr4we9eELIM7Vgb1FYLrRwSyjZ3YfUPcX11bM6eD2FaY3S36DL9BLE71Lvw==", "289f2008-c004-4dc8-8dfd-5ed6dadfe7a7" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 7, 11, 31, 5, 83, DateTimeKind.Local).AddTicks(9787), new DateTime(2025, 2, 7, 14, 31, 5, 83, DateTimeKind.Local).AddTicks(9800), new DateTime(2025, 2, 7, 11, 31, 5, 83, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImagePath", "Name" },
                values: new object[] { null, "Breadboard" });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Contact", "EmailAddress", "ImagePath", "Location", "Name" },
                values: new object[] { 2, "+65 6780 4191", "studentservices@tp.edu.sg", null, "21 Tampines Ave 4", "ShortCircuit" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Restaurant");

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

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "BreadBoard");
        }
    }
}

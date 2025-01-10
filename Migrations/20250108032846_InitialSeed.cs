using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class InitialSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "Contact", "EmailAddress", "Name" },
                values: new object[,]
                {
                    { 1, "8858 6939", "owen@gmail.com", "Owen Lau Jun Kai" },
                    { 2, "9661 0401", "vovinhho@gmail.com", "Ho Vo Vinh" }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "Contact", "CustomerId", "DateReserved", "EmailAddress", "EndTime", "Name", "NumOfCustomer", "ProgressId", "RestaurantId", "StartTime", "TableNo" },
                values: new object[] { 1, "9661 0401", 0, new DateTime(2025, 1, 8, 11, 28, 45, 363, DateTimeKind.Local).AddTicks(3202), "vovinhho@gmail.com", new DateTime(2025, 1, 8, 14, 28, 45, 363, DateTimeKind.Local).AddTicks(3215), "Ho Vo Vinh", 1, 0, 0, new DateTime(2025, 1, 8, 11, 28, 45, 363, DateTimeKind.Local).AddTicks(3215), 0 });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "Contact", "EmailAddress", "Location", "Name" },
                values: new object[] { 1, "+65 6780 4191", "studentservices@tp.edu.sg", "21 Tampines Ave 4", "BreadBoard" });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Id", "Contact", "EmailAddress", "NRIC", "Name", "RestaurantId" },
                values: new object[] { 1, "9546 2365", "workJames@gmail.com", "T0047564I", "James Roger", 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

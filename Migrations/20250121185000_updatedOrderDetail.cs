using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class updatedOrderDetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "4095c038-d158-4384-a5da-e474c2ce2e02", "AQAAAAIAAYagAAAAENftzunl7K7LIc6zU7LzcXhwbqt9fywwC+PEOtqBGq63rVW7Zw37n6iggzQu8v5ENw==", "c9dc41df-8ccd-4da3-8876-68691a444a3e" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 22, 2, 49, 59, 854, DateTimeKind.Local).AddTicks(4968), new TimeOnly(2, 49, 59, 854).Add(TimeSpan.FromTicks(4993)), new TimeOnly(2, 49, 59, 854).Add(TimeSpan.FromTicks(4984)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "dbd552f3-045b-407e-b893-e5b9c1c5c5f3", "AQAAAAIAAYagAAAAEOAU5I1nECypFgdiZhNXXk4HtWFt/UDfnEcNoLwrAL8PBS6bNgYV6R9Po0c6YSM3pA==", "a591216c-4ab3-448a-8b87-c3e0580d1756" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 1, 21, 23, 1, 35, 258, DateTimeKind.Local).AddTicks(9841), new TimeOnly(23, 1, 35, 258).Add(TimeSpan.FromTicks(9866)), new TimeOnly(23, 1, 35, 258).Add(TimeSpan.FromTicks(9857)) });
        }
    }
}

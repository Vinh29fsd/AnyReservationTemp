using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class OrderSystemChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "OrderDetail");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "OrderDateTime",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "ReservationId",
                table: "OrderDetail",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Order",
                newName: "ResevationId");

            migrationBuilder.AddColumn<double>(
                name: "TotalAmount",
                table: "Order",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderDetail",
                newName: "ReservationId");

            migrationBuilder.RenameColumn(
                name: "ResevationId",
                table: "Order",
                newName: "ProductId");

            migrationBuilder.AddColumn<double>(
                name: "TotalAmount",
                table: "OrderDetail",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderDateTime",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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
    }
}

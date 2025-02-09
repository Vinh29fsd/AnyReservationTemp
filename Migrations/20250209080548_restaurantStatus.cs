using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class restaurantStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ServiceStatus",
                table: "Restaurant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5f9c4ca-b180-46f5-ad2d-e5dea1320096", "AQAAAAIAAYagAAAAEH3259EJsOnzlX/Fe2fD1F35s5P9QGP8RZ0Zbmjg7SPyi9CpY91CFnq2kOtMBUowNA==", "27f41c67-1089-4f6b-87c4-7958438ada7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52bbbcdc-032b-4cad-82f8-c797e75fef4c", "AQAAAAIAAYagAAAAEOdKlpE209H/QP74K5u6o29wH14yIOwDTlkGWQI5N4Pb8Ez21xvjHnE5NAlTifpzPg==", "b2783b1e-38c7-42f6-aff7-bd18b604fe44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41b73075-dea9-4fba-9a4f-0331abd78f72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c266cf70-83d2-4415-ba32-ba3491be279b", "AQAAAAIAAYagAAAAEIbo5ERhpeRzmP9tFzdsXi32pKv44OdIMyVKiALaaGLAjO1+iJklrMsl6OTBG9bqTg==", "7d816685-f6c0-49ef-969e-9144d3025f07" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 5, 46, 971, DateTimeKind.Local).AddTicks(6419), new TimeOnly(16, 5, 46, 971).Add(TimeSpan.FromTicks(6441)), new TimeOnly(16, 5, 46, 971).Add(TimeSpan.FromTicks(6435)) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                column: "ServiceStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                column: "ServiceStatus",
                value: false);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                column: "ServiceStatus",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceStatus",
                table: "Restaurant");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dbf44b5-26fe-42a8-9141-c88578607f35", "AQAAAAIAAYagAAAAEJhHLndNTJSTJaCslYVWn7L9LBjObE9gwOTk3ImnhUcvdZIdJhH37TUuE4ufhshQCg==", "3494c622-58d4-4139-8b36-83c08014aeba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0c588ad-a9eb-4785-bc01-25248d6ab203", "AQAAAAIAAYagAAAAELBQtpre0MsQ9nfyIo9tVyHKlf+Hqu+B+QDR7IwWrLb8MAt5isP1vMuO3qsQ79yjIQ==", "11c2e3ff-d26e-4f2a-890c-95eaab916866" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41b73075-dea9-4fba-9a4f-0331abd78f72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2aa6ea7-864c-4fae-8152-6b0a50da6ab7", "AQAAAAIAAYagAAAAEI6dFjNgBuudaO5LH6XkYIp1BU1O5+cl8mkCw0ZmwBZabYR/KdwbHLVq4QtYzhhGHA==", "69b9075d-d68f-4186-840e-17494f27c72d" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 6, 14, 9, 7, 355, DateTimeKind.Local).AddTicks(4930), new TimeOnly(14, 9, 7, 355).Add(TimeSpan.FromTicks(4957)), new TimeOnly(14, 9, 7, 355).Add(TimeSpan.FromTicks(4946)) });
        }
    }
}

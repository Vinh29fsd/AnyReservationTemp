using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class ClaimsUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "ClaimValue",
                value: "41b73075-dea9-4fba-9a4f-0331abd78f72");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 4,
                column: "ClaimValue",
                value: "b85ea83c-73db-4113-9bc3-e82c67f8aa63");

            migrationBuilder.UpdateData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 5,
                column: "ClaimValue",
                value: "734fe429-2610-47b4-b2e3-2b027086b57f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19c12951-2a1f-41f5-8938-71b7f9c08408", "AQAAAAIAAYagAAAAEGDW9rRF4VpauGMAwg3EPgSvh4sDhiAqiFx+VyyYNT8YiQ/PJNAihhtXn72LSwt4ig==", "22bfc4a1-77ef-4ca3-85fd-9f9ec2e13662" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "983b1e5d-ef88-4c1b-bac1-56e00d5e6387", "AQAAAAIAAYagAAAAEAxcLcpbZHQjuRogVkgAj79Mi3FyJ3B7TjyU/Qm/HmK3jFE2F/GOY6HMx010qxH6KQ==", "f3151740-c60f-4626-91bd-872333b50781" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41b73075-dea9-4fba-9a4f-0331abd78f72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3714827-65c6-4261-9c14-2c138fe80f11", "AQAAAAIAAYagAAAAEPdh1XySjMh3o6KbY9FE6akuWrAOIiB6Jae5IbMVIXz5h9vHfPLOlpaYtvNcBKUQ3g==", "d9f81ccb-8489-4eb7-af53-ca8bc31aac54" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 5, 18, 7, 28, 668, DateTimeKind.Local).AddTicks(6753), new TimeOnly(18, 7, 28, 668).Add(TimeSpan.FromTicks(6776)), new TimeOnly(18, 7, 28, 668).Add(TimeSpan.FromTicks(6767)) });
        }
    }
}

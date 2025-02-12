using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMemberSeedTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4813491-bd1f-4a93-81d7-28908cd03aed", "AQAAAAIAAYagAAAAEHY+Wy1nQq43DYlOyxgnHasywkb5Qfa6L7zQidfupTBgkI74iUiF8KBdhsrMsOblpg==", "42c7a1ae-6cd6-45c3-ae14-e13a7d6d300a" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 12, 22, 55, 40, 21, DateTimeKind.Local).AddTicks(3048), new DateTime(2025, 2, 13, 1, 55, 40, 21, DateTimeKind.Local).AddTicks(3068), new DateTime(2025, 2, 12, 22, 55, 40, 21, DateTimeKind.Local).AddTicks(3067) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 13, 7, 55, 40, 21, DateTimeKind.Local).AddTicks(3078), new DateTime(2025, 2, 13, 10, 55, 40, 21, DateTimeKind.Local).AddTicks(3079), new DateTime(2025, 2, 13, 7, 55, 40, 21, DateTimeKind.Local).AddTicks(3078) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e929827-baea-4459-ae7e-af2f16ce49d8", "AQAAAAIAAYagAAAAEJXDnJ5KQhG8D3NcVPVG6d1oi0aDuw61GO7PWY/LH0e172nKm4vJo0p+ZUVFL2HsPg==", "af360a6c-9d42-4fd3-bc40-9ab5fdf3da42" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 12, 22, 48, 54, 475, DateTimeKind.Local).AddTicks(5081), new DateTime(2025, 2, 13, 1, 48, 54, 475, DateTimeKind.Local).AddTicks(5095), new DateTime(2025, 2, 12, 22, 48, 54, 475, DateTimeKind.Local).AddTicks(5094) });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 13, 7, 48, 54, 475, DateTimeKind.Local).AddTicks(5102), new DateTime(2025, 2, 13, 10, 48, 54, 475, DateTimeKind.Local).AddTicks(5104), new DateTime(2025, 2, 13, 7, 48, 54, 475, DateTimeKind.Local).AddTicks(5103) });
        }
    }
}

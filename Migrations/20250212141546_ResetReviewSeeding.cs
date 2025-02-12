using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class ResetReviewSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RestaurantId",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "MembershipLevel",
                table: "Member",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e879ee3-3187-475b-b7d9-39f257f48d8c", "AQAAAAIAAYagAAAAEIczBQQgWCq46yh9jyxFCRnSxQ/4BEdMjHpQ2xbrmn+hcDmKqNQtYtNX48bUV67C1A==", "536a5dd2-dfcf-473b-8499-9ad4ea4e9dc5" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 12, 22, 15, 46, 2, DateTimeKind.Local).AddTicks(6094), new DateTime(2025, 2, 13, 1, 15, 46, 2, DateTimeKind.Local).AddTicks(6108), new DateTime(2025, 2, 12, 22, 15, 46, 2, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "Id", "Contact", "CustomerId", "DateReserved", "EmailAddress", "EndTime", "Name", "NumOfCustomer", "ProgressId", "RestaurantId", "StartTime", "TableNo" },
                values: new object[] { 2, "8858 6939", 0, new DateTime(2025, 2, 13, 7, 15, 46, 2, DateTimeKind.Local).AddTicks(6113), "owenlau@gmail.com", new DateTime(2025, 2, 13, 10, 15, 46, 2, DateTimeKind.Local).AddTicks(6115), "Owen Lau", 2, 0, 0, new DateTime(2025, 2, 13, 7, 15, 46, 2, DateTimeKind.Local).AddTicks(6114), 0 });

            migrationBuilder.InsertData(
                table: "Review",
                columns: new[] { "Id", "Comment", "Contact", "EmailAddress", "Name", "Rating", "ReservationId", "RestaurantId" },
                values: new object[,]
                {
                    { 10, "Good service!", "+65 88586939", "owenlau@gmail.com", "Owen", 4, 0, 1 },
                    { 30, "bad service", "+65 72642847", "tpstudent@gmail.com", "tp student", 2, 0, 2 },
                    { 40, "Good food too!", "+65 88586939", "owenlau@gmail.com", "Owen", 5, 0, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_RestaurantId",
                table: "Review",
                column: "RestaurantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Restaurant_RestaurantId",
                table: "Review",
                column: "RestaurantId",
                principalTable: "Restaurant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Restaurant_RestaurantId",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_RestaurantId",
                table: "Review");

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Review",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DropColumn(
                name: "RestaurantId",
                table: "Review");

            migrationBuilder.AlterColumn<string>(
                name: "MembershipLevel",
                table: "Member",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25047564-eaa5-49bd-89b3-843b121cb662", "AQAAAAIAAYagAAAAEO+2nfJcfv/w29eBWlguc9fpNUHO6/xLsiVZKaot5PmgkIuUQX+30z45adxGsLt4cQ==", "c1e3a973-cb8d-44b9-b934-b403d6e0518e" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 9, 15, 38, 32, 200, DateTimeKind.Local).AddTicks(3959), new DateTime(2025, 2, 9, 18, 38, 32, 200, DateTimeKind.Local).AddTicks(3973), new DateTime(2025, 2, 9, 15, 38, 32, 200, DateTimeKind.Local).AddTicks(3972) });
        }
    }
}

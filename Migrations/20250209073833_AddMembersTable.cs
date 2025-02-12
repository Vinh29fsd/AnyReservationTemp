using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class AddMembersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    MembershipLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JoinDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Member_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Member_CustomerId",
                table: "Member",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Member");

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
        }
    }
}

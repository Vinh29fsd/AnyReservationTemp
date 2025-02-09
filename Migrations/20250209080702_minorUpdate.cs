using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnyReservationTemp.Migrations
{
    /// <inheritdoc />
    public partial class minorUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07f8ba5b-c88f-47fb-8405-43d39e3dc0fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "956b19c5-c53d-484b-a5b3-7b2e8b72757b", "AQAAAAIAAYagAAAAEENtXPqoRmPlvzvWgVVVbCW8lBo3QvfpFPGetgH4dgzBxoa85u/IhRKGZANZHs05TQ==", "8ae9f3ca-39fc-4ead-99c2-19f449edab31" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffe03d27-bc33-46b9-a8fb-9ed5433b99ab", "AQAAAAIAAYagAAAAEGYgubZiJw1R54BEntxL2vb84EyeenCsjgOYSbo6VndN0f9VKw+HRfhni8cas72vSg==", "058721c3-16fe-44b8-aefc-32c86df08a23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41b73075-dea9-4fba-9a4f-0331abd78f72",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "383a886d-a9ed-4390-8cc7-c5e975507bfb", "AQAAAAIAAYagAAAAEGxTftG7wNfUKvsHir7m0BZgXe8+UnooWW2+3d2XehxQm4pnoRMWQL56Oqlo4w14Tg==", "b034d5cb-4838-4d07-a85f-9d6561d3bd5c" });

            migrationBuilder.UpdateData(
                table: "Reservation",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateReserved", "EndTime", "StartTime" },
                values: new object[] { new DateTime(2025, 2, 9, 16, 7, 1, 962, DateTimeKind.Local).AddTicks(5129), new TimeOnly(16, 7, 1, 962).Add(TimeSpan.FromTicks(5158)), new TimeOnly(16, 7, 1, 962).Add(TimeSpan.FromTicks(5144)) });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1,
                column: "ServiceStatus",
                value: true);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2,
                column: "ServiceStatus",
                value: true);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3,
                column: "ServiceStatus",
                value: true);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4,
                column: "ServiceStatus",
                value: true);

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 5,
                column: "ServiceStatus",
                value: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

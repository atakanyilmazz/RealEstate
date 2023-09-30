using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "CreateTime", "DeleteTime", "IsDeleted", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(857), null, false, "Türkiye" },
                    { 2, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(865), null, false, "Holland" },
                    { 3, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(866), null, false, "France" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "CreateTime", "DeleteTime", "IsDeleted", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(939), null, false, "İstanbul" },
                    { 2, 1, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(965), null, false, "İzmir" },
                    { 3, 1, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(966), null, false, "Antalya" },
                    { 4, 2, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(966), null, false, "Utrecht" },
                    { 5, 3, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(967), null, false, "Lyon" }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "CityId", "CreateTime", "DeleteTime", "IsDeleted", "Value" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(980), null, false, "Sarıyer" },
                    { 2, 1, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(981), null, false, "Beşiktaş" },
                    { 3, 1, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(981), null, false, "Levent" },
                    { 4, 2, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(982), null, false, "Aliağa" },
                    { 5, 2, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(983), null, false, "Balçova" },
                    { 6, 2, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(983), null, false, "Bayındır" },
                    { 7, 3, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(984), null, false, "Alanya" },
                    { 8, 3, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(984), null, false, "Korkuteli" },
                    { 9, 3, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(985), null, false, "Muratpaşa" },
                    { 10, 4, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(985), null, false, "Amersfoort" },
                    { 11, 5, new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(986), null, false, "Corse" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

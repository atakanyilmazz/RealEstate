using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9871));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9950));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "Id", "CreateTime", "DeleteTime", "IsDeleted", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9969), null, false, "1+0" },
                    { 2, new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9970), null, false, "1+1" },
                    { 3, new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9970), null, false, "2+1" },
                    { 4, new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9971), null, false, "3+1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(965));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(857));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(865));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(982));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(983));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 15, 35, 779, DateTimeKind.Local).AddTicks(986));
        }
    }
}

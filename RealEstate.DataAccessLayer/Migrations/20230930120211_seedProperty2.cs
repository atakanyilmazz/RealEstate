using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class seedProperty2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5112));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5114));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5127));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5129));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5131));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5133));

            migrationBuilder.InsertData(
                table: "Properties",
                columns: new[] { "Id", "CreateTime", "DeleteTime", "DistrictId", "IsDeleted", "Price", "PropertyType", "RoomId", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5171), null, 1, false, 12000m, 1, 3, "Test 1" },
                    { 2, new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5173), null, 8, false, 5000m, 1, 1, "Test 2" },
                    { 3, new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5174), null, 10, false, 3000000m, 0, 1, "Test 3" },
                    { 4, new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5175), null, 1, false, 1000000m, 0, 2, "Test 4" }
                });

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.InsertData(
                table: "PropertyPropertyFeature",
                columns: new[] { "PropertiesId", "ProperyFeaturesId" },
                values: new object[] { 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PropertyPropertyFeature",
                keyColumns: new[] { "PropertiesId", "ProperyFeaturesId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5320));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5333));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5335));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5336));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5339));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5355));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5356));
        }
    }
}

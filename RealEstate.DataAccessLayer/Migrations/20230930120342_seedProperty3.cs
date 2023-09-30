using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class seedProperty3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3336));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3357));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3428));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3429));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.InsertData(
                table: "PropertyPropertyFeature",
                columns: new[] { "PropertiesId", "ProperyFeaturesId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 1 }
                });

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3371));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 3, 42, 802, DateTimeKind.Local).AddTicks(3373));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PropertyPropertyFeature",
                keyColumns: new[] { "PropertiesId", "ProperyFeaturesId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "PropertyPropertyFeature",
                keyColumns: new[] { "PropertiesId", "ProperyFeaturesId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "PropertyPropertyFeature",
                keyColumns: new[] { "PropertiesId", "ProperyFeaturesId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "PropertyPropertyFeature",
                keyColumns: new[] { "PropertiesId", "ProperyFeaturesId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "PropertyPropertyFeature",
                keyColumns: new[] { "PropertiesId", "ProperyFeaturesId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "PropertyPropertyFeature",
                keyColumns: new[] { "PropertiesId", "ProperyFeaturesId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "PropertyPropertyFeature",
                keyColumns: new[] { "PropertiesId", "ProperyFeaturesId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "PropertyPropertyFeature",
                keyColumns: new[] { "PropertiesId", "ProperyFeaturesId" },
                keyValues: new object[] { 4, 1 });

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

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5174));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 15, 2, 11, 98, DateTimeKind.Local).AddTicks(5175));

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
        }
    }
}

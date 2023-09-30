using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class PropertyFeaturesNamingFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyPropertyFeature_PropertyFeatures_ProperyFeaturesId",
                table: "PropertyPropertyFeature");

            migrationBuilder.RenameColumn(
                name: "ProperyFeaturesId",
                table: "PropertyPropertyFeature",
                newName: "PropertyFeaturesId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyPropertyFeature_ProperyFeaturesId",
                table: "PropertyPropertyFeature",
                newName: "IX_PropertyPropertyFeature_PropertyFeaturesId");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3603));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3524));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3532));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3618));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3621));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3622));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3624));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3691));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "PropertyFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3636));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 17, 45, 17, 63, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyPropertyFeature_PropertyFeatures_PropertyFeaturesId",
                table: "PropertyPropertyFeature",
                column: "PropertyFeaturesId",
                principalTable: "PropertyFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PropertyPropertyFeature_PropertyFeatures_PropertyFeaturesId",
                table: "PropertyPropertyFeature");

            migrationBuilder.RenameColumn(
                name: "PropertyFeaturesId",
                table: "PropertyPropertyFeature",
                newName: "ProperyFeaturesId");

            migrationBuilder.RenameIndex(
                name: "IX_PropertyPropertyFeature_PropertyFeaturesId",
                table: "PropertyPropertyFeature",
                newName: "IX_PropertyPropertyFeature_ProperyFeaturesId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_PropertyPropertyFeature_PropertyFeatures_ProperyFeaturesId",
                table: "PropertyPropertyFeature",
                column: "ProperyFeaturesId",
                principalTable: "PropertyFeatures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

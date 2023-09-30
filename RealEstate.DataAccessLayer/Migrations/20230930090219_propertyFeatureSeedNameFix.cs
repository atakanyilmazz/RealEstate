using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RealEstate.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class propertyFeatureSeedNameFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyProperyFeature");

            migrationBuilder.DropTable(
                name: "ProperyFeatures");

            migrationBuilder.CreateTable(
                name: "PropertyFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyPropertyFeature",
                columns: table => new
                {
                    PropertiesId = table.Column<int>(type: "int", nullable: false),
                    ProperyFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyPropertyFeature", x => new { x.PropertiesId, x.ProperyFeaturesId });
                    table.ForeignKey(
                        name: "FK_PropertyPropertyFeature_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyPropertyFeature_PropertyFeatures_ProperyFeaturesId",
                        column: x => x.ProperyFeaturesId,
                        principalTable: "PropertyFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "PropertyFeatures",
                columns: new[] { "Id", "CreateTime", "DeleteTime", "IsDeleted", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5366), null, false, "Kombi" },
                    { 2, new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5367), null, false, "Parke" },
                    { 3, new DateTime(2023, 9, 30, 12, 2, 18, 877, DateTimeKind.Local).AddTicks(5368), null, false, "Eşyalı" }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PropertyPropertyFeature_ProperyFeaturesId",
                table: "PropertyPropertyFeature",
                column: "ProperyFeaturesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PropertyPropertyFeature");

            migrationBuilder.DropTable(
                name: "PropertyFeatures");

            migrationBuilder.CreateTable(
                name: "ProperyFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProperyFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyProperyFeature",
                columns: table => new
                {
                    PropertiesId = table.Column<int>(type: "int", nullable: false),
                    ProperyFeaturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyProperyFeature", x => new { x.PropertiesId, x.ProperyFeaturesId });
                    table.ForeignKey(
                        name: "FK_PropertyProperyFeature_Properties_PropertiesId",
                        column: x => x.PropertiesId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PropertyProperyFeature_ProperyFeatures_ProperyFeaturesId",
                        column: x => x.ProperyFeaturesId,
                        principalTable: "ProperyFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "RoomTypes",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2023, 9, 30, 11, 48, 48, 505, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.CreateIndex(
                name: "IX_PropertyProperyFeature_ProperyFeaturesId",
                table: "PropertyProperyFeature",
                column: "ProperyFeaturesId");
        }
    }
}

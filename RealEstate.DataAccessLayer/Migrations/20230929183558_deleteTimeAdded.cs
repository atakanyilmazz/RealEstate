using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RealEstate.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class deleteTimeAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "RoomTypes",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "ProperyFeatures",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Properties",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Districts",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Countries",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Cities",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "ProperyFeatures");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Properties");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Districts");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Cities");
        }
    }
}

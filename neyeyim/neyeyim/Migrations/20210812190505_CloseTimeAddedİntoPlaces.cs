using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class CloseTimeAddedİntoPlaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OpenCloseTime",
                table: "Places");

            migrationBuilder.AddColumn<DateTime>(
                name: "CloseTime",
                table: "Places",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "OpenTime",
                table: "Places",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CloseTime",
                table: "Places");

            migrationBuilder.DropColumn(
                name: "OpenTime",
                table: "Places");

            migrationBuilder.AddColumn<string>(
                name: "OpenCloseTime",
                table: "Places",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

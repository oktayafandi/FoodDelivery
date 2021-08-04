using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class SomeColumnAddedIntoPlaceMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuCategories_PlaceMenus_PlaceMenuId",
                table: "MenuCategories");

            migrationBuilder.DropIndex(
                name: "IX_MenuCategories_PlaceMenuId",
                table: "MenuCategories");

            migrationBuilder.DropColumn(
                name: "PlaceMenuId",
                table: "MenuCategories");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Sliders",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "MenuCategoryId",
                table: "PlaceMenus",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MenuCategories",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.CreateIndex(
                name: "IX_PlaceMenus_MenuCategoryId",
                table: "PlaceMenus",
                column: "MenuCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlaceMenus_MenuCategories_MenuCategoryId",
                table: "PlaceMenus",
                column: "MenuCategoryId",
                principalTable: "MenuCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlaceMenus_MenuCategories_MenuCategoryId",
                table: "PlaceMenus");

            migrationBuilder.DropIndex(
                name: "IX_PlaceMenus_MenuCategoryId",
                table: "PlaceMenus");

            migrationBuilder.DropColumn(
                name: "MenuCategoryId",
                table: "PlaceMenus");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Sliders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MenuCategories",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "PlaceMenuId",
                table: "MenuCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MenuCategories_PlaceMenuId",
                table: "MenuCategories",
                column: "PlaceMenuId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuCategories_PlaceMenus_PlaceMenuId",
                table: "MenuCategories",
                column: "PlaceMenuId",
                principalTable: "PlaceMenus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

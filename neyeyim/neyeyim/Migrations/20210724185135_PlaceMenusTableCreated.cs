using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class PlaceMenusTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlaceMenus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceId = table.Column<int>(nullable: true),
                    MenuCategory = table.Column<string>(maxLength: 30, nullable: false),
                    FoodName = table.Column<string>(maxLength: 30, nullable: false),
                    FoodPrice = table.Column<decimal>(nullable: false),
                    FoodContent = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaceMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlaceMenus_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlaceMenus_PlaceId",
                table: "PlaceMenus",
                column: "PlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaceMenus");
        }
    }
}

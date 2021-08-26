using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class adProductId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "productId",
                table: "Orders",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "productId",
                table: "Orders");
        }
    }
}

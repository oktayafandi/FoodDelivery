using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class PlaceColumnAddedIntoOrders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PlaceId",
                table: "Orders",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaceId1",
                table: "Orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PlaceId1",
                table: "Orders",
                column: "PlaceId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Places_PlaceId1",
                table: "Orders",
                column: "PlaceId1",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Places_PlaceId1",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PlaceId1",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PlaceId1",
                table: "Orders");
        }
    }
}

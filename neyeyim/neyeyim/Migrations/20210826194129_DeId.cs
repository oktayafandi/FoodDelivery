using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class DeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Orderz");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_AppUserId",
                table: "Orderz",
                newName: "IX_Orderz_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orderz",
                table: "Orderz",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orderz_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orderz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orderz_AspNetUsers_AppUserId",
                table: "Orderz",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orderz_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orderz_AspNetUsers_AppUserId",
                table: "Orderz");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orderz",
                table: "Orderz");

            migrationBuilder.RenameTable(
                name: "Orderz",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_Orderz_AppUserId",
                table: "Orders",
                newName: "IX_Orders_AppUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_AspNetUsers_AppUserId",
                table: "Orders",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

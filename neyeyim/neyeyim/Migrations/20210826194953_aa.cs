using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class aa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orderz_OrderId",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderItems",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orderz_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orderz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orderz_OrderId",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orderz_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orderz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

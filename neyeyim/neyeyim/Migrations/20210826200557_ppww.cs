using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class ppww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orderz_OrderId",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderItems",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orderz_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orderz",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

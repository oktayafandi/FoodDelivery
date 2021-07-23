using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class JobadsTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaceId = table.Column<int>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    Position = table.Column<string>(maxLength: 30, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    Age = table.Column<string>(maxLength: 30, nullable: false),
                    Experience = table.Column<string>(maxLength: 30, nullable: false),
                    Education = table.Column<string>(maxLength: 30, nullable: false),
                    GeneralInfo = table.Column<string>(maxLength: 1000, nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    ContactPhone = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContactMail = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobads_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jobads_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobads_CategoryId",
                table: "Jobads",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobads_PlaceId",
                table: "Jobads",
                column: "PlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jobads");
        }
    }
}

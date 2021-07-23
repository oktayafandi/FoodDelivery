using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class SettingsTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactPhone = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InfoPhone = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ContactMail = table.Column<string>(maxLength: 50, nullable: false),
                    InfoMail = table.Column<string>(maxLength: 50, nullable: false),
                    Adress = table.Column<string>(maxLength: 50, nullable: false),
                    WorkTime = table.Column<string>(maxLength: 50, nullable: false),
                    InstagramUrl = table.Column<string>(maxLength: 500, nullable: false),
                    FacebookUrl = table.Column<string>(maxLength: 500, nullable: false),
                    TwitterUrl = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}

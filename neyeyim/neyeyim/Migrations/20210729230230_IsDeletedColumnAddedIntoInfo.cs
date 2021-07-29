﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace neyeyim.Migrations
{
    public partial class IsDeletedColumnAddedIntoInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Information",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Information");
        }
    }
}

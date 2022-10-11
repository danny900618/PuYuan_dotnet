using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PuYuan.Migrations
{
    public partial class addUserTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Recorded_at",
                table: "User",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Recorded_at",
                table: "User");
        }
    }
}

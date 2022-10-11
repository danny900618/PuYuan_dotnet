using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PuYuan.Migrations
{
    public partial class addA1cDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "A1c",
                table: "Medical");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "A1c",
                table: "Medical",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}

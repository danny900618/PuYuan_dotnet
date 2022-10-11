using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PuYuan.Migrations
{
    public partial class modUserDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recorded_at",
                table: "User",
                newName: "Created_at");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Created_at",
                table: "User",
                newName: "Recorded_at");
        }
    }
}

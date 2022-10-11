using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PuYuan.Migrations
{
    public partial class removeAccountIn3Db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Account",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "Account",
                table: "BloodSugar");

            migrationBuilder.DropColumn(
                name: "Account",
                table: "BloodPressure");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "Diary",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "BloodSugar",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Account",
                table: "BloodPressure",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}

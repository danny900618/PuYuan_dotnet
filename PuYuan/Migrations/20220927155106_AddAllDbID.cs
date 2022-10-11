using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PuYuan.Migrations
{
    public partial class AddAllDbID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Weight",
                table: "Weight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medical",
                table: "Medical");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diary",
                table: "Diary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BloodSugar",
                table: "BloodSugar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BloodPressure",
                table: "BloodPressure");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Weight",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Weight",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Medical",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Medical",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Friends",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Friends",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Diary",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Diary",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "BloodSugar",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "BloodSugar",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "BloodPressure",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "BloodPressure",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weight",
                table: "Weight",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medical",
                table: "Medical",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diary",
                table: "Diary",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BloodSugar",
                table: "BloodSugar",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BloodPressure",
                table: "BloodPressure",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Weight",
                table: "Weight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medical",
                table: "Medical");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Friends",
                table: "Friends");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Diary",
                table: "Diary");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BloodSugar",
                table: "BloodSugar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BloodPressure",
                table: "BloodPressure");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Weight");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Medical");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Friends");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "BloodSugar");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "BloodPressure");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Weight",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Medical",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Friends",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "Diary",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "BloodSugar",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Account",
                table: "BloodPressure",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weight",
                table: "Weight",
                column: "Account");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medical",
                table: "Medical",
                column: "Account");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Friends",
                table: "Friends",
                column: "Account");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Diary",
                table: "Diary",
                column: "Account");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BloodSugar",
                table: "BloodSugar",
                column: "Account");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BloodPressure",
                table: "BloodPressure",
                column: "Account");
        }
    }
}

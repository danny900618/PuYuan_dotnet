using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PuYuan.Migrations
{
    public partial class ModUserDb55 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodPressure",
                columns: table => new
                {
                    Account = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Systolic = table.Column<double>(type: "float", nullable: true),
                    Diastolic = table.Column<double>(type: "float", nullable: true),
                    Pulse = table.Column<int>(type: "int", nullable: true),
                    Recorded_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodPressure", x => x.Account);
                });

            migrationBuilder.CreateTable(
                name: "BloodSugar",
                columns: table => new
                {
                    Account = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sugar = table.Column<int>(type: "int", nullable: true),
                    timeperiod = table.Column<int>(type: "int", nullable: true),
                    Recorded_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodSugar", x => x.Account);
                });

            migrationBuilder.CreateTable(
                name: "Diary",
                columns: table => new
                {
                    Account = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Meal = table.Column<int>(type: "int", nullable: true),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<int>(type: "int", nullable: true),
                    Lat = table.Column<double>(type: "float", nullable: true),
                    Lng = table.Column<double>(type: "float", nullable: true),
                    Recorded_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diary", x => x.Account);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Account = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Invite_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relation_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Friend_type = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Read = table.Column<bool>(type: "bit", nullable: true),
                    Imread = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Account);
                });

            migrationBuilder.CreateTable(
                name: "Medical",
                columns: table => new
                {
                    Account = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A1c = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Diabetes_type = table.Column<int>(type: "int", nullable: true),
                    Oad = table.Column<bool>(type: "bit", nullable: true),
                    Insulin = table.Column<bool>(type: "bit", nullable: true),
                    Anti_hypertensives = table.Column<bool>(type: "bit", nullable: true),
                    Drugtype = table.Column<bool>(type: "bit", nullable: true),
                    Drugname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Recorded_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medical", x => x.Account);
                });

            migrationBuilder.CreateTable(
                name: "UserSet",
                columns: table => new
                {
                    Account = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sugar_delta_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sugar_delta_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sugar_morning_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sugar_morning_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sugar_evening_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sugar_evening_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sugar_before_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sugar_before_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sugar_after_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Sugar_after_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Systolic_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Systolic_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Diastolic_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Diastolic_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Pulse_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Pulse_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bmi_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Bmi_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Body_fat_max = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    body_fat_min = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    After_recording = table.Column<bool>(type: "bit", nullable: true),
                    No_recording_for_a_day = table.Column<bool>(type: "bit", nullable: true),
                    Over_max_or_under_min = table.Column<bool>(type: "bit", nullable: true),
                    After_meal = table.Column<bool>(type: "bit", nullable: true),
                    Unit_of_sugar = table.Column<bool>(type: "bit", nullable: true),
                    Unit_of_weight = table.Column<bool>(type: "bit", nullable: true),
                    Unit_of_height = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSet", x => x.Account);
                });

            migrationBuilder.CreateTable(
                name: "Weight",
                columns: table => new
                {
                    Account = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Uid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    Body_fat = table.Column<double>(type: "float", nullable: true),
                    Bmi = table.Column<double>(type: "float", nullable: true),
                    Recorded_at = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weight", x => x.Account);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BloodPressure");

            migrationBuilder.DropTable(
                name: "BloodSugar");

            migrationBuilder.DropTable(
                name: "Diary");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Medical");

            migrationBuilder.DropTable(
                name: "UserSet");

            migrationBuilder.DropTable(
                name: "Weight");
        }
    }
}

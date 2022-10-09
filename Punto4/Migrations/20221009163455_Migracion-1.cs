using Microsoft.EntityFrameworkCore.Migrations;

namespace Punto4.Migrations
{
    public partial class Migracion1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcademicRecord",
                columns: table => new
                {
                    RecordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(nullable: false),
                    FirstPeriodGrade = table.Column<double>(nullable: false),
                    SecondPeriodGrade = table.Column<double>(nullable: false),
                    ThirdPeriodGrade = table.Column<double>(nullable: false),
                    FourthPeriodGrade = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicRecord", x => x.RecordId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademicRecord");
        }
    }
}

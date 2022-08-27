using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADHD.Migrations
{
    public partial class AddIncorreceDatabse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiagnosedLevel",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "NoOfSymptomDetect",
                table: "SymptomScores",
                newName: "Score");

            migrationBuilder.AlterColumn<string>(
                name: "StudentId",
                table: "SymptomScores",
                type: "varchar(255)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DiagnosedLevel",
                table: "SymptomScores",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiagnosedLevel",
                table: "SymptomScores");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "SymptomScores",
                newName: "NoOfSymptomDetect");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "SymptomScores",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "DiagnosedLevel",
                table: "Reports",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}

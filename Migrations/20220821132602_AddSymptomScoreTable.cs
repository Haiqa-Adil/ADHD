using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADHD.Migrations
{
    public partial class AddSymptomScoreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SymptomScores",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SymptomId = table.Column<int>(type: "int", nullable: false),
                    StudentUserId = table.Column<int>(type: "int", nullable: false),
                    StudentGuidId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    DisorderId = table.Column<int>(type: "int", nullable: false),
                    NoOfSymptomDetect = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SymptomScores", x => new { x.StudentId, x.SymptomId });
                    table.ForeignKey(
                        name: "FK_SymptomScores_Disorders_DisorderId",
                        column: x => x.DisorderId,
                        principalTable: "Disorders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SymptomScores_Students_StudentUserId_StudentGuidId",
                        columns: x => new { x.StudentUserId, x.StudentGuidId },
                        principalTable: "Students",
                        principalColumns: new[] { "UserId", "GuidId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SymptomScores_Symptoms_SymptomId",
                        column: x => x.SymptomId,
                        principalTable: "Symptoms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_SymptomScores_DisorderId",
                table: "SymptomScores",
                column: "DisorderId");

            migrationBuilder.CreateIndex(
                name: "IX_SymptomScores_StudentUserId_StudentGuidId",
                table: "SymptomScores",
                columns: new[] { "StudentUserId", "StudentGuidId" });

            migrationBuilder.CreateIndex(
                name: "IX_SymptomScores_SymptomId",
                table: "SymptomScores",
                column: "SymptomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SymptomScores");
        }
    }
}

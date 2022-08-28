using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADHD.Migrations
{
    public partial class AddRefrenceToStudentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisorderResults_Users_UserId",
                table: "DisorderResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_UserId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_UserId",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisorderResults",
                table: "DisorderResults");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reports",
                newName: "StudentUserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "DisorderResults",
                newName: "StudentUserId");

            migrationBuilder.AddColumn<Guid>(
                name: "StudentGuidId",
                table: "Reports",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Reports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "DisorderResults",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "StudentGuidId",
                table: "DisorderResults",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisorderResults",
                table: "DisorderResults",
                columns: new[] { "StudentId", "SymptomQuestionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_StudentUserId_StudentGuidId",
                table: "Reports",
                columns: new[] { "StudentUserId", "StudentGuidId" });

            migrationBuilder.CreateIndex(
                name: "IX_DisorderResults_StudentUserId_StudentGuidId",
                table: "DisorderResults",
                columns: new[] { "StudentUserId", "StudentGuidId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DisorderResults_Students_StudentUserId_StudentGuidId",
                table: "DisorderResults",
                columns: new[] { "StudentUserId", "StudentGuidId" },
                principalTable: "Students",
                principalColumns: new[] { "UserId", "GuidId" },
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Students_StudentUserId_StudentGuidId",
                table: "Reports",
                columns: new[] { "StudentUserId", "StudentGuidId" },
                principalTable: "Students",
                principalColumns: new[] { "UserId", "GuidId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DisorderResults_Students_StudentUserId_StudentGuidId",
                table: "DisorderResults");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Students_StudentUserId_StudentGuidId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_StudentUserId_StudentGuidId",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisorderResults",
                table: "DisorderResults");

            migrationBuilder.DropIndex(
                name: "IX_DisorderResults_StudentUserId_StudentGuidId",
                table: "DisorderResults");

            migrationBuilder.DropColumn(
                name: "StudentGuidId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "DisorderResults");

            migrationBuilder.DropColumn(
                name: "StudentGuidId",
                table: "DisorderResults");

            migrationBuilder.RenameColumn(
                name: "StudentUserId",
                table: "Reports",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "StudentUserId",
                table: "DisorderResults",
                newName: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisorderResults",
                table: "DisorderResults",
                columns: new[] { "UserId", "SymptomQuestionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_UserId",
                table: "Reports",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DisorderResults_Users_UserId",
                table: "DisorderResults",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_UserId",
                table: "Reports",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

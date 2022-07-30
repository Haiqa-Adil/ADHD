using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ADHD.Migrations
{
    public partial class AddTeacherTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Consultants_ConsultantId",
                table: "MyProperty");

            migrationBuilder.DropForeignKey(
                name: "FK_MyProperty_Sessions_SessionId",
                table: "MyProperty");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty");

            migrationBuilder.RenameTable(
                name: "MyProperty",
                newName: "ConsultantSession");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_SessionId",
                table: "ConsultantSession",
                newName: "IX_ConsultantSession_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_MyProperty_ConsultantId",
                table: "ConsultantSession",
                newName: "IX_ConsultantSession_ConsultantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ConsultantSession",
                table: "ConsultantSession",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Grade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    NIC = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    School = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Place = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Province = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TeacherClasses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TeacherId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherClasses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherClasses_Classes_ClassId",
                        column: x => x.ClassId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeacherClasses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherClasses_ClassId",
                table: "TeacherClasses",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherClasses_TeacherId",
                table: "TeacherClasses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_UserId",
                table: "Teachers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultantSession_Consultants_ConsultantId",
                table: "ConsultantSession",
                column: "ConsultantId",
                principalTable: "Consultants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ConsultantSession_Sessions_SessionId",
                table: "ConsultantSession",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ConsultantSession_Consultants_ConsultantId",
                table: "ConsultantSession");

            migrationBuilder.DropForeignKey(
                name: "FK_ConsultantSession_Sessions_SessionId",
                table: "ConsultantSession");

            migrationBuilder.DropTable(
                name: "TeacherClasses");

            migrationBuilder.DropTable(
                name: "Classes");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ConsultantSession",
                table: "ConsultantSession");

            migrationBuilder.RenameTable(
                name: "ConsultantSession",
                newName: "MyProperty");

            migrationBuilder.RenameIndex(
                name: "IX_ConsultantSession_SessionId",
                table: "MyProperty",
                newName: "IX_MyProperty_SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_ConsultantSession_ConsultantId",
                table: "MyProperty",
                newName: "IX_MyProperty_ConsultantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyProperty",
                table: "MyProperty",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Consultants_ConsultantId",
                table: "MyProperty",
                column: "ConsultantId",
                principalTable: "Consultants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyProperty_Sessions_SessionId",
                table: "MyProperty",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

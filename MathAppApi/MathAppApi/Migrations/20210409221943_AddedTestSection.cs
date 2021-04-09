using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MathAppApi.Migrations
{
    public partial class AddedTestSection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestSections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TestId = table.Column<Guid>(type: "uuid", nullable: false),
                    PhotoId = table.Column<Guid>(type: "uuid", nullable: false),
                    Question = table.Column<string>(type: "text", nullable: true),
                    Solution1 = table.Column<string>(type: "text", nullable: true),
                    Solution2 = table.Column<string>(type: "text", nullable: true),
                    Solution3 = table.Column<string>(type: "text", nullable: true),
                    Solution4 = table.Column<string>(type: "text", nullable: true),
                    Answer = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestSections_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TestSections_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TestSections_PhotoId",
                table: "TestSections",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_TestSections_TestId",
                table: "TestSections",
                column: "TestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TestSections");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TerminologyDemo.Migrations
{
    public partial class seventh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectManagementUseraccount",
                columns: table => new
                {
                    ProjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ProjectName = table.Column<int>(nullable: false),
                    ProjectManagementProjectId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManagementUseraccount", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_ProjectManagementUseraccount_ProjectManagement_ProjectManagementProjectId",
                        column: x => x.ProjectManagementProjectId,
                        principalTable: "ProjectManagement",
                        principalColumn: "ProjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectManagementUseraccount_UserAccount_UserId",
                        column: x => x.UserId,
                        principalTable: "UserAccount",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementUseraccount_ProjectManagementProjectId",
                table: "ProjectManagementUseraccount",
                column: "ProjectManagementProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementUseraccount_UserId",
                table: "ProjectManagementUseraccount",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectManagementUseraccount");
        }
    }
}

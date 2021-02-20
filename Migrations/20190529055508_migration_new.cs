using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TerminologyDemo.Migrations
{
    public partial class migration_new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagementUseraccount_ProjectManagement_ProjectManagementProjectId",
                table: "ProjectManagementUseraccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectManagementUseraccount",
                table: "ProjectManagementUseraccount");

            migrationBuilder.DropIndex(
                name: "IX_ProjectManagementUseraccount_ProjectManagementProjectId",
                table: "ProjectManagementUseraccount");

            migrationBuilder.DropColumn(
                name: "ProjectManagementProjectId",
                table: "ProjectManagementUseraccount");

            migrationBuilder.DropColumn(
                name: "ProjectName",
                table: "ProjectManagementUseraccount");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "ProjectManagementUseraccount",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ProjectManagementUseraccountId",
                table: "ProjectManagementUseraccount",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectManagementUseraccount",
                table: "ProjectManagementUseraccount",
                column: "ProjectManagementUseraccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementUseraccount_ProjectId",
                table: "ProjectManagementUseraccount",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectManagementUseraccount_ProjectManagement_ProjectId",
                table: "ProjectManagementUseraccount",
                column: "ProjectId",
                principalTable: "ProjectManagement",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectManagementUseraccount_ProjectManagement_ProjectId",
                table: "ProjectManagementUseraccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProjectManagementUseraccount",
                table: "ProjectManagementUseraccount");

            migrationBuilder.DropIndex(
                name: "IX_ProjectManagementUseraccount_ProjectId",
                table: "ProjectManagementUseraccount");

            migrationBuilder.DropColumn(
                name: "ProjectManagementUseraccountId",
                table: "ProjectManagementUseraccount");

            migrationBuilder.AlterColumn<int>(
                name: "ProjectId",
                table: "ProjectManagementUseraccount",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "ProjectManagementProjectId",
                table: "ProjectManagementUseraccount",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectName",
                table: "ProjectManagementUseraccount",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProjectManagementUseraccount",
                table: "ProjectManagementUseraccount",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectManagementUseraccount_ProjectManagementProjectId",
                table: "ProjectManagementUseraccount",
                column: "ProjectManagementProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectManagementUseraccount_ProjectManagement_ProjectManagementProjectId",
                table: "ProjectManagementUseraccount",
                column: "ProjectManagementProjectId",
                principalTable: "ProjectManagement",
                principalColumn: "ProjectId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

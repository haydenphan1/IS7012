using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatPhant2.Migrations
{
    /// <inheritdoc />
    public partial class website : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Candidate",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JobTitleId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Company_IndustryId",
                table: "Company",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_IndustryId",
                table: "Candidate",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_JobTitleId",
                table: "Candidate",
                column: "JobTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Company_CompanyId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Company_IndustryId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_IndustryId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_JobTitleId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Company");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "IndustryId",
                table: "Candidate");

            migrationBuilder.DropColumn(
                name: "JobTitleId",
                table: "Candidate");
        }
    }
}

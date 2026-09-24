using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatPhant2.Migrations
{
    /// <inheritdoc />
    public partial class foreign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Company",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Candidate",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate",
                column: "JobTitleId",
                principalTable: "JobTitle",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company",
                column: "IndustryId",
                principalTable: "Industry",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_Industry_IndustryId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_JobTitleId",
                table: "Candidate");

            migrationBuilder.DropForeignKey(
                name: "FK_Company_Industry_IndustryId",
                table: "Company");

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Company",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IndustryId",
                table: "Candidate",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}

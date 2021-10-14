using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitCatNarangdk.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Industry",
                columns: table => new
                {
                    IndustryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryName = table.Column<string>(nullable: true),
                    IndustryLocation = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true),
                    EmailId = table.Column<string>(nullable: true),
                    IndustryFoundedDate = table.Column<DateTime>(nullable: true),
                    IsPrivate = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry", x => x.IndustryId);
                });

            migrationBuilder.CreateTable(
                name: "JobTitle",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobDescription = table.Column<string>(nullable: true),
                    MinSalary = table.Column<decimal>(nullable: false),
                    MaxSalary = table.Column<decimal>(nullable: false),
                    IsFullTime = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitle", x => x.JobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyPosition = table.Column<string>(nullable: true),
                    MinSalary = table.Column<decimal>(nullable: false),
                    MaxSalary = table.Column<decimal>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    Location = table.Column<long>(nullable: false),
                    IndustryId = table.Column<int>(nullable: false),
                    NumberOfCandidates = table.Column<int>(nullable: true),
                    CompanyNetWorth = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
                    table.ForeignKey(
                        name: "FK_Company_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "IndustryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    CandidateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    SocialSecurityNumber = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    TargetSalary = table.Column<decimal>(nullable: false),
                    JobTitleId = table.Column<int>(nullable: false),
                    PerformanceRating = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.CandidateId);
                    table.ForeignKey(
                        name: "FK_Candidate_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidate_Industry_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industry",
                        principalColumn: "IndustryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Candidate_JobTitle_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitle",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Company_IndustryId",
                table: "Company",
                column: "IndustryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "JobTitle");

            migrationBuilder.DropTable(
                name: "Industry");
        }
    }
}

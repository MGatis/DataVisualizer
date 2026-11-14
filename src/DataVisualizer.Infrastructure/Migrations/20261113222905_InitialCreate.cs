using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataVisualizer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ImportRuns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Source = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    RowsRead = table.Column<int>(type: "int", nullable: false),
                    RowsInserted = table.Column<int>(type: "int", nullable: false),
                    RowsUpdated = table.Column<int>(type: "int", nullable: false),
                    Error = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImportRuns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vacancies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VacancyNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UpdatedOn = table.Column<DateOnly>(type: "date", nullable: false),
                    EmployerRegistrationNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SalaryFrom = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    SalaryTo = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: true),
                    WorkloadType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    WorkTimeType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    HoursPerWeek = table.Column<decimal>(type: "decimal(5,2)", precision: 5, scale: 2, nullable: true),
                    ApplicationDeadline = table.Column<DateOnly>(type: "date", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Location = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DetailsUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    FirstImportedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastImportedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vacancies", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ImportRuns_Source_StartedAt",
                table: "ImportRuns",
                columns: new[] { "Source", "StartedAt" });

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_ApplicationDeadline",
                table: "Vacancies",
                column: "ApplicationDeadline");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_Category",
                table: "Vacancies",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_Vacancies_VacancyNumber",
                table: "Vacancies",
                column: "VacancyNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImportRuns");

            migrationBuilder.DropTable(
                name: "Vacancies");
        }
    }
}

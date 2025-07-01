using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleIT.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leads",
                columns: table => new
                {
                    QuoteSentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salesperson = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProjectCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leads");
        }
    }
}

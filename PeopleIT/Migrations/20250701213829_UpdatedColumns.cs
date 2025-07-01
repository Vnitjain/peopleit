using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PeopleIT.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomState",
                table: "Leads",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CustomerCity",
                table: "Leads",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MarketingCategory",
                table: "Leads",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NoOfQuotes",
                table: "Leads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "TotalNet",
                table: "Leads",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomState",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "CustomerCity",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "MarketingCategory",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "NoOfQuotes",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "TotalNet",
                table: "Leads");
        }
    }
}

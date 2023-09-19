using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.IssueManagement.Migrations
{
    /// <inheritdoc />
    public partial class Updatealltablelan1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "BookBorrows",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "BookBorrows");
        }
    }
}

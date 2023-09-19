using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.IssueManagement.Migrations
{
    /// <inheritdoc />
    public partial class UpdatetableBookBorrow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Static",
                table: "BookBorrows",
                newName: "Status");

            migrationBuilder.AlterColumn<decimal>(
                name: "FineAmount",
                table: "BookReturns",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "BookBorrows",
                newName: "Static");

            migrationBuilder.AlterColumn<decimal>(
                name: "FineAmount",
                table: "BookReturns",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);
        }
    }
}

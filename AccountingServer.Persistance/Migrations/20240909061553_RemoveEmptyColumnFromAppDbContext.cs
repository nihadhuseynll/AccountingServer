using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class RemoveEmptyColumnFromAppDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmptyColumn",
                table: "Companies");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmptyColumn",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

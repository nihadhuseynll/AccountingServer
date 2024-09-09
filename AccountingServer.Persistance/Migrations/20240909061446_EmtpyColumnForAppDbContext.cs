using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingServer.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class EmtpyColumnForAppDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmptyColumn",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmptyColumn",
                table: "Companies");
        }
    }
}

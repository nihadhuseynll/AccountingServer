using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccountingServer.Persistance.Migrations.CompanyDb
{
    /// <inheritdoc />
    public partial class RemovedCompanyIdFromUCAF : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "UCAF");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyId",
                table: "UCAF",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

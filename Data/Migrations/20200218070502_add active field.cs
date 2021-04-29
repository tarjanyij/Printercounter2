using Microsoft.EntityFrameworkCore.Migrations;

namespace Printercounter2.Data.Migrations
{
    public partial class addactivefield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Printers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Printers");
        }
    }
}

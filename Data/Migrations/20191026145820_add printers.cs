using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Printercounter2.Data.Migrations
{
    public partial class addprinters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Printers",
                columns: table => new
                {
                    ID_Printer = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IP_Printer = table.Column<string>(nullable: true),
                    Name_Printer = table.Column<string>(nullable: true),
                    Model_Printer = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    SN_Printer = table.Column<string>(nullable: true),
                    Barcode_Printer = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    TonerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Printers", x => x.ID_Printer);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Printers");
        }
    }
}

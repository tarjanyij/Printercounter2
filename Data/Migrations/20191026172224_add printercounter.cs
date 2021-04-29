using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Printercounter2.Data.Migrations
{
    public partial class addprintercounter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PrinterCounter",
                columns: table => new
                {
                    ID_Counter = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ID_Printer = table.Column<int>(nullable: false),
                    Counter = table.Column<int>(nullable: false),
                    TonerLevel = table.Column<int>(nullable: false),
                    Date_Counter = table.Column<DateTime>(nullable: false),
                    DailyPaperConsumption = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrinterCounter", x => x.ID_Counter);
                    table.ForeignKey(
                        name: "FK_PrinterCounter_Printers_ID_Printer",
                        column: x => x.ID_Printer,
                        principalTable: "Printers",
                        principalColumn: "ID_Printer",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PrinterCounter_ID_Printer",
                table: "PrinterCounter",
                column: "ID_Printer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrinterCounter");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Printercounter2.Data.Migrations
{
    public partial class addRepairReporttable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "InstallDate",
                table: "Printers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MachineId",
                table: "Printers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RepairReportList",
                columns: table => new
                {
                    RepairReportListID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PrinterID = table.Column<int>(nullable: false),
                    AnnouncementDate = table.Column<DateTime>(nullable: false),
                    RepairDate = table.Column<DateTime>(nullable: false),
                    ReportedError = table.Column<string>(nullable: true),
                    DetectedError = table.Column<string>(nullable: true),
                    WorkDescription = table.Column<string>(nullable: true),
                    UsedMaterials = table.Column<string>(nullable: true),
                    Administrator = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairReportList", x => x.RepairReportListID);
                    table.ForeignKey(
                        name: "FK_RepairReportList_Printers_PrinterID",
                        column: x => x.PrinterID,
                        principalTable: "Printers",
                        principalColumn: "PrinterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepairReportList_PrinterID",
                table: "RepairReportList",
                column: "PrinterID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepairReportList");

            migrationBuilder.DropColumn(
                name: "InstallDate",
                table: "Printers");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Printers");
        }
    }
}

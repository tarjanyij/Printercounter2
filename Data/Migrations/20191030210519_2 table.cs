using Microsoft.EntityFrameworkCore.Migrations;

namespace Printercounter2.Data.Migrations
{
    public partial class _2table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrinterCounter_Printers_ID_Printer",
                table: "PrinterCounter");

            migrationBuilder.RenameColumn(
                name: "TonerName",
                table: "Printers",
                newName: "PrinterTonerName");

            migrationBuilder.RenameColumn(
                name: "SN_Printer",
                table: "Printers",
                newName: "PrinterSN");

            migrationBuilder.RenameColumn(
                name: "Name_Printer",
                table: "Printers",
                newName: "PrinterName");

            migrationBuilder.RenameColumn(
                name: "Model_Printer",
                table: "Printers",
                newName: "PrinterModel");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Printers",
                newName: "PrinterLocation");

            migrationBuilder.RenameColumn(
                name: "IP_Printer",
                table: "Printers",
                newName: "PrinterIP");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Printers",
                newName: "PrinterDescription");

            migrationBuilder.RenameColumn(
                name: "Barcode_Printer",
                table: "Printers",
                newName: "PrinterBarcode");

            migrationBuilder.RenameColumn(
                name: "ID_Printer",
                table: "Printers",
                newName: "PrinterID");

            migrationBuilder.RenameColumn(
                name: "ID_Printer",
                table: "PrinterCounter",
                newName: "PrinterID");

            migrationBuilder.RenameColumn(
                name: "Counter",
                table: "PrinterCounter",
                newName: "PaperCounter");

            migrationBuilder.RenameColumn(
                name: "ID_Counter",
                table: "PrinterCounter",
                newName: "CounterID");

            migrationBuilder.RenameIndex(
                name: "IX_PrinterCounter_ID_Printer",
                table: "PrinterCounter",
                newName: "IX_PrinterCounter_PrinterID");

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterCounter_Printers_PrinterID",
                table: "PrinterCounter",
                column: "PrinterID",
                principalTable: "Printers",
                principalColumn: "PrinterID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrinterCounter_Printers_PrinterID",
                table: "PrinterCounter");

            migrationBuilder.RenameColumn(
                name: "PrinterTonerName",
                table: "Printers",
                newName: "TonerName");

            migrationBuilder.RenameColumn(
                name: "PrinterSN",
                table: "Printers",
                newName: "SN_Printer");

            migrationBuilder.RenameColumn(
                name: "PrinterName",
                table: "Printers",
                newName: "Name_Printer");

            migrationBuilder.RenameColumn(
                name: "PrinterModel",
                table: "Printers",
                newName: "Model_Printer");

            migrationBuilder.RenameColumn(
                name: "PrinterLocation",
                table: "Printers",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "PrinterIP",
                table: "Printers",
                newName: "IP_Printer");

            migrationBuilder.RenameColumn(
                name: "PrinterDescription",
                table: "Printers",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "PrinterBarcode",
                table: "Printers",
                newName: "Barcode_Printer");

            migrationBuilder.RenameColumn(
                name: "PrinterID",
                table: "Printers",
                newName: "ID_Printer");

            migrationBuilder.RenameColumn(
                name: "PrinterID",
                table: "PrinterCounter",
                newName: "ID_Printer");

            migrationBuilder.RenameColumn(
                name: "PaperCounter",
                table: "PrinterCounter",
                newName: "Counter");

            migrationBuilder.RenameColumn(
                name: "CounterID",
                table: "PrinterCounter",
                newName: "ID_Counter");

            migrationBuilder.RenameIndex(
                name: "IX_PrinterCounter_PrinterID",
                table: "PrinterCounter",
                newName: "IX_PrinterCounter_ID_Printer");

            migrationBuilder.AddForeignKey(
                name: "FK_PrinterCounter_Printers_ID_Printer",
                table: "PrinterCounter",
                column: "ID_Printer",
                principalTable: "Printers",
                principalColumn: "ID_Printer",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

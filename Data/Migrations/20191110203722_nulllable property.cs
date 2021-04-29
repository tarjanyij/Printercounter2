using Microsoft.EntityFrameworkCore.Migrations;

namespace Printercounter2.Data.Migrations
{
    public partial class nulllableproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TonerLevel",
                table: "PrinterCounter",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PaperCounter",
                table: "PrinterCounter",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DailyPaperConsumption",
                table: "PrinterCounter",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TonerLevel",
                table: "PrinterCounter",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaperCounter",
                table: "PrinterCounter",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DailyPaperConsumption",
                table: "PrinterCounter",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}

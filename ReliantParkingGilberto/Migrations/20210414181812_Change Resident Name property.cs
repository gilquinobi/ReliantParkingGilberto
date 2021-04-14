using Microsoft.EntityFrameworkCore.Migrations;

namespace ReliantParkingGilberto.Migrations
{
    public partial class ChangeResidentNameproperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Residents",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Residents",
                newName: "Name");
        }
    }
}

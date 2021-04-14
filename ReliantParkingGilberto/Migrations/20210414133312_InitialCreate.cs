using Microsoft.EntityFrameworkCore.Migrations;

namespace ReliantParkingGilberto.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResidentialPropertyTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentialPropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResidentialProperties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Bedrooms = table.Column<int>(type: "int", nullable: false),
                    ResidentialPropertyTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentialProperties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResidentialProperties_ResidentialPropertyTypes_ResidentialPropertyTypeId",
                        column: x => x.ResidentialPropertyTypeId,
                        principalTable: "ResidentialPropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Residents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ResidentialPropertyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Residents_ResidentialProperties_ResidentialPropertyId",
                        column: x => x.ResidentialPropertyId,
                        principalTable: "ResidentialProperties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResidentialProperties_ResidentialPropertyTypeId",
                table: "ResidentialProperties",
                column: "ResidentialPropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Residents_ResidentialPropertyId",
                table: "Residents",
                column: "ResidentialPropertyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Residents");

            migrationBuilder.DropTable(
                name: "ResidentialProperties");

            migrationBuilder.DropTable(
                name: "ResidentialPropertyTypes");
        }
    }
}

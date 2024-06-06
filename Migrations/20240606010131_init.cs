using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpenSea.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OceanObservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Temperature = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    Salinity = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    Oxygen = table.Column<float>(type: "BINARY_FLOAT", nullable: false),
                    PH = table.Column<float>(type: "BINARY_FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OceanObservations", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OceanObservations");
        }
    }
}

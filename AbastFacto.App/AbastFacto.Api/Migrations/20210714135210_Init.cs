using Microsoft.EntityFrameworkCore.Migrations;

namespace AbastFacto.Api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Factors",
                columns: table => new
                {
                    FactorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Metric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InputData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FactorType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factors", x => x.FactorId);
                });

            migrationBuilder.InsertData(
                table: "Factors",
                columns: new[] { "FactorId", "FactorType", "InfoType", "InputData", "LongName", "Metric", "Notes", "ShortName", "Source" },
                values: new object[,]
                {
                    { 1, 0, null, null, null, "$/Ha", null, "Costos Producción Cultivos", null },
                    { 2, 0, null, null, null, "$/Ha", null, "Precios de la tierra", null },
                    { 3, 0, null, null, null, "Ha", null, "Hectáreas Cultivadas", null },
                    { 4, 0, null, null, null, "Ha", null, "Disponibilidad de Terrenos", null },
                    { 5, 0, null, null, null, "Index NBI", null, "Calidad de Vida", null },
                    { 6, 0, null, null, null, "%", null, "Disponibilidad de Terrenos", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Factors");
        }
    }
}

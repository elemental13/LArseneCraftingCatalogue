using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LArseneCraftingCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class CreateMaterials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    MaterialId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Type = table.Column<string>(type: "TEXT", nullable: true),
                    HarvestTool = table.Column<string>(type: "TEXT", nullable: true),
                    Machinery = table.Column<string>(type: "TEXT", nullable: true),
                    Product = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    UnrefinedWeight = table.Column<double>(type: "REAL", nullable: true),
                    RefinedWeight = table.Column<double>(type: "REAL", nullable: true),
                    RefinedValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.MaterialId);
                });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "HarvestTool", "Machinery", "Name", "Product", "RefinedValue", "RefinedWeight", "Type", "UnrefinedWeight" },
                values: new object[,]
                {
                    { 1, "Blade", "Loom", "Cotton", "Cloth", "1cp", 0.040000000000000001, "Fibres", 0.050000000000000003 },
                    { 2, "Blade", "Loom", "Flax", "Cloth", "1cp", 0.040000000000000001, "Fibres", 0.050000000000000003 },
                    { 3, "Blade", "Loom", "Silk", "Cloth", "1sp", 0.040000000000000001, "Fibres", 0.050000000000000003 },
                    { 4, "Blade", "Loom", "Spidersilk", "Cloth", "10gp", 0.040000000000000001, "Fibres", 0.050000000000000003 },
                    { 5, "Pickaxe", "Smeltery", "Copper", "Ingots", "1cp", 0.02, "Ore", 0.080000000000000002 },
                    { 6, "Pickaxe", "Smeltery", "Iron", "Ingots", "1cp", 0.02, "Ore", 0.080000000000000002 },
                    { 7, "Pickaxe", "Smeltery", "Silver", "Ingots", "1sp", 0.02, "Ore", 0.080000000000000002 },
                    { 8, "Pickaxe", "Smeltery", "Gold", "Ingots", "1gp", 0.02, "Ore", 0.080000000000000002 },
                    { 9, "Pickaxe", "Smeltery", "Platinum", "Ingots", "10gp", 0.02, "Ore", 0.080000000000000002 },
                    { 10, "Pickaxe", "Smeltery", "Mithral", "Ingots", "10gp", 0.01, "Ore", 0.040000000000000001 },
                    { 11, "Pickaxe", "Smeltery", "Adamantine", "Ingots", "10gp", 0.050000000000000003, "Ore", 0.20000000000000001 },
                    { 12, "Axe", "Sawmill", "Basic Wood", "Planks or Poles", "1cp", 0.25, "Wood", 0.5 },
                    { 13, "Axe", "Sawmill", "Exotic Wood", "Planks or Poles", "1sp", 0.25, "Wood", 0.5 },
                    { 14, "Axe", "Sawmill", "Xyxlwood", "Planks or Poles", "10gp", 0.25, "Wood", 0.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materials");
        }
    }
}

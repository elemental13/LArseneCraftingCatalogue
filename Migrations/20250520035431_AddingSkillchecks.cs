using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LArseneCraftingCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class AddingSkillchecks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillChecks",
                columns: table => new
                {
                    SkillCheckId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatureType = table.Column<string>(type: "TEXT", nullable: true),
                    Skill = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillChecks", x => x.SkillCheckId);
                });

            migrationBuilder.InsertData(
                table: "SkillChecks",
                columns: new[] { "SkillCheckId", "CreatureType", "Skill" },
                values: new object[,]
                {
                    { 1, "Aberration", "Arcana" },
                    { 2, "Beast", "Survival" },
                    { 3, "Celestial", "Religion" },
                    { 4, "Construct", "Investigation" },
                    { 5, "Dragon", "Survival" },
                    { 6, "Elemental", "Arcana" },
                    { 7, "Fey", "Arcana" },
                    { 8, "Fiend", "Religion" },
                    { 9, "Giant", "Medicine" },
                    { 10, "Humanoid", "Medicine" },
                    { 11, "Monstrosity", "Survival" },
                    { 12, "Ooze", "Nature" },
                    { 13, "Plant", "Nature" },
                    { 14, "Undead", "Medicine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillChecks");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LArseneCraftingCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class FixingSlayingArrows : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 4,
                columns: new[] { "MonsterComponentId", "Name" },
                values: new object[] { 177, "Arrow of Ooze Slaying" });

            migrationBuilder.InsertData(
                table: "MagicItems",
                columns: new[] { "MagicItemId", "Attunement", "ItemValue", "MagicItemType", "MetaTag", "MonsterComponentId", "Name", "Rarity" },
                values: new object[,]
                {
                    { 472, null, "550gp", "ammunition", null, 4, "Arrow of Aberration Slaying", "V" },
                    { 473, null, "550gp", "ammunition", null, 21, "Arrow of Celestial Slaying", "V" },
                    { 474, null, "550gp", "ammunition", null, 37, "Arrow of Beast Slaying", "V" },
                    { 475, null, "550gp", "ammunition", null, 59, "Arrow of Construct Slaying", "V" },
                    { 476, null, "550gp", "ammunition", null, 74, "Arrow of Dragon Slaying", "V" },
                    { 477, null, "550gp", "ammunition", null, 93, "Arrow of Fey Slaying", "V" },
                    { 478, null, "550gp", "ammunition", null, 117, "Arrow of Fiend Slaying", "V" },
                    { 479, null, "550gp", "ammunition", null, 134, "Arrow of Giant Slaying", "V" },
                    { 480, null, "550gp", "ammunition", null, 142, "Arrow of Humanoid Slaying", "V" },
                    { 481, null, "550gp", "ammunition", null, 155, "Arrow of Monstrosity Slaying", "V" },
                    { 482, null, "550gp", "ammunition", null, 61, "Arrow of Construct Slaying", "V" },
                    { 483, null, "550gp", "ammunition", null, 182, "Arrow of Plant Slaying", "V" },
                    { 484, null, "550gp", "ammunition", null, 86, "Arrow of Elemental Slaying", "V" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 484);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 4,
                columns: new[] { "MonsterComponentId", "Name" },
                values: new object[] { 0, "Arrow of Slaying" });
        }
    }
}

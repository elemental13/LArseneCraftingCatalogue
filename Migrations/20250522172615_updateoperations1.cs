using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LArseneCraftingCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class updateoperations1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 44,
                column: "MonsterComponentId",
                value: 191);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 45,
                column: "MonsterComponentId",
                value: 191);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 46,
                column: "MonsterComponentId",
                value: 191);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 252,
                column: "MonsterComponentId",
                value: 182);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 257,
                column: "Name",
                value: "Beltof Dwavvenkind");

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 274,
                column: "Name",
                value: "Brooch of Shielding");

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 283,
                column: "MonsterComponentId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 284,
                column: "MonsterComponentId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 285,
                column: "Name",
                value: "Cape of the Mountebank");

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 289,
                column: "MonsterComponentId",
                value: 184);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 291,
                column: "Name",
                value: "Chime of Opening");

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 341,
                column: "MonsterComponentId",
                value: 191);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 44,
                column: "MonsterComponentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 45,
                column: "MonsterComponentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 46,
                column: "MonsterComponentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 252,
                column: "MonsterComponentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 257,
                column: "Name",
                value: "BeltofDwavvenkind");

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 274,
                column: "Name",
                value: "Brooch ofShielding");

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 283,
                column: "MonsterComponentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 284,
                column: "MonsterComponentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 285,
                column: "Name",
                value: "Cape ofthe Mountebank");

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 289,
                column: "MonsterComponentId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 291,
                column: "Name",
                value: "Chime ofOpening");

            migrationBuilder.UpdateData(
                table: "MagicItems",
                keyColumn: "MagicItemId",
                keyValue: 341,
                column: "MonsterComponentId",
                value: 0);
        }
    }
}

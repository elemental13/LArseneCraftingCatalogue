using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LArseneCraftingCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class fixtoolinweapons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 2,
                column: "ToolId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 6,
                column: "ToolId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 7,
                column: "ToolId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 8,
                column: "ToolId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 9,
                column: "ToolId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 11,
                column: "ToolId",
                value: 16);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 2,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 6,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 7,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 8,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 9,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 11,
                column: "ToolId",
                value: 0);
        }
    }
}

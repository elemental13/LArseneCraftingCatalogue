using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LArseneCraftingCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class fixtoolinweapons2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 12,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 17,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 40,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 41,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 44,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 45,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 46,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 47,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 48,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 49,
                column: "ToolId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 50,
                column: "ToolId",
                value: 17);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 12,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 17,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 40,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 41,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 44,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 45,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 46,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 47,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 48,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 49,
                column: "ToolId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 50,
                column: "ToolId",
                value: 0);
        }
    }
}

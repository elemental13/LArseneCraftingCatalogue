using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LArseneCraftingCatalogue.Migrations
{
    /// <inheritdoc />
    public partial class UpdateWeapons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 1,
                columns: new[] { "ItemValue", "MaterialCost", "Name", "Weight" },
                values: new object[] { "5 gp", "2 gp", "Claw*", "2 lb." });

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 2,
                columns: new[] { "Damage", "ItemValue", "MaterialCost", "ToolId", "Weight" },
                values: new object[] { "1d4 bl udgeoning", "1 sp", "3 cp", 0, "2 lb." });

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 3,
                columns: new[] { "ItemValue", "MaterialCost", "Weight" },
                values: new object[] { "2 gp", "7 sp", "1 lb." });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "WeaponId", "DC", "Damage", "ItemValue", "MaterialCost", "Name", "Properties", "TimeToCraft", "ToolId", "WeaponType", "Weight" },
                values: new object[,]
                {
                    { 4, "14", "1d8 bludgeoning", "2 sp", "7 cp", "Greatclub", "Two-handed", 0.5, 5, "Simple Melee Weapon", "10 lb." },
                    { 5, "14", "1d6 slashing", "5 gp", "2 gp", "Handaxe", "Light, thrown (range 20/60)", 3.0, 16, "Simple Melee Weapon", "2 lb." },
                    { 6, "14", "1d6 piercing", "1 gp", "3 sp", "Javelin", "Thrown (range 30/120)", 1.0, 0, "Simple Melee Weapon", "2 lb." },
                    { 7, "14", "1d4 bludgeoning", "2 gp", "7 sp", "Light hammer", "Light, thrown (range 20/60)", 1.0, 0, "Simple Melee Weapon", "2 lb." },
                    { 8, "14", "1d6 bludgeoning", "5 gp", "2 gp", "Mace", "", 3.0, 0, "Simple Melee Weapon", "4 lb." },
                    { 9, "14", "1d6 bludgeoning", "5 sp", "7 cp", "Quarterstaff", "Versatile (1d8)", 0.5, 0, "Simple Melee Weapon", "4 lb." },
                    { 10, "14", "1d4 slashing", "1 gp", "3 sp", "Sickle", "Light", 1.0, 16, "Simple Melee Weapon", "2 lb." },
                    { 11, "14", "1d6 piercing", "1 gp", "3 sp", "Spear", "Thrown (range 20/60), versatile (1d8)", 1.0, 0, "Simple Melee Weapon", "3 lb." },
                    { 12, "14", "1d8 piercing", "25 gp", "8 gp", "Crossbow, light", "Ammunition (range 80/320), loading, two-handed", 12.0, 0, "Simple Ranged Weapon", "5 lb." },
                    { 13, "14", "1d4 piercing", "1 sp", "3 cp", "Dart", "Finesse, thrown (range 20/60)", 1.0, 5, "Simple Ranged Weapon", "1/4 lb." },
                    { 14, "14", "1d6 piercing", "25 gp", "8 gp", "Shortbow", "Ammunition (range 80/320), two-handed", 12.0, 5, "Simple Ranged Weapon", "2 lb." },
                    { 15, "14", "1d4 bludgeoning", "1 sp", "3 cp", "Sling", "Ammunition (range 30/120)", 0.25, 1, "Simple Ranged Weapon", "" },
                    { 16, "14", "1d6 bludgeoning", "2 sp", "7 cp", "Slingshot*", "Ammunition (range 20/60), two handed", 0.5, 5, "Simple Ranged Weapon", "1/4 lb." },
                    { 17, "14", "1d8 piercing", "", "", "Tommybow, light*", "Ammunition (range 80/160), reload (x**), two-handed", 16.0, 0, "Simple Ranged Weapon", "7 lb." },
                    { 18, "17", "1d8 slashing", "10 gp", "3 gp", "Battleaxe", "Versatile (1d10)", 6.0, 16, "Martial Melee Weapon", "4 lb." },
                    { 19, "17", "1d8 bludgeoning", "10 gp", "3 gp", "Flail", "", 6.0, 16, "Martial Melee Weapon", "2 lb." },
                    { 20, "17", "1d10 slashing", "20 gp", "7 gp", "Glaive", "Heavy, reach, two-handed", 12.0, 16, "Martial Melee Weapon", "6 lb." },
                    { 21, "17", "1d12slashing", "30 gp", "10 gp", "Greataxe", "Heavy, two-handed", 18.0, 16, "Martial Melee Weapon", "7 lb." },
                    { 22, "17", "2d6 slashing", "50 gp", "17 gp", "Greatsword", "Heavy, two-handed", 24.0, 16, "Martial Melee Weapon", "6 lb." },
                    { 23, "17", "1d10 slashing", "20 gp", "7 gp", "Halberd", "Heavy, reach, two-handed", 12.0, 16, "Martial Melee Weapon", "6 lb." },
                    { 24, "17", "1d12 piercing", "10 gp", "3 gp", "Lance", "Reach, special", 6.0, 16, "Martial Melee Weapon", "6 lb." },
                    { 25, "17", "1d8 slashing", "15 gp", "5 gp", "Longsword", "Versatile (1d10)", 8.0, 16, "Martial Melee Weapon", "3 lb." },
                    { 26, "17", "2d6 bludgeoning", "10 gp", "3 gp", "Maul", "Heavy, two-handed", 6.0, 16, "Martial Melee Weapon", "10 lb." },
                    { 27, "17", "1d8 piercing", "10 gp", "3 gp", "Morningstar", "", 6.0, 16, "Martial Melee Weapon", "4 lb." },
                    { 28, "17", "1d6 bludgeoning", "10 gp", "3 gp", "Nunchuck*", "Finesse, versatile (1d8), special", 6.0, 16, "Martial Melee Weapon", "2 lb." },
                    { 29, "17", "1d10 piercing", "10 gp", "3 gp", "Pike", "Heavy, reach, two-handed", 6.0, 16, "Martial Melee Weapon", "18 lb." },
                    { 30, "17", "1d8 piercing", "25 gp", "8 gp", "Rapier", "Fi nesse", 12.0, 16, "Martial Melee Weapon", "2 lb." },
                    { 31, "17", "1d6 slashing", "10 gp", "3 gp", "Scimitar", "Finesse, light", 6.0, 16, "Martial Melee Weapon", "3 lb." },
                    { 32, "17", "1d6 piercing", "10 gp", "3 gp", "Shortsword", "Finesse, light", 6.0, 16, "Martial Melee Weapon", "2 lb." },
                    { 33, "17", "1d8 slashing", "15 gp", "5 gp", "Tetherhook*", "Reach, two-handed, special", 8.0, 16, "Martial Melee Weapon", "3 lb." },
                    { 34, "17", "1d6 piercing", "5 gp", "2 gp", "Tr1dent", "Thrown (range 20/60), versatile (1d8)", 3.0, 5, "Martial Melee Weapon", "4 lb." },
                    { 35, "17", "2d4 slashing", "50 gp", "17 gp", "Twinblade*", "Finesse, two-handed, special", 24.0, 16, "Martial Melee Weapon", "5 lb." },
                    { 36, "17", "1d8 piercing", "5 gp", "2 gp", "War pick", "", 3.0, 16, "Martial Melee Weapon", "2 lb." },
                    { 37, "17", "1d8 bludgeoning", "15 gp", "5 gp", "Warhammer", "Versatile (1d10)", 8.0, 16, "Martial Melee Weapon", "2 lb." },
                    { 38, "17", "1d4slashing", "2 gp", "7 sp", "Whip", "Finesse, reach", 1.0, 1, "Martial Melee Weapon", "3 lb." },
                    { 39, "17", "1 piercing", "10 gp", "3 gp", "Blowgun", "Ammunition (range 25/100), loading", 6.0, 5, "Martial Ranged Weapon", "1 lb." },
                    { 40, "17", "1d6 piercing", "75 gp", "25 gp", "Crossbow, hand", "Ammunition (range 30/120), light, loading", 40.0, 0, "Martial Ranged Weapon", "3 lb." },
                    { 41, "17", "1d10 piercing", "50 gp", "17 gp", "Crossbow, heavy", "Ammunition (range 100/400), heavy, loading, two-handed", 24.0, 0, "Martial Ranged Weapon", "18 lb." },
                    { 42, "17", "1d8 piercing", "50 gp", "17 gp", "Longbow", "Ammunition (range 150/600), heavy, two-handed", 18.0, 5, "Martial Ranged Weapon", "2 lb." },
                    { 43, "17", "", "1 gp", "3 sp", "Net", "Special, thrown (range 5/15)", 1.0, 18, "Martial Ranged Weapon", "3 lb." },
                    { 44, "17", "1d6 piercing", "", "", "Tommybow, hand*", "Ammunition (range 30/60), light, reload (x**)", 48.0, 0, "Martial Ranged Weapon", "4 lb." },
                    { 45, "17", "1d10 piercing", "", "", "Tommybow, heavy*", "Ammunition (range 100/200), heavy, reload (x**), two-handed", 32.0, 0, "Martial Ranged Weapon", "23 lb." },
                    { 46, "19", "3d4 piercing", "150 gp", "50 gp", "Blunderbuss*", "Ammunition (range 20/60), loud (1000), reload (1), two handed", 36.0, 0, "Magitech Firearm", "5 lb." },
                    { 47, "19", "1d10 piercing", "100 gp", "30 gp", "Musket*", "Ammunition (range 80/240), loud (1000), reload (1), two handed", 36.0, 0, "Magitech Firearm", "10 lb." },
                    { 48, "19", "1d8 piercing", "200 gp", "70 gp", "Pistol*", "Ammunition (range 40/120), loud (500), reload (2)", 48.0, 0, "Magitech Firearm", "2 lb." },
                    { 49, "19", "1d10 piercing", "750 gp", "250 gp", "Revolver*", "Ammunition (range 60/240), loud (500), reload (6)", 96.0, 0, "Magitech Firearm", "2 lb." },
                    { 50, "19", "1d12 piercing", "1,000 gp", "330 gp", "Rifle*", "Ammunition (range 120/480), loud (500), reload (6), two handed", 120.0, 0, "Magitech Firearm", "8 lb." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 50);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 1,
                columns: new[] { "ItemValue", "MaterialCost", "Name", "Weight" },
                values: new object[] { "5gp", "2gp", "Claw", "2lb" });

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 2,
                columns: new[] { "Damage", "ItemValue", "MaterialCost", "ToolId", "Weight" },
                values: new object[] { "1d4 bludgeoning", "1sp", "3cp", 5, "2lb" });

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 3,
                columns: new[] { "ItemValue", "MaterialCost", "Weight" },
                values: new object[] { "2gp", "7sp", "1lb" });
        }
    }
}

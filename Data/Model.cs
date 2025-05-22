using Microsoft.EntityFrameworkCore;

public class CraftingContext : DbContext
{
    public DbSet<Armor> Armors { get; set; }
    public DbSet<Tool> Tools { get; set; }
    public DbSet<Weapon> Weapons { get; set; }
    public DbSet<MonsterComponent> MonsterComponents { get; set; }
    public DbSet<MagicItem> MagicItems { get; set; }
    public DbSet<Essence> Essence { get; set;}
    public DbSet<SkillCheck> SkillChecks { get; set; }
    public DbSet<Material> Materials { get; set; }


    public string DbPath { get; }

    public CraftingContext(DbContextOptions<CraftingContext> options)
        : base(options)
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "crafting.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // build some lists
        var toolList = Operations.CreateTools();
        var armorList = Operations.CreateArmor(toolList);
        var weaponList = Operations.CreateWeapons(toolList);

        var monsterComponentList = Operations.CreateMonsterComponents();
        var magicItemList = Operations.CreateMagicItems(monsterComponentList);
        var essenseList = Operations.CreateEssences();
        var skillChecksList = Operations.CreateSkillChecks();
        var materialList = Operations.CreateMaterials();

        // seed the database with initial data, using HasData will make sure it only is created if it doesnt already exist
        modelBuilder.Entity<Tool>().HasData(toolList);
        modelBuilder.Entity<Armor>().HasData(armorList);
        modelBuilder.Entity<Weapon>().HasData(weaponList);
        modelBuilder.Entity<MonsterComponent>().HasData(monsterComponentList);
        modelBuilder.Entity<MagicItem>().HasData(magicItemList);
        modelBuilder.Entity<Essence>().HasData(essenseList);
        modelBuilder.Entity<SkillCheck>().HasData(skillChecksList);
        modelBuilder.Entity<Material>().HasData(materialList);
    }
}

public class Armor
{
    public int ArmorId { get; set; }
    public string? Name { get; set; }
    public string? MaterialCost { get; set; }
    public int ToolId { get; set; }
    public string? DC {get; set; }
    public int TimeToCraft { get; set; }
    public string? ItemValue { get; set; }
    public string? Weight { get; set; }
    public string? ArmorType { get; set; }
    public string? ArmorClass { get; set; }
    public string? StrengthRequirement { get; set; }
    public string? StealthModifier { get; set; }
}

public class Tool
{
    public int ToolId { get; set; }
    public string? Name { get; set; }
    public string? AbilityRequirement { get; set; }
    public string? ItemTypes { get; set; }
}

public class Weapon
{
    public int WeaponId { get; set; }
    public string? Name { get; set; }
    public string? MaterialCost { get; set; }
    public int ToolId { get; set; }
    public string? DC {get; set; }
    public double TimeToCraft { get; set; }
    public string? ItemValue { get; set; }
    public string? Weight { get; set; }
    public string? WeaponType { get; set; }
    public string? Damage { get; set; }
    public string? Properties { get; set; }
}

public class MagicItem
{
    public int MagicItemId { get; set; }
    public string? Name { get; set; }
    public string? MagicItemType { get; set; }
    public string? ItemValue { get; set; }
    public string? Rarity { get; set; }
    public string? Attunement { get; set; }
    public string? MetaTag { get; set; }
    public int MonsterComponentId { get; set; }
}

public class MonsterComponent
{
    public int MonsterComponentId { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public string? DC { get; set; }
}

public class Essence
{
    public int EssenceId { get; set; }
    public string? CreatureCR { get; set; }
    public string? DC { get; set; }
    public string? Name { get; set; }
    public string? ItemRarity { get; set; }
}

public class SkillCheck
{
    public int SkillCheckId { get; set; }
    public string? CreatureType { get; set; }
    public string? Skill { get; set; }
}

public class Material
{
    public int MaterialId { get; set; }
    public string? Type { get; set; }
    public string? HarvestTool { get; set; }
    public string? Machinery { get; set; }
    public string? Product { get; set; }
    public string? Name { get; set; }
    public double? UnrefinedWeight { get; set; }
    public double? RefinedWeight { get; set; }
    public string? RefinedValue { get; set; }
}
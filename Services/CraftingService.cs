namespace LArseneCraftingCatalogue.Services;

public class CraftingService(ILogger<CraftingService> logger)
{
    private readonly ILogger<CraftingService> _logger = logger;
    public CraftingContext? db;
    public MagicItem? CraftableItem = null;
    public CraftingHelper EnchantInfo = new CraftingHelper();
    public bool Forging = false;

    public MonsterComponent? GetMonsterComponent(int id)
    {
        return db?.MonsterComponents.ToList().Find(x => x.MonsterComponentId == id);
    }

    // check the item types to see which tool can manufacture this item
    public List<Tool>? GetToolsForItem(MagicItem? magicItem)
    {
        if (magicItem == null) return [];
        return db?.Tools.ToList().FindAll(x => x.ItemTypes?.Contains(magicItem?.MagicItemType ?? "notfound") ?? false) ?? null;
    }

    public string GetAbilityFromMonsterPart(MonsterComponent? component)
    {
        if (component == null) return "not found";
        var monsterType = component?.Type ?? "";
        return db?.SkillChecks.ToList().Find(x =>
        {
            if (x?.CreatureType != null)
            {
                return x.CreatureType.ToLower() == monsterType.ToLower();
            }
            else
            {
                return false;
            }
        })?.Skill ?? "not found";
    }

    public Essence? GetEssenceByRarity(string? rarity)
    {
        // cant be found? return the first one
        return db?.Essence.ToList().Find(x => x?.ItemRarity?.StartsWith(rarity ?? "xx") ?? false);
    }

    public double GetEnchantingHours(Essence? essence, string? attunement)
    {
        var weaponAttunement = attunement ?? "none";
        // consumables are shorter time
        var consumable = weaponAttunement.ToUpper().StartsWith("C");
        // if it needs attunement its a bit longer
        // if it says optional, lets make it attunement not required
        var attunementRequired = weaponAttunement.ToUpper().StartsWith("R") || weaponAttunement.ToUpper().StartsWith("O");

        // if no essence, assume common item
        if (essence == null) return attunementRequired ? 2 : (consumable ? .5 : 1);

        if (essence.ItemRarity == "Uncommon")
        {
            return attunementRequired ? 20 : (consumable ? 4 : 10);
        }
        if (essence.ItemRarity == "Rare")
        {
            return attunementRequired ? 80 : (consumable ? 20 : 40);
        }
        if (essence.ItemRarity == "Very Rare")
        {
            return attunementRequired ? 320 : (consumable ? 80 : 160);
        }
        if (essence.ItemRarity == "Legendary")
        {
            return attunementRequired ? 1280 : (consumable ? 320 : 640);
        }
        if (essence.ItemRarity == "Artifact")
        {
            return attunementRequired ? 200000 : (consumable ? 50000 : 100000);
        }
        // must just be a common item rarity which is probably no essense
        return attunementRequired ? 2 : (consumable ? .5 : 1);
    }

    public double CalculateDaysToComplete(int journeymen, int experts, int masters, double totalCraftHours)
    {   // days = H / (8 * (J + 2E + 3M))
        double daysToComplete = totalCraftHours / (8 * (journeymen + 2 * experts + 3 * masters));
        return daysToComplete;
    }

    public CraftingCosts CalculateCostsToComplete(int journeymen, int experts, int masters, double totalCraftHours)
    {
        // Total Cost -> C = (H / (J + 2E + 3M)) * (20J + 80E + 180M)
        // Individual Cost (expert for example) -> Ce = (300 / (J + 2E + 3M)) * 80E then multiply by how man E
        double costForJourneymen = totalCraftHours / (journeymen + 2 * experts + 3 * masters) * 20 * journeymen * journeymen;
        double costForExperts = totalCraftHours / (journeymen + 2 * experts + 3 * masters) * 80 * experts * experts;
        double costForMasters = totalCraftHours / (journeymen + 2 * experts + 3 * masters) * 180 * masters * masters;
        double costToComplete = costForJourneymen + costForExperts + costForMasters;
        return new CraftingCosts() { JourneymenCosts = costForJourneymen, ExpertsCosts = costForExperts, MastersCosts = costForMasters, TotalCosts = costToComplete };
    }

    public int GetEnchantingDC(Essence? essence)
    {

        // if no essence, assume common item
        if (essence == null) return 12;

        if (essence.ItemRarity == "Uncommon")
        {
            return 15;
        }
        if (essence.ItemRarity == "Rare")
        {
            return 18;
        }
        if (essence.ItemRarity == "Very Rare")
        {
            return 21;
        }
        if (essence.ItemRarity == "Legendary")
        {
            return 25;
        }
        if (essence.ItemRarity == "Artifact")
        {
            return 30;
        }
        // must just be a common item rarity which is probably no essense
        return 12;
    }
}
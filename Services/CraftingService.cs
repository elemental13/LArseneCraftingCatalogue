using Microsoft.EntityFrameworkCore;

namespace LArseneCraftingCatalogue.Services;

public class CraftingService(ILogger<CraftingService> logger)
{
    private readonly ILogger<CraftingService> _logger = logger;
    private readonly object _lock = new();
    public MagicItem? CraftableItem = null;
    public CraftingHelper EnchantInfo = new CraftingHelper();
    public bool Forging = false;
    public List<MonsterComponent> InventoryParts = [];
    public List<Material> InventoryMaterials = [];
    public List<MagicItem> InventoryMagicItems = [];

    public void ClearMonsterComponents()
    {
        lock (_lock)
        {
            InventoryParts.Clear();
        }

    }

    public void ClearMaterials()
    {
        lock (_lock)
        {
            InventoryMaterials.Clear();
        }

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

    public List<MonsterComponent> GetInventoryParts()
    {
        lock (_lock)
        {
            return InventoryParts ?? [];
        }
    }

    public void AddInventoryParts(MonsterComponent monsterComponent)
    {
        lock (_lock)
        {
            InventoryParts.Add(monsterComponent);
        }
    }

    public List<Material> GetInventoryMaterials()
    {
        lock (_lock)
        {
            return InventoryMaterials ?? [];
        }
    }

    public void AddInventoryMaterials(Material material)
    {
        lock (_lock)
        {
            InventoryMaterials.Add(material);
        }
    }

    public List<MagicItem> GetInventoryMagicItems()
    {
        lock (_lock)
        {
            return InventoryMagicItems ?? [];
        }
    }

    public void RemoveInventoryPart(int monsterPartId)
    {
        lock (_lock)
        {
            var item = InventoryParts?.First(x => x.MonsterComponentId == monsterPartId);
            if (item != null) InventoryParts?.Remove(item);
        }

    }
    
    public void RemoveInventoryMaterial(int materialId)
    {
        lock (_lock)
        {
            var item = InventoryMaterials?.First(x => x.MaterialId == materialId);
            if (item != null) InventoryMaterials?.Remove(item);
        }
        
    }
}
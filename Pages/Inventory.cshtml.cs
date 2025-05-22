using Newtonsoft.Json;
using LArseneCraftingCatalogue.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LArseneCraftingCatalogue.Pages;

public class InventoryModel : PageModel
{
    private readonly ILogger<InventoryModel> _logger;
    private readonly CraftingContext _db;
    private readonly CraftingService _craftingService;

    public InventoryModel(ILogger<InventoryModel> logger, CraftingContext db, CraftingService craftingService)
    {
        _logger = logger;
        _db = db;
        _craftingService = craftingService;
    }

    public IActionResult OnGetProcessRemovePart(int monsterPartId)
    {
        _craftingService.RemoveInventoryPart(monsterPartId); // called via method to be more thread safe

        var partialPage = new PartialViewResult
        {
            ViewName = "_InventoryMonsterPartPartial",
        };

        return partialPage;
    }

    public IActionResult OnGetProcessRemoveMaterial(int materialId)
    {
        _craftingService.RemoveInventoryMaterial(materialId);

        var partialPage = new PartialViewResult
        {
            ViewName = "_InventoryMaterialPartial",
        };

        return partialPage;
    }

    public async Task<IActionResult> OnGetProcessCraftingItem(int magicItemId)
    {
        var items = await GetCraftableItemsFromInventory();
        _craftingService.InventoryMagicItems = items;
        var partialPage = new PartialViewResult
        {
            ViewName = "_InventoryCraftingPartial",
        };

        return partialPage;
    }

    public async Task<IActionResult> OnGetProcessGetParts(string partsList)
    {
        var partList = JsonConvert.DeserializeObject<List<int>>(partsList ?? "[]");
        _craftingService.InventoryParts.Clear();

        foreach (var part in partList ?? [])
        {
            var monsterPart = (await _db.MonsterComponents.ToListAsync()).Find(x => x.MonsterComponentId == part);
            if (monsterPart != null) _craftingService.AddInventoryParts(monsterPart);
        }

        var partialPage = new PartialViewResult
        {
            ViewName = "_InventoryMonsterPartPartial",
        };

        return partialPage;
    }

    public IActionResult OnGetProcessGetMaterial(string materialsList)
    {
        var partList = JsonConvert.DeserializeObject<List<int>>(materialsList ?? "[]");
        _craftingService.ClearMaterials();

        foreach (var part in partList ?? [])
        {
            var material = _db.Materials.ToList().Find(x => x.MaterialId == part);
            if (material != null) _craftingService.AddInventoryMaterials(material);
        }

        var partialPage = new PartialViewResult
        {
            ViewName = "_InventoryMaterialPartial",
        };

        return partialPage;
    }

    public async Task<IActionResult> OnGetProcessGetMagicItems()
    {
        var items = await GetCraftableItemsFromInventory();
        _craftingService.InventoryMagicItems = items;

        var partialPage = new PartialViewResult
        {
            ViewName = "_InventoryCraftingPartial",
        };

        return partialPage;
    }

    public async Task<List<MagicItem>> GetCraftableItemsFromInventory()
    {

        var craftableList = new List<MagicItem>();

        foreach (var part in _craftingService.GetInventoryParts() ?? [])
        {
            var magicItemsWithPart = (await _db.MagicItems.ToListAsync()).FindAll(x => x.MonsterComponentId == part.MonsterComponentId);
            if (magicItemsWithPart != null) craftableList.AddRange(magicItemsWithPart);
        }

        return craftableList;
    }
}


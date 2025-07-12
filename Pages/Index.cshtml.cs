using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LArseneCraftingCatalogue.Pages;

public class IndexModel(ILogger<IndexModel> logger, CraftingContext db) : PageModel
{
    private readonly ILogger<IndexModel> _logger = logger;
    private readonly CraftingContext _db = db;

    public List<MagicItem> CraftableItems = db.MagicItems.ToList();

    public IActionResult OnGetProcessInput(string inputValue)
    {
        // empty the list
        CraftableItems = [];

        if (string.IsNullOrEmpty(inputValue))
        {
            CraftableItems = _db.MagicItems.ToList();
        }
        else
        {
            var monsterComponents = GetMonsterComponents(inputValue);

            foreach (var component in monsterComponents ?? [])
            {
                CraftableItems.AddRange(_db.MagicItems.ToList().FindAll(x => x.MonsterComponentId == component?.MonsterComponentId));
            }
        }
        ViewData["CraftableItems"] = CraftableItems;

        var partialPage = new PartialViewResult
        {
            ViewName = "_CraftableItemsPartial",
            ViewData = ViewData,
        };

        return partialPage;
    }

    public IActionResult OnGetProcessItemSearch(string inputValue)
    {
        // empty the list
        CraftableItems = [];

        if (string.IsNullOrEmpty(inputValue))
        {
            CraftableItems = _db.MagicItems.ToList();
        }
        else
        {
            CraftableItems = _db.MagicItems.ToList().FindAll(x => x.Name?.ToLower().Contains(inputValue.ToLower()) ?? false);
        }
        ViewData["CraftableItems"] = CraftableItems;

        var partialPage = new PartialViewResult
        {
            ViewName = "_CraftableItemsPartial",
            ViewData = ViewData,
        };

        return partialPage;
    }

    public List<MagicItem> GetCraftableItems()
    {
        return CraftableItems;
    }

    public List<MonsterComponent> GetMonsterComponents(string name)
    {
        return _db.MonsterComponents.ToList().FindAll(x => (x?.Name?.ToLower() ?? "").Contains(name.ToLower()));
    }

    public MonsterComponent? GetMonsterComponent(int id)
    {
        return _db.MonsterComponents.ToList().Find(x => x.MonsterComponentId == id);
    }
    
    public Material? GetMaterial(int id)
    {
        return _db.Materials.ToList().Find(x => x.MaterialId == id);
    }
}

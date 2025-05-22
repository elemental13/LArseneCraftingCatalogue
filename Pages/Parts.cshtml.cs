using LArseneCraftingCatalogue.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LArseneCraftingCatalogue.Pages;

public class PartModel : PageModel
{
    private readonly ILogger<PartModel> _logger;
    private readonly CraftingContext _db;
    private readonly CraftingService _craftingService;

    public PartModel(ILogger<PartModel> logger, CraftingContext db, CraftingService craftingService)
    {
        _logger = logger;
        _db = db;
        _craftingService = craftingService;
    }

    public List<MonsterComponent> GetPartList()
    {

        // now we can access the new data, look into data seeding tho
        var list = _db.MonsterComponents.ToList();
        // spread operator to collection
        return list;
    }

    public string GetPartName(int id)
    {
        return _db.MonsterComponents.ToList().Find(x => x.MonsterComponentId == id)?.Name ?? "";
    }

    public void OnGetProcessAddPart(int monsterPartId)
    {
        var monsterPart = _db.MonsterComponents.ToList().Find(x => x.MonsterComponentId == monsterPartId);;
        if (monsterPart != null) _craftingService.AddInventoryParts(monsterPart);
    }
}


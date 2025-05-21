using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LArseneCraftingCatalogue.Pages;

public class PartModel(ILogger<PartModel> logger, CraftingContext db) : PageModel
{
    private readonly ILogger<PartModel> _logger = logger;
    private readonly CraftingContext _db = db;

    public List<MonsterComponent> GetPartList()
    {

        // now we can access the new data, look into data seeding tho
        var list = _db.MonsterComponents.ToList();
        // spread operator to collection
        return list;
    }

    public string GetPartName(int id) {
        return _db?.MonsterComponents.ToList().Find(x => x.MonsterComponentId == id)?.Name ?? "";
    }
}


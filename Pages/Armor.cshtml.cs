using System.Data.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LArseneCraftingCatalogue.Pages;

public class ArmorModel(ILogger<ArmorModel> logger, CraftingContext db) : PageModel
{
    private readonly ILogger<ArmorModel> _logger = logger;
    private readonly CraftingContext _db = db;

    public List<Armor> GetArmorList()
    {
        // Operations.Initialize(_db);
        // _db.SaveChanges();

        // now we can access the new data, look into data seeding tho
        var list = _db.Armors.ToList();
        // spread operator to collection
        return list;
    }

    public string GetToolName(int id) {
        return _db?.Tools.ToList().Find(x => x.ToolId == id)?.Name ?? "";
    }
}


using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LArseneCraftingCatalogue.Pages;

public class WeaponModel(ILogger<WeaponModel> logger, CraftingContext db) : PageModel
{
    private readonly ILogger<WeaponModel> _logger = logger;
    private readonly CraftingContext _db = db;

    public List<Weapon> GetWeaponList()
    {

        // now we can access the new data, look into data seeding tho
        var list = _db.Weapons.ToList();
        // spread operator to collection
        return list;
    }

    public string GetWeaponName(int id)
    {
        return _db?.Weapons.ToList().Find(x => x.WeaponId == id)?.Name ?? "";
    }
    
    public string GetToolName(int id)
    {
        return _db?.Tools.ToList().Find(x => x.ToolId == id)?.Name ?? "";
    }
}


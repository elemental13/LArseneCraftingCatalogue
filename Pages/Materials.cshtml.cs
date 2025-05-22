using LArseneCraftingCatalogue.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LArseneCraftingCatalogue.Pages;

public class MaterialModel(ILogger<MaterialModel> logger, CraftingContext db, CraftingService craftingService) : PageModel
{
    private readonly ILogger<MaterialModel> _logger = logger;
    private readonly CraftingContext _db = db;
    private readonly CraftingService _craftingService = craftingService;

    public List<Material> GetMaterialList()
    {

        // now we can access the new data, look into data seeding tho
        var list = _db.Materials.ToList();
        // spread operator to collection
        return list;
    }

    public string GetMaterialName(int id)
    {
        return _db?.Materials.ToList().Find(x => x.MaterialId == id)?.Name ?? "";
    }

    public void OnGetProcessAddMaterial(int monsterMaterialId)
    {
        var material = _db.Materials.ToList().Find(x => x.MaterialId == monsterMaterialId);
        if (material != null) _craftingService.AddInventoryMaterials(material);
    }
}


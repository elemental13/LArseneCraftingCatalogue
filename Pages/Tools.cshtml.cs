using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LArseneCraftingCatalogue.Pages;

public class ToolModel(ILogger<ToolModel> logger, CraftingContext db) : PageModel
{
    private readonly ILogger<ToolModel> _logger = logger;
    private readonly CraftingContext _db = db;

    public List<Tool> GetToolList()
    {

        // now we can access the new data, look into data seeding tho
        var list = _db.Tools.ToList();
        // spread operator to collection
        return list;
    }

    public string GetToolName(int id) {
        return _db?.Tools.ToList().Find(x => x.ToolId == id)?.Name ?? "";
    }
}


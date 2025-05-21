using LArseneCraftingCatalogue.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LArseneCraftingCatalogue.Pages;

public class CraftingCalculatorModel : PageModel
{
    private readonly ILogger<CraftingCalculatorModel> _logger;
    private readonly CraftingContext _db;
    private readonly CraftingService _craftingService;

    public CraftingCalculatorModel(ILogger<CraftingCalculatorModel> logger, CraftingContext db, CraftingService craftingService)
    {
        _logger = logger;
        _db = db;
        _craftingService = craftingService;
        _craftingService.db = _db;
    }

    public IActionResult OnGetProcessInput(string inputValue)
    {
        // empty the list
        _craftingService.CraftableItem = null;

        if (inputValue == null) return new JsonResult("not found");

        _craftingService.CraftableItem = this._db.MagicItems.ToList().Find(x => x.Name?.ToLower().Contains(inputValue.ToLower()) ?? false);

        ViewData["CraftableItem"] = _craftingService.CraftableItem;

        var partialPage = new PartialViewResult
        {
            ViewName = "_CraftableItemPartial",
            ViewData = ViewData,
        };

        return partialPage;
    }

    public IActionResult OnGetProcessCrafters(string journeymen, string experts, string masters)
    {
        Console.WriteLine("received input: ", new { journeymen, experts, masters });

        _craftingService.EnchantInfo.Journeymen = int.Parse(journeymen ?? "0");
        _craftingService.EnchantInfo.Experts = int.Parse(experts ?? "0");
        _craftingService.EnchantInfo.Masters = int.Parse(masters ?? "0");

        // you can enchant, or you can forge: forging doesnt require magical skills, while enchanting does (but requires the base item)
        var manufacturingTools = _craftingService.GetToolsForItem(_craftingService.CraftableItem);
        _craftingService.EnchantInfo.AvailableTools = manufacturingTools;

        var monsterComponent = _craftingService.GetMonsterComponent(_craftingService.CraftableItem?.MonsterComponentId ?? 0);

        _craftingService.EnchantInfo.Ability = _craftingService.GetAbilityFromMonsterPart(monsterComponent);
        _craftingService.EnchantInfo.Forging = _craftingService.Forging; // if the checkbox was last checked

        ViewData["EnchantInfo"] = _craftingService.EnchantInfo;

        var partialPage = new PartialViewResult
        {
            ViewName = "_CalculateCraftPartial",
            ViewData = ViewData,
        };

        return partialPage;
    }

    public IActionResult OnGetProcessCheckbox(bool checkboxValue)
    {
        _craftingService.Forging = checkboxValue;
        return new JsonResult("checkbox checked");
    }
}
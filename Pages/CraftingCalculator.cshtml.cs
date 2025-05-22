using LArseneCraftingCatalogue.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LArseneCraftingCatalogue.Pages;

public class CraftingCalculatorModel : PageModel
{
    private readonly ILogger<CraftingCalculatorModel> _logger;
    private readonly CraftingContext _db;
    private readonly CraftingService _craftingService;
    // routing parameter
    public int? PartToCraft { get; set; }
    public void OnGet(int partToCraft)
    {
        PartToCraft = partToCraft;
    }

    public CraftingCalculatorModel(ILogger<CraftingCalculatorModel> logger, CraftingContext db, CraftingService craftingService)
    {
        _logger = logger;
        _db = db;
        _craftingService = craftingService;
    }

    public IActionResult OnGetProcessInput(string inputValue)
    {
        // empty the list
        // _craftingService.CraftableItem = null;

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

    public IActionResult OnGetProcessRouteData()
    {
        ViewData["CraftableItem"] = _craftingService.CraftableItem;

        var partialPage = new PartialViewResult
        {
            ViewName = "_CraftableItemPartial",
            ViewData = ViewData,
        };

        return partialPage;
    }

    public async Task<IActionResult> OnGetProcessCrafters(string journeymen, string experts, string masters)
    {
        Console.WriteLine("received input: ", new { journeymen, experts, masters });

        _craftingService.EnchantInfo.Journeymen = int.Parse(journeymen ?? "0");
        _craftingService.EnchantInfo.Experts = int.Parse(experts ?? "0");
        _craftingService.EnchantInfo.Masters = int.Parse(masters ?? "0");

        // you can enchant, or you can forge: forging doesnt require magical skills, while enchanting does (but requires the base item)
        var manufacturingTools = await GetToolsForItem(_craftingService.CraftableItem);
        _craftingService.EnchantInfo.AvailableTools = manufacturingTools;

        var monsterComponent = _db.MonsterComponents.ToList().Find(x => x.MonsterComponentId == (_craftingService.CraftableItem?.MonsterComponentId ?? 0));

        _craftingService.EnchantInfo.Ability = await GetAbilityFromMonsterPart(monsterComponent);
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

    public async Task<string> GetAbilityFromMonsterPart(MonsterComponent? component)
    {

        if (component == null) return "not found";
        var monsterType = component?.Type ?? "";
        return (await _db.SkillChecks.ToListAsync()).Find(x =>
        {
            if (x?.CreatureType != null)
            {
                return x.CreatureType.ToLower() == monsterType.ToLower();
            }
            else
            {
                return false;
            }
        })?.Skill ?? "not found";

    }

    // check the item types to see which tool can manufacture this item
    public async Task<List<Tool>?> GetToolsForItem(MagicItem? magicItem)
    {
        if (magicItem == null) return [];
        return (await _db.Tools.ToListAsync()).FindAll(x => x.ItemTypes?.Contains(magicItem?.MagicItemType ?? "notfound") ?? false) ?? null;
    }
}
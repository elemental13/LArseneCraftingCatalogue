public class CraftingHelper
{
    public int Journeymen { get; set; }
    public int Experts { get; set; }
    public int Masters { get; set; }
    public List<Tool>? AvailableTools { get; set; }
    public string? Ability { get; set; }
    public int Hours { get; set; }
    public bool Forging { get; set; }
}

public class CraftingCosts
{
    public double JourneymenCosts { get; set; }
    public double ExpertsCosts { get; set; }
    public double MastersCosts { get; set; }
    public double TotalCosts { get; set; }
}
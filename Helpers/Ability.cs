public class Ability
{
    private Ability(string value) { Value = value; }

    public string Value { get; private set; }

    public static Ability Dexterity   { get { return new Ability("Dexterity"); } }
    public static Ability Strength   { get { return new Ability("Strength"); } }
    public static Ability Constitution    { get { return new Ability("Constitution"); } }
    public static Ability Intelligence { get { return new Ability("Intelligence"); } }
    public static Ability Wisdom   { get { return new Ability("Wisdom"); } }
    public static Ability Charisma   { get { return new Ability("Charisma"); } }

    public override string ToString()
    {
        return Value;
    }
}
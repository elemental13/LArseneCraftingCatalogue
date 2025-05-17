// money class which can be used to add together
public class Coins
{
    public enum CoinType
    {
        Copper = 1,
        Silver = 2,
        Gold = 3,
        Platinum = 4,
    }

    private readonly Dictionary<CoinType, long> value;

    public long Platinum { get { return value[CoinType.Platinum]; } }
    public long Gold { get { return value[CoinType.Gold]; } }
    public long Silver { get { return value[CoinType.Silver]; } }
    public long Copper { get { return value[CoinType.Copper]; } }

    public Coins(long platinum = 0, long gold = 0, long silver = 0, long copper = 0)
    {
        value = new Dictionary<CoinType, long>
        {
            { CoinType.Platinum, platinum },
            { CoinType.Gold, gold },
            { CoinType.Silver, silver },
            { CoinType.Copper, copper }
        };
    }

    public void Exchange(CoinType fromType, CoinType toType, long amountOfFromType)
    {
        if (fromType == toType)
            return;

        var fromTypeAmount = value[fromType];
        if (amountOfFromType > fromTypeAmount)
            throw new InvalidOperationException("Not enough money");

        if (fromType > toType)
        {
            value[toType] += amountOfFromType * (long) Math.Pow(100, (int)fromType - (int)toType);               
        }
        else
        {
            var overflow = amountOfFromType % 100;
            amountOfFromType -= overflow;
            value[toType] += amountOfFromType / (long) Math.Pow(100, (int)toType - (int)fromType);                               
        }

        value[fromType] -= amountOfFromType;         
    }

    // Add current coints to existing coins
    public Coins Add(Coins coins)
    {
        value[CoinType.Platinum] += coins.Platinum;
        value[CoinType.Gold] += coins.Gold;
        value[CoinType.Silver] += coins.Silver;
        value[CoinType.Copper] += coins.Copper;

        return this;
    }

    // Add specific coin type
    public Coins Add(CoinType coinType, long amount)
    {
        value[coinType] += amount;

        return this;
    }

    // Subtract to existing coins
    public Dictionary<CoinType, long> Subtract(Coins coins)
    {
        value[CoinType.Platinum] -= coins.Platinum;
        value[CoinType.Gold] -= coins.Gold;
        value[CoinType.Silver] -= coins.Silver;
        value[CoinType.Copper] -= coins.Copper;

        return value;
    }

    // Write the coins value to string: 5pp 2gp 3sp 50cp
    public override string ToString()
    {
        var result = "";

        if (Platinum > 0) result += $"{Platinum}pp";
        if (Gold > 0) result += $"{((result.Length > 0) ? " " : "")}{Gold}gp";
        if (Silver > 0) result += $"{((result.Length > 0) ? " " : "")}{Silver}sp";
        if (Copper > 0) result += $"{((result.Length > 0) ? " " : "")}{Copper}cp";
        return result;
    }

    // Make an attempt to parse a string value pack into Coins, written like so: 5pp 2gp 3sp 50cp
    public Coins? TryParse(string valueStr)
    {
        var result = new Coins();

        try 
        {
            // split the amounts by spaces
            var coinAmounts = valueStr.Split(' ');
            // return null if there is nothing to parse
            if (coinAmounts.Length <= 0) return null;

            foreach (var amount in coinAmounts ?? Array.Empty<string>())
            {
                // seperate the numbers from the string characters (55gp or 20cp)
                var digits = amount.Where(x => char.IsDigit(x));
                var alphas = amount.Where(x => !char.IsDigit(x));

                if (alphas.ToString() == "pp" ) result.Add(CoinType.Platinum, long.Parse(digits.ToString() ?? "0"));
                if (alphas.ToString() == "gp" ) result.Add(CoinType.Gold, long.Parse(digits.ToString() ?? "0"));
                if (alphas.ToString() == "sp" ) result.Add(CoinType.Silver, long.Parse(digits.ToString() ?? "0"));
                if (alphas.ToString() == "cp" ) result.Add(CoinType.Copper, long.Parse(digits.ToString() ?? "0"));            
            }

            return result;
        } 
        catch (Exception ex)
        {
            Console.WriteLine("Error when trying to parse coins, something incorrect in string value: " + valueStr);
            Console.WriteLine(ex.Message);
            return result;
        }
    }
}
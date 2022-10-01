namespace task03;

public class CurrencyRUB : Currency
{
    public static decimal EurToRub { get; set; }
    public static decimal UsdToRub { get; set; }

    public static implicit operator CurrencyRUB(CurrencyEUR x)
    {
        return new CurrencyRUB { Value = EurToRub * x.Value };
    }
    public static implicit operator CurrencyRUB(CurrencyUSD x)
    {
        return new CurrencyRUB { Value = UsdToRub * x.Value };
    }

}
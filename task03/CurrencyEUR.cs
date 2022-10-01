namespace task03;

public class CurrencyEUR : Currency
{
    public static decimal RubToEur { get; set; }
    public static decimal UsdToEur { get; set; }

    public static implicit operator CurrencyEUR(CurrencyRUB x)
    {
        return new CurrencyEUR { Value = RubToEur * x.Value };
    }
    public static implicit operator CurrencyEUR(CurrencyUSD x)
    {
        return new CurrencyEUR { Value = UsdToEur * x.Value };
    }

}
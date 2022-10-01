namespace task03;

public class CurrencyUSD : Currency
{
    public static decimal RubToUsd { get; set; }
    public static decimal EurToUsd { get; set; }

    public static implicit operator CurrencyUSD(CurrencyRUB x)
    {
        return new CurrencyUSD { Value = RubToUsd * x.Value };
    }
    public static implicit operator CurrencyUSD(CurrencyEUR x)
    {
        return new CurrencyUSD { Value = EurToUsd * x.Value };
    }

}
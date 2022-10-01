using System.Threading.Channels;

namespace task03;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму RUB за 1 USD");
        var UsdToRub = decimal.Parse(Console.ReadLine());
        CurrencyRUB.UsdToRub = UsdToRub;
        CurrencyUSD.RubToUsd = 1 / UsdToRub;
        Console.WriteLine("Введите сумму RUB за 1 EUR");
        var EurToRub = decimal.Parse(Console.ReadLine());
        CurrencyRUB.EurToRub = EurToRub;
        CurrencyEUR.RubToEur = 1 / EurToRub;
        CurrencyUSD.EurToUsd = EurToRub / UsdToRub;
        CurrencyEUR.UsdToEur = UsdToRub / EurToRub;
        Console.WriteLine("Введите сумму и валюту(usd/eur/rub):");
        var inp = Console.ReadLine().Split(' ');
        switch (inp[1])
        {
            case "usd":
                var usd = new CurrencyUSD();
                usd.Value = decimal.Parse(inp[0]);
                Console.WriteLine($"В рублях: {((CurrencyRUB)usd).Value}");
                Console.WriteLine($"В евро: {((CurrencyEUR)usd).Value}");
                break;
            case "eur":
                var eur = new CurrencyEUR();
                eur.Value = decimal.Parse(inp[0]);
                Console.WriteLine($"В рублях: {((CurrencyRUB)eur).Value}");
                Console.WriteLine($"В долларах: {((CurrencyUSD)eur).Value}");
                break;
            case "rub":
                var rub = new CurrencyRUB();
                rub.Value = decimal.Parse(inp[0]);
                Console.WriteLine($"В евро: {((CurrencyEUR)rub).Value}");
                Console.WriteLine($"В долларах: {((CurrencyUSD)rub).Value}");
                break;
            default:
                break;
                
        }
    }
}
    

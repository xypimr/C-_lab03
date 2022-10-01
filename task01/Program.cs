namespace task01;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var v1 = new Vector(1, 1, 1);
        var v2 = new Vector(2, 2, 2);
        var v3 = v1 + v2;
        var v4 = v1 * 2;
        var v5 = v1 * v2;
        if ((v1 != v2) && (v3 > v5) && (v4 == v2) && (v1 < v4))
        {
            Console.WriteLine("Всё работает!");
        }

    }
}
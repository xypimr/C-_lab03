namespace task02;

public class CarsCatalog
{
    public List<Car> myCars { get; set; }

    public string this[int index]
    {
        get
        {
            return $"{myCars[index].Name} has {myCars[index].Engine} engine!";
        }
    }
}
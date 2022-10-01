namespace task02;

public class Car :IEquatable<Car>
{
    public string? Name {get; set;}
    public string? Engine {get; set; }
    public int? speed {get; set; }

    public bool Equals(Car? other)
    {
        if (this.Name == other.Name && this.Engine == other.Engine && this.speed == other.speed)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return Name;
    }  
}

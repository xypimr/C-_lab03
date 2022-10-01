namespace task01;

public struct Vector
{
    private double X, Y, Z;

    public Vector(double x, double y, double z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector operator +(Vector v1, Vector v2)
    {
        return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
    }

    public static Vector operator *(Vector a, Vector b)
    {
        return new Vector(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
    }

    public static Vector operator *(Vector a, int b)
    {
        return new Vector(a.X * b, a.Y * b, a.Z * b);
    }

    decimal Len()
    {
        return Convert.ToDecimal(Math.Sqrt(X * X + Y * Y + Z * Z));
    }

    public static bool operator >(Vector a, Vector b)
    {
        return a.Len() > b.Len();
    }

    public static bool operator <(Vector a, Vector b)
    {
        return a.Len() < b.Len();
    }

    public static bool operator ==(Vector a, Vector b)
    {
        return a.Len() == b.Len();
    }

    public static bool operator !=(Vector a, Vector b)
    {
        return a.Len() != b.Len();
    }
}

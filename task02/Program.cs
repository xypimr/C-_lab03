namespace task02;

class Program
{
    static void Main()
    {
        Car car1 = new Car();
        car1.Name = "Toyota Mark 2 100";
        car1.Engine = "2jz-ge";
        car1.speed = 300;
        Car car2 = new Car();
        car2.Name = "Porshe 911 turbo S";
        car2.Engine = "2.9-liter V6";
        car2.speed = 250;
        Car car3 = new Car();
        car3.Name = "Mercedes e63s AMG";
        car3.Engine = "4.0-litre V8 twin-turbo";
        car3.speed = 270;
        
        CarsCatalog garage = new CarsCatalog();
        garage.myCars = new List<Car> {car1, car2, car3};
        
        for (int i = 0; i < garage.myCars.Count; i++)
        {
            Console.WriteLine(garage[i]);
        }
    }
}
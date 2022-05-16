using System;

class Program
{
    static void Main()
    {
        MercedesSportsCar myDreamCar = new MercedesSportsCar();
    }
}

class Car
{
    public Car()
    {
        Console.WriteLine("Car Constructor sætter 4 hjul på!");
    }
}

class SportsCar : Car
{
    public SportsCar()
    {
        Console.WriteLine("SportsCar Constructor sætter hækspoiler på!");
    }
}

class MercedesSportsCar : SportsCar
{
    public MercedesSportsCar()
    {
        Console.WriteLine("MercedesSportsCar Constructor sætter Mercedes stjernen på!");
    }
}
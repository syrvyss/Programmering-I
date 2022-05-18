// Validering.cs
// Opgaven bygger videre på den foregående.
// Nu skal der indbygges en validering i constructorerne, der forhindre ulovlige værdier:
//   - kmStand kan ikke være negativ og må ikke overstige 1 000 000 km. Udskriv fejlmeddelelse
//     hvis værdien falder udenfor.
//   - Programmet sørger selv for at runde kmStand værdien ned til nærmeste værdi delelig med 1000.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Car aygo = new Car(Color.Yellow, 1200, 100);
        Console.WriteLine("Loaded aygo Color.Yellow, 1200, 100: Result({0})", aygo.GetData());

        Car ferrari = new Car(Color.Red, 22000);
        Console.WriteLine("Loaded ferrari Color.Red, 22000: Result({0})", ferrari.GetData());
    }
}

public enum Color { Yellow, Black, Blue, Red };

class Car
{
    Color _carColor;
    int _mileage = 0;
    int _horsepower = 0;

    public Car(Color color, int mileage, int horsepower)
    {
        if (mileage < 0 || mileage > 1000000) {
            Console.WriteLine("Try again, using default values.");
            _carColor = color;
        }
        else {
            _carColor = color;
            _mileage =  (mileage / 1000) * 1000;
            _horsepower = horsepower;
        }
    }

    public Car(Color color, int mileage)
    {
        if (mileage < 0) {
            Console.WriteLine("Try again, using default values.");
            _carColor = color;
        }
        else {
            _carColor = color;
            _mileage = (mileage / 1000) * 1000;
        }
    }

    public string GetData() => "" + _carColor + " " + _mileage + " " + _horsepower;
}
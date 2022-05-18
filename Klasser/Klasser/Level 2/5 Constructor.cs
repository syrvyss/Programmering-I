// Constructor.cs
// a) Lav en klasse kaldet Bil med tre felter: farve, kmStand og hk.
// b) Lav en constructor i Bil-klassen, som kan tage imod alle tre parametre, nemlig farve, kmStand og hk. 
//    Sørg for at constructoren initialiserer de rigtige felter.
// c) Lav en metode i Bil-klassen, som hedder HentData. Den returnerer en streng med værdierne for alle tre felter.
// d) I Main skal der nu oprettes et bil-objekt, som får sine data sendt ind i klassen via constructoren.
//    Prøv at oprette et par biler med forskellige data og udlæs dem.
// e) Prøv at oprette et objekt uden argumenter. Kan det lade sig gøre? Kan du få det til at virke?

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Car aygo = new Car(Color.Yellow, 1000, 100);
        Console.WriteLine("Loaded aygo Color.Yellow, 1000, 100: Result({0})", aygo.GetData());

        Car ferrari = new Car(Color.Red, 20000, 300);
        Console.WriteLine("Loaded ferrari Color.Red, 20000, 300: Result({0})", ferrari.GetData());

        Car lada = new Car(Color.Black, 100000, 10);
        Console.WriteLine("Loaded lada Color.Black, 100000, 10: Result({0})", lada.GetData());
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
        _carColor = color;
        _mileage = mileage;
        _horsepower = horsepower;
    }

    public string GetData() => "" + _carColor + " " + _mileage + " " + _horsepower;
}
// MetodeOverload.cs
// a) Lav en klasse kaldet Bil med tre felter: farve, kmStand og hk.
// b) Lav en metode i Bil-klassen, som hedder IndlægData. Den skal findes i tre udgaver (overloadet). Første udgave 
//    kan tage imod alle tre parametre, nemlig farve, kmStand og hk. Den næste udgave kan kun tage imod farve og kmStand.
//    Den sidste udgave tager kun imod farve. Sørg for at alle tre metoder initialiserer de rigtige felter.
// c) Lav en metode i Bil-klassen, som hedder HentData. Den returnerer en streng med værdierne for alle tre felter.
// d) I Main skal der nu oprettes et bil-objekt og metoder (og varianterne) skal afprøves. Virker det som forventet?
// Reflektion: Hvad er den store fordel ved at benytte metode overload?

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Car aygo = new Car();
        aygo.LoadData(Color.Yellow, 1000, 100);
        Console.WriteLine("Loaded Color.Yellow, 1000, 100: Result({0})", aygo.GetData());
        
        aygo.LoadData(Color.Black, 2000, 50);
        Console.WriteLine("Loaded Color.Yellow, 1000, 100: Result({0})", aygo.GetData());
    }
}

public enum Color { Yellow, Black, Blue };

class Car
{
    Color _carColor;
    int _mileage = 0;
    int _horsepower = 0;
    public void LoadData(Color color, int mileage, int horsepower)
    {
        _carColor = color;
        _mileage = mileage;
        _horsepower = horsepower;
    }
    public void LoadData(Color color, int mileage)
    {
        _carColor = color;
        _mileage = mileage;
    }
    public void LoadData(Color color) => _carColor = color;
    public string GetData() => "" + _carColor + " " + _mileage + " " + _horsepower;
}
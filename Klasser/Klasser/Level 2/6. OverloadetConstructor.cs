// OverloadetConstructor.cs
// Opgaven bygger videre på den foregående.
// a) Lav en klasse kaldet Bil med tre felter: farve, kmStand og hk.
// b) Lav passende contructorer i tre udgaver (overloadet). Første udgave kan tage imod alle tre parametre, 
//    nemlig farve, kmStand og hk (som i forrige opgave). 
//    Den næste udgave kan kun tage imod farve og kmStand. Den sidste udgave tager kun imod farve. 
// c) Lav en metode i Bil-klassen, som hedder HentData. Den returnerer en streng med værdierne for alle tre felter.
// d) I Main skal der nu oprettes nogle bil-objekt således at alle måderne afprøves. Virker det som forventet?

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Car aygo = new Car(Color.Yellow, 1000, 100);
        Console.WriteLine("Loaded aygo Color.Yellow, 1000, 100: Result({0})", aygo.GetData());

        Car ferrari = new Car(Color.Red, 20000);
        Console.WriteLine("Loaded ferrari Color.Red, 20000: Result({0})", ferrari.GetData());
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

    public Car(Color color, int mileage)
    {
        _carColor = color;
        _mileage = mileage;
    }

    public string GetData() => "" + _carColor + " " + _mileage + " " + _horsepower;
}
// Properties.cs
// Opgaven bygger videre på den foregående.
// a) Du har en Bil-klasse med forskellige constructorer og en metode, der kan udlæse data.
//    Nu skal der laves properties til de tre felter, således at felterne kan læses/ændres fra Program-klassen.
// b) Afprøv de forskellige properties ved at lægge nye data ind i bilerne og ved at læse værdierne 
//    fra Program-klassen.
// c) Indbyg validering i kmStand property efter følgende regler:
//       - kmStand kan ikke være negativ og må ikke overstige 1 000 000 km. Udskriv fejlmeddelelse
//         hvis værdien falder udenfor.
//       - Programmet sørger selv for at runde kmStand værdien ned til nærmeste værdi delelig med 1000.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Car aygo = new Car(Color.Yellow, 1200, 100);
        aygo.horsepower = 200;
        Console.WriteLine("Loaded aygo Color.Yellow, 1200, 200: Result({0})", aygo.GetData());

        Car ferrari = new Car(Color.Red, 22000);
        ferrari.mileage = 20000;
        Console.WriteLine("Loaded ferrari Color.Red, 20000: Result({0})", ferrari.GetData());
    }
}

public enum Color { Yellow, Black, Blue, Red };

class Car
{
    public Color carColor { get; set; }
    public int mileage { get; set; }
    public int horsepower { get; set; } 

    public Car(Color color, int mileage, int horsepower)
    {
        if (mileage < 0 || mileage > 1000000) {
            Console.WriteLine("Try again, using default values.");
            carColor = color;
        }
        else {
            carColor = color;
            mileage =  (mileage / 1000) * 1000;
            horsepower = horsepower;
        }
    }

    public Car(Color color, int mileage)
    {
        if (mileage < 0) {
            Console.WriteLine("Try again, using default values.");
            carColor = color;
        }
        else {
            carColor = color;
            mileage = (mileage / 1000) * 1000;
        }
    }

    public string GetData() => "" + carColor + " " + mileage + " " + horsepower;
}
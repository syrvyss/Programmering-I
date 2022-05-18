// ArvEnBil.cs
// a)Opret en klasse, der hedder Bil, som indeholder felterne farve og årgang, typerne
//   er string og int.
// b)Opret desuden en klasse, der hedder SportsVogn, som nedarver fra Bil-klassen. Den skal 
//   desuden indeholde feltet hækspoiler af typen bool.
//   Lav en ny constructor, som kan initialisere alle tre felter.
//   Lav også en metode kaldet Udskriv, der kan udskrive alle tre felter.
// c)I Main oprettes et objekt af SportsVogn-klassen og Udskriv-metoden kaldes.


using System;
using System.Collections.Generic;
using System.Text;

class Program{
    static void Main(string[] args) {
        Car aygo = new Car();
        SportsCar ferrari = new SportsCar("red", 2020, true);
        ferrari.Print();
    }
}

class Car {
    protected string _color;
    protected int _year;
}

class SportsCar : Car {
    bool _spoiler;
    public SportsCar(string color, int year, bool spoiler) {
        this._color = color;
        this._year = year;
        this._spoiler = spoiler;
    }

    public void Print() {
        Console.WriteLine("Color: {0}, Year: {1}, Spoiler: {2}", this._color, this._year, this._spoiler);
    }
}
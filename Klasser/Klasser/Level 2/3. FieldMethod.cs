// FieldMethod.cs
// a) Opret en Bil-klasse med et felt km, der kan indeholde hvor mange km bilen har kørt.
// b) Lav en metode, der hedder IndlæsKm og som tager en antal km med som parameter
//    og anbringer antallet i feltet km.
// c) Lav en metode, der hedder Kør1000, som forøger feltet km med 1000.
// d) Lav en metode, der hedder UdlæsKm, som returnerer feltet km's værdi.
// e) Opret et objekt af klassen Bil. Afprøv metoderne:
//      Indlæs bilens antal kørte km.
//      Kør en lang tur på f.eks. 2000 km
//      Udlæs antal km
// Spørgsmål til reflektion: Hvordan kan det gå til at bil-objektet kan huske
// at værdien er blevet forhøjet?
// Ville man kunne lave samme program med udelukkende statiske metoder? 

using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        Car aygo = new Car();
        aygo.LoadMileage(10000);
        aygo.Drive1000(); // changes private mileage field which is stored in the class "Car", which is in the heap.
        Console.WriteLine("Mileage: {0}", aygo.GetMileage());
    }
}

class Car
{
    int mileage = 0;
    public void LoadMileage(int km) => this.mileage = km;
    public void Drive1000() => this.mileage += 1000;
    public int GetMileage() => this.mileage;
}
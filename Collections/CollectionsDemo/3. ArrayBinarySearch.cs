using System;

public class Program
{
  public static void Main()
  {
    string S�gEfter = "bmw";
    int Indeks;

    string[] BilM�rker = new string[] {"alfa romeo", "audi", "aston martin", "bentley", "bmw", "chrysler", 
        "citroen", "daewoo", "ferrari", "fiat", "ford", "honda", "hyundai", "jaguar", "kia", "lada", 
        "lamborghini", "lancia", "land rover", "range rover", "rover", "lexus", "lotus", "maserati", "mazda", 
        "mercedes benz", "mitsubishi", "mg", "morgan", "nissan", "opel", "peugeot", "porsche", "renault", 
        "rolls-royce", "saab", "seat", "skoda", "subaru", "suzuki", "toyota", "volvo", "vw"};

    // Sortering af array inden brug af BinarySearch
    Array.Sort(BilM�rker);

    Indeks = Array.BinarySearch(BilM�rker, S�gEfter);
    if (Indeks >= 0)
    {
        Console.WriteLine("Bilm�rket {0} er fundet i indeks {1}", BilM�rker[Indeks], Indeks);
    }
    else
    {
        Console.WriteLine("Bilm�rket {0} kan ikke findes", S�gEfter);
    }
  }
}
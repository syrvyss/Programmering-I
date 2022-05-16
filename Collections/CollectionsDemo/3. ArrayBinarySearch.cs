using System;

public class Program
{
  public static void Main()
  {
    string SøgEfter = "bmw";
    int Indeks;

    string[] BilMærker = new string[] {"alfa romeo", "audi", "aston martin", "bentley", "bmw", "chrysler", 
        "citroen", "daewoo", "ferrari", "fiat", "ford", "honda", "hyundai", "jaguar", "kia", "lada", 
        "lamborghini", "lancia", "land rover", "range rover", "rover", "lexus", "lotus", "maserati", "mazda", 
        "mercedes benz", "mitsubishi", "mg", "morgan", "nissan", "opel", "peugeot", "porsche", "renault", 
        "rolls-royce", "saab", "seat", "skoda", "subaru", "suzuki", "toyota", "volvo", "vw"};

    // Sortering af array inden brug af BinarySearch
    Array.Sort(BilMærker);

    Indeks = Array.BinarySearch(BilMærker, SøgEfter);
    if (Indeks >= 0)
    {
        Console.WriteLine("Bilmærket {0} er fundet i indeks {1}", BilMærker[Indeks], Indeks);
    }
    else
    {
        Console.WriteLine("Bilmærket {0} kan ikke findes", SøgEfter);
    }
  }
}
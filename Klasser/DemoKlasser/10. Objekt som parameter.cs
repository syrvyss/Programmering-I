using System;

class Program
{
    static void Main()
    {
        Person minPerson = new Person("Katja", 27);
        Printer.UdskrivPerson(minPerson);
    }
}

class Person
{
    string navn;
    public string Navn
    {
        get { return navn; }
        set { navn = value; }
    }

    int alder;
    public int Alder
    {
        get { return alder; }
        set { alder = value; }
    }

    public Person(string navn, int alder)
    {
        this.navn = navn;
        this.alder = alder;
    }
}

class Printer
{
    public static void UdskrivPerson(Person pers)
    {
        Console.WriteLine("{0} er {1} år", pers.Navn, pers.Alder);
    }
}
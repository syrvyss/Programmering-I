using System;

class Program
{
    static void Main()
    {
        Person minPerson = new Person("Katja", 7);
        Console.WriteLine(minPerson.LavStreng());

        Elev minElev = new Elev("Katja", 7, "2B");
        Console.WriteLine(minElev.LavKompletStreng());
    }
}

class Person
{
    protected string navn;
    protected int alder;

    public Person() { }

    public Person(string navn, int alder)
    {
        this.navn = navn;
        this.alder = alder;
    }

    public string LavStreng()
    {
        return string.Format("{0} er {1} år", navn, alder);
    }
}

class Elev : Person
{
    string klasse;

    public Elev(string navn, int alder, string klasse)
    {
        this.navn = navn;
        this.alder = alder;
        this.klasse = klasse;
    }

    public string LavKompletStreng()
    {
        return string.Format("{0} er {1} år og går i klassen {2}", navn, alder, klasse);
    }
}
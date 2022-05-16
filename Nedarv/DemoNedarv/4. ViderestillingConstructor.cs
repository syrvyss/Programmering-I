using System;

class Program
{
    static void Main()
    {
        Person minPerson = new Person("Katja", 7);

        Elev minElev = new Elev("Katja", 7, "2B");
    }
}

class Person
{
    protected string navn;
    protected int alder;

    public Person(string navn, int alder)
    {
        this.navn = navn;
        this.alder = alder;
    }
}

class Elev : Person
{
    string klasse;

    public Elev(string navn, int alder, string klasse) : base(navn, alder)
    {
        this.klasse = klasse;
    }
}
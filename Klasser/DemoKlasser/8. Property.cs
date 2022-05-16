using System;

class Program
{
    static void Main()
    {
        Person minPerson = new Person("Katja", 27);
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

    public string LavStreng()
    {
        return string.Format("{0} er {1} år", navn, alder);
    }
}

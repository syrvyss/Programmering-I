using System;
class Program
{
    static void Main()
    {
        Person minPerson = new Person("Katja", 27);
        Console.WriteLine(minPerson.LavStreng());
        Person dinPerson = new Person("Mikkel");
    }
}

class Person
{
    string navn;
    int alder;

    public Person(string navn, int alder)
    {
        this.navn = navn;
        this.alder = alder;
    }

    public Person(string navn)
    {
        this.navn = navn;
    }

    public string LavStreng()
    {
        return string.Format("{0} er {1} år", navn, alder);
    }
}

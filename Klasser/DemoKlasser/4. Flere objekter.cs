using System;

class Program
{
    static void Main()
    {
        Person minPerson = new Person();
        Person dinPerson = new Person();

        Console.WriteLine(minPerson.LavStreng());
        Console.WriteLine(dinPerson.LavStreng());
    }
}

class Person
{
    string navn;
    int alder;

    public string LavStreng()
    {
        return string.Format("{0} er {1} år", navn, alder);
    }

    public int BeregnFødselsår()
    {
        return DateTime.Now.Year - alder;
    }
}

using System;

class Program
{
    static void Main()
    {
        Person minPerson = new Person();
        Console.WriteLine(minPerson.LavStreng());
        Console.WriteLine("Katja blev født i {0}", minPerson.BeregnFødselsår());
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

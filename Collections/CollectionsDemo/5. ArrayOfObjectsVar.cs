using System;

class Program
{
    static void Main(string[] args)
    {
        Person[] personArr = new Person[] { new Person("Katja", 27), new Person("Christian", 17), 
            new Person("Jasmin", 39) };

        Console.WriteLine("Navn: {0}, Alder: {1}",personArr[1].Navn, personArr[1].Alder);

        foreach (Person p in personArr)
            Console.WriteLine("Navn: {0}, Alder: {1}", p.Navn, p.Alder);
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


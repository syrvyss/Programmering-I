using System;

class Program
{
    static void Main()
    {
        Person objKatja = new Person("Katja", 27);
        Person objChristian = new Person("Christian", 17);
        Person objLisa = new Person("Jasmin", 39);

        Person[] personArr = new Person[] { objKatja, objChristian, objLisa };
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


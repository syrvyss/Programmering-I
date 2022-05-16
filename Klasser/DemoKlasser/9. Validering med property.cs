using System;

class Program
{
    static void Main()
    {
        Person minPerson = new Person("Katja", 27);
        minPerson.Alder = 17;
        Console.WriteLine("{0} er {1} år", minPerson.Navn, minPerson.Alder);
    }
}

class Person
{
    string navn;

    public string Navn
    {
        get
        {
            return navn.ToUpper();
        }
        set { navn = value; }
    }

    int alder;

    public int Alder
    {
        get { return alder; }
        set
        {
            if (value > 0)
            {
                alder = value;
            }
        }
    }

    public Person(string navn, int alder)
    {
        this.navn = navn;
        this.alder = alder;
    }
}

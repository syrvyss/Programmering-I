using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Person> personList = new List<Person>();
        personList.Add(new Person("Katja", 27));
        personList.Add(new Person("Christian", 17));
        personList.Add(new Person("Jasmin", 39));

        Console.WriteLine("Navn: {0}, Alder: {1}",personList[1].Navn, personList[1].Alder);

        foreach (Person p in personList)
            Console.WriteLine("Navn: {0}, Alder: {1}", p.Navn, p.Alder);

        personList.RemoveAt(1);
        foreach (Person p in personList)
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


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
    int alder;

    public Person(string n, int a)
    {
        navn = n;
        alder = a;
    }
}

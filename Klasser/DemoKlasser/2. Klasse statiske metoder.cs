using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Person.LavStreng("Katja", 27));
        Console.WriteLine("Katja blev født i {0}", Person.BeregnFødselsår(27));
    }
}

class Person
{
    public static string LavStreng(string navn, int alder)
    {
        return string.Format("{0} er {1} år", navn, alder);
    }

    public static int BeregnFødselsår(int alder)
    {
        return DateTime.Now.Year - alder;
    }
}

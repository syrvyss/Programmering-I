using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(LavStreng("Katja", 27));
        Console.WriteLine("Katja blev født i {0}", BeregnFødselsår(27));
    }

    static string LavStreng(string navn, int alder)
    {
        return string.Format("{0} er {1} år", navn, alder);
    }

    static int BeregnFødselsår(int alder)
    {
        return DateTime.Now.Year - alder;
    }
}























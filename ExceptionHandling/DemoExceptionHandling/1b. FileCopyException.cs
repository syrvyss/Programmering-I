using System;
using System.IO;

class Program
{
    public static void Main()
    {
        try
        {
            File.Copy("c:\fil1.txt", "c:\fil2.txt");
        }
        catch
        {
            Console.WriteLine("Der er desv�rre opst�et en fejl ved kopiering af fil1.txt.");
            Console.WriteLine("Applikationen afsluttes derfor.");
        }

        Console.WriteLine("Herfra k�rer programmet videre!");
    }
}
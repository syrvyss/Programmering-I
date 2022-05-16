using System;
using System.IO;

class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Indtast tal");
            int i = int.Parse(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Finally køres altid");
        }
    }
}
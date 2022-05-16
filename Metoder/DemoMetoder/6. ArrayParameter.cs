using System;

class Program
{
    static void Main()
    {
        int[] myArray = new int[] { 7, 9, 13 };
        Udskriv(myArray);
    }

    static void Udskriv(int[] arr)
    {
        foreach (int tal in arr)
        { Console.WriteLine(tal); }
    }
}

using System;

class Program
{
    static void Main()
    {
        decimal[] myArray = OpsamlData();
        foreach (decimal måling in myArray)
        { Console.WriteLine(måling); }
    }

    static decimal[] OpsamlData()
    {
        decimal[] myArray = new decimal[] { 7.9M, 9.3M, 13.0M };
        return myArray;
    }
}

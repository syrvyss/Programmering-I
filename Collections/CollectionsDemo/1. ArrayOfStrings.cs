using System;

class ArrayOfStrings
{
    static void Main()
    {
        string[] personArr = new string[] {"Katja 27", "Christian 17", "Jasmin 39" };

        Console.WriteLine("Element 1: {0}", personArr[1]);

        Console.WriteLine("--- Før sortering ---");
        foreach (string p in personArr)
            Console.WriteLine(p);

        Console.WriteLine("--- Efter sortering ---");
        Array.Sort(personArr);

        foreach (string p in personArr)
            Console.WriteLine(p);
        
        string[] nytPersonArr = new string[3];
        Array.Copy(personArr, nytPersonArr, 3);

        Array.Reverse(personArr);
    }

}

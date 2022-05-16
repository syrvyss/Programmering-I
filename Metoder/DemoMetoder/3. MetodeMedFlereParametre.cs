using System;

class Program
{
    static void Main()
    {
        GivAlarm("Temperatur for høj", 80);
    }

    static void GivAlarm(string str, int temp)
    {
        Console.WriteLine("{0} = {1} grader", str, temp);
    }
}

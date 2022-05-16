using System;

class Program
{
    static void Main()
    {
        GivAlarm();
        GivAlarm("Temperatur for høj");
        GivAlarm("Temperatur for høj", 110);
    }

    static void GivAlarm()
    {
        Console.WriteLine("Alarm");
    }

    static void GivAlarm(string str)
    {
        Console.WriteLine(str);
    }

    static void GivAlarm(string str, int temp)
    {
        Console.WriteLine("{0}: {1} grader", str, temp);
    }
}

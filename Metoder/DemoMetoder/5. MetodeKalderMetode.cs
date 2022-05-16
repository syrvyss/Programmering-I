using System;

class Program
{
    static void Main()
    {
        string alarmStr = Console.ReadLine();
        Console.WriteLine(GivAlarm(alarmStr));
    }

    static string GivAlarm(string str)
    {
        Console.WriteLine(str);
        return "Alarm aktiveret";
    }
}

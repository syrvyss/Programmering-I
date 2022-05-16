using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string retStr = GivAlarm("Temperatur for høj");
        Console.WriteLine(retStr);
    }

    static string GivAlarm(string str)
    {
        Console.WriteLine(str);
        return "Alarm aktiveret";
    }
}

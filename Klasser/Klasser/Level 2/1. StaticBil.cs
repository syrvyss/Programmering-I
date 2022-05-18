// StaticBil.cs
// a) Opret en klasse Bil.
// b) Klassen skal have en enkelt static metode, der hedder Distance. Den tager imod en integer kaldet hastighed og 
//    en integer kaldet timer. Metoden returnerer en integer med antal kørt km.
// c) I Main kaldes metoden Distance og returparameteren udskrives.
// Prøv eventuelt at oprette en metode, som du selv finder på.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("It is currently {0} and you have been arrested, do you know how fast you were going? (km): ", DateTime.Now);
        int speed = int.Parse(Console.ReadLine());
        
        Console.Write("\nAnd for how long have you been doing that? (min): ");
        int time = int.Parse(Console.ReadLine());

        Console.WriteLine("You have been going {0}km then!", Car.Distance(speed, time));

        Radio radio1 = new Radio();
        Radio radio2 = new Radio();

        Radio.Transmit();
    }
}

class Car
{
    public static double Distance(int speed, int time) => TimeSpan.FromMinutes(time).Multiply(speed).TotalHours;
}

class Radio
{
    public static void Transmit() => Console.WriteLine("Hello, hello! This is a radio.");
}
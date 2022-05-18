// InstanceBil.cs
// a) Opret en klasse Bil, som faktisk er en kopi af forrige opgave.
// b) Klassen skal have en enkelt INSTANCE metode, der hedder Distance. Den tager imod en integer kaldet hastighed og 
//    en integer kaldet timer. Metoden returnerer en integer med antal kørt km.
// c) I Main oprettes et objekt af Bil, som kaldes minBil. Metoden Distance kaldes og returparameteren udskrives.
// Reflektion: Tænk over forskellen på denne og forrige opgave.

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

        Car myCar = new Car();
        Console.WriteLine("You have been going {0}km then!", myCar.Distance(speed, time));
    }

    class Car
    {
        public double Distance(int speed, int time) => TimeSpan.FromMinutes(time).Multiply(speed).TotalHours;
    }

}


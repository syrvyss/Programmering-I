using System;

class Program
{
    static void Main()
    {
        DerivedClass myDerivedObject = new DerivedClass();
        Console.WriteLine(myDerivedObject.Areal());         // Metode fra BaseClass
        Console.WriteLine(myDerivedObject.Omkreds());       // Metode fra Derived
    }
}

class BaseClass
{
    double radius = 1.0;

    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    public double Areal()
    {
        return Math.PI * radius * radius;
    }
}

class DerivedClass : BaseClass
{
    public double Omkreds()
    {
        return 2 * Math.PI * Radius;
    }
}
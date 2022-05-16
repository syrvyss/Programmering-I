using System;

class Program
{
    public static void Main()
    {
        string s = "Test";

        try
        {
            int i = System.Int32.Parse(s);
        }
        catch (Exception e)
        {
            Console.WriteLine("Der er sket en fejl:\n");
            Console.WriteLine("Message: {0}\n", e.Message);
            Console.WriteLine("Source: {0}\n", e.Source);
            Console.WriteLine("TargetSite: {0}\n", e.TargetSite.Name);
            Console.WriteLine("Oprindelig meddelelse: {0}", e.ToString());
        }
    }
}
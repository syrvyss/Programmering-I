using System;
//Overflowexception: Tal 1 > 2.000.000.000
//DivideByZeroException: Tal 2 = 0
//FormatException: Tal 1 = bogstav

class Program 
{
	static public void Main() 
	{
        try
        {
            Console.WriteLine("Indtast første tal");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Indtast andet tal");
            int j = int.Parse(Console.ReadLine());
            int k = i / j;
        }
        catch (OverflowException e)
        {
            Console.WriteLine("OverflowException");
            Console.WriteLine(e.Message);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("DivideByZeroException");
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("FormatException");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception");
            Console.WriteLine(e.Message);
        }
	}
}

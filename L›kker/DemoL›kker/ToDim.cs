using System;

class Program
{
    static void Main()
    {
        string[,] toDim = new string[3,2] {{"a", "b"}, {"c", "d"}, {"e", "f"}};
        for (int i = 0; i <= 2; i++)        // Række-tæller
        {
            for (int j = 0; j <= 1; j++)    // Kolonne-tæller
            {
                Console.WriteLine("Række {0}, kolonne {1}: {2}", i,j,toDim[i,j]);
            }
        }
    }
}

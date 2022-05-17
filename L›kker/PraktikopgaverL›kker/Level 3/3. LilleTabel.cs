// LilleTabel.cs
// Skriv et program der skriver hele den lille tabel pænt formateret på skærmen (fra 1 x 1 op til 10 x 10):
// 1	2	3	4	5	6	7	8	9	10
// 2	4	6	8	10	12	14	16	18	20
// 3	6	9	12	15	18	21	24	27	30
// o.s.v.


using System;
using System.Collections.Generic;
using System.Text;

namespace Loekker
{
    class Program
    {
        static void Main() {
            Console.Write("Enter row num: ");
            int row = int.Parse(Console.ReadLine());

            Console.Write("Enter column num: ");
            int col = int.Parse(Console.ReadLine());
        
            drawTable(row, col);
        }

        static void drawTable(int row, int col) {
            for (int i = 0; i < row; i++) 
            {
                for (int k = 0; k < col; k++) 
                {
                    Console.Write("{0, 5}", (k+1) * (i+1));
                }
                Console.WriteLine("");
            }
        }
    }
}
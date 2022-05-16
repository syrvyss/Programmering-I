// MissingFile.cs
// a) Afprøv nedenstående program. Studér hvilken exception der kastes.
// b) Indbyg Exception Handling, der både håndterer den situation at filen
//    måske ikke findes samt at hvis (og kun hvis) den findes, så altid lukkes.
// c) Udvid Exception Handling med en specifik catch, der matcher at filen ikke findes.
//    Lav en brugervenlig meddelelse.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        TextReader tr = null;
        try
        {
            tr = File.OpenText("text.txt");
            Console.WriteLine(tr.ReadToEnd());
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Desværre kan filen ikke findes. Kontakt Hotline");
        }
        catch (Exception e)
        {

            Console.WriteLine(e.Message); ;
        }
        finally
        {
            if (tr != null)
            {
                tr.Close();
            }
        }
    }
}
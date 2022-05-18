// MinFamilie.cs
// Lav en klasse kaldet FamilieMedlem, som kan rumme navn, alder, by o.l.
// Opret instanser af klassen, læg data ind og gem objekterne i en List<>.
// Lav udskrift-metode, der kan udskrive din families data

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        List<FamilyMember> Family = new List<FamilyMember>() {
            new FamilyMember("Nikolaj", "Kolding", 19, true),
            new FamilyMember("Daniel", "Kolding", 16, false)
        };

        Family
            .ForEach(x => {
                var a = x.GetData();
                Console.WriteLine("Navn: {0}, City: {1}, Alder: {2}, Likes soup: {3}", a.Item1, a.Item2, a.Item3, a.Item4);
            });
    }
}

class FamilyMember {
    string _navn;
    string _city;
    int _alder;
    bool _likesSoup;

    public FamilyMember(string navn, string city, int alder, bool likesSoup) {
        this._navn = navn;
        this._city = city;
        this._alder = alder;
        this._likesSoup = likesSoup;
    }

    public (string, string, int, bool) GetData() {
        return (this._navn, this._city, this._alder, this._likesSoup);
    }
}
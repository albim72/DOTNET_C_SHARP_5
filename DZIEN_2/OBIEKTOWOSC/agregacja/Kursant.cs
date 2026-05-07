using System;
using System.Collections.Generic;
using System.Text;

namespace Agregacja
{
    internal class Kursant
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }    

        public Kursant(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }

        public void WyswietlDane()
        {
            Console.WriteLine($"Kursant: {Imie} {Nazwisko}");
        }
    }
}

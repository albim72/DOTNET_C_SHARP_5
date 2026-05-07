using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrzyKonstruktory
{
    internal class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }

        //kostruktor bezparametrowy
        public Osoba()
        {
            Imie = "Nieznane";
            Nazwisko = "Nieznane";
            Wiek = 0;
        }

        //konstruktor z jednym parametraem
        public Osoba(string imie)
        {
            Imie = imie;
            Nazwisko = "Nieznane";
            Wiek = 0;
        }

        //konstruktor z trzema parametrami
        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        public void WyswietlDane()
        {
            Console.WriteLine($"Imię: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}");
        }   
    }
}

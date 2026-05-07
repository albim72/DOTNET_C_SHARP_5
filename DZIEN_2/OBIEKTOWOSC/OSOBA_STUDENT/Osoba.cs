using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osoba_student
{
    internal class Osoba
    {
        protected string Imie;
        protected string Nazwisko;
        protected int Wiek;

        public void UstawDaneOsoby(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }


        public void WyswietlDaneOsoby()
        {
            Console.WriteLine($"Imię: {Imie}");
            Console.WriteLine($"Nazwisko: {Nazwisko}");
            Console.WriteLine($"Wiek: {Wiek}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace obiekty_podstawy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Jan", "Kowalski", 30);
            osoba1.PrzedstawSie();

            Console.WriteLine("___________________________");

            Osoba osoba2 = new Osoba("Anna", "Opoka", 41);
            osoba2.PrzedstawSie();
        }
    }

    class Osoba
    {
        //tworzenie stanu - struktura danych obiektu
        public string Imie;
        public string Nazwisko;
        public int Wiek;

        //konstruktor - metoda specjalna do tworzenia obiektów
        public Osoba(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
        }

        //metoda klasy
        public void PrzedstawSie()
        {
            Console.WriteLine($"Cześć, jestem {Imie} {Nazwisko} i mam {Wiek} lat.");
        }
    }

}

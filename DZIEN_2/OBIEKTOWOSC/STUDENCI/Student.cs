using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenci_obiekty
{
    internal class Student
    {
        //właściwości obiektu
        public String Imie { get; set; }
        public String Nazwisko { get; set; }
        public int Wiek { get; set; }

        private List<int> oceny;

        public Student(string imie, string nazwisko, int wiek)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            oceny = new List<int>();
        }

        //metoda dodająca ocenę do listy ocen
        public void DodajOcene(int ocena)
        {
            if (ocena >=1 && ocena <= 6)
            {
                oceny.Add(ocena);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa ocena. Ocena musi być między 1 a 6.");
            }
            
        }

        //metoda obliczająca średnią ocen
        public double ObliczSrednia()
        {
            if (oceny.Count == 0)
            {
                return 0; // brak ocen, średnia to 0
            }
            
            return oceny.Average();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osoba_student
{
    internal class Student: Osoba
    {
        private string NrAlbumu;
        private string Kierunek;

        public void UstawDaneStudenta
        (
            string imie,
            string nazwisko,
            int wiek,
            string NrAlbumu,
            string kierunek
        )
        {
            UstawDaneOsoby(imie, nazwisko, wiek);
            NrAlbumu = NrAlbumu;
            Kierunek = kierunek;
        }

        public void WyswietlDaneStudenta()
        {
            WyswietlDaneOsoby();
            Console.WriteLine($"Nr Albumu: {NrAlbumu}");
            Console.WriteLine($"Kierunek: {Kierunek}");
        }
    }
}

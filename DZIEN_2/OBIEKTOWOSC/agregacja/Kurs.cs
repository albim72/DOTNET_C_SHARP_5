using System;
using System.Collections.Generic;
using System.Text;

namespace Agregacja
{
    internal class Kurs
    {
        public string Nazwa { get; set; }
        private List<Kursant> kursanci;

        public Kurs(string nazwa)
        {
            Nazwa = nazwa;
            kursanci = new List<Kursant>();
        }

        public void DodajKursanta(Kursant kursant)
        {
            kursanci.Add(kursant);
        }

        public void WyswietlInformacjeOKursie()
        {
            Console.WriteLine($"Kurs: {Nazwa}");
            Console.WriteLine("Kursanci:");
            foreach (var kursant in kursanci)
            {
                kursant.WyswietlDane();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakcja
{
    abstract class Zwierze
    {
        public string Imie { get; set; }
        public Zwierze(string imie)
        {
            Imie = imie;
        }

        public void WyswietlImie()
        {
            Console.WriteLine($"Imię zwierzęcia: {Imie}");
        }

        public abstract void WydajDzwiek();
    }
}

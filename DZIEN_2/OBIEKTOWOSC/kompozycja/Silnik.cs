using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod_kompozycja
{
    internal class Silnik
    {
        private int pojemnosc;
        public Silnik(int pojemnosc)
        {
            this.pojemnosc = pojemnosc;
        }

        public void Uruchom()
        {
            Console.WriteLine("Silnik o pojemności {0} cm3 został uruchomiony.", pojemnosc);
        }

        public void Zatrzymaj()
        {
            Console.WriteLine("Silnik o pojemności {0} cm3 został zatrzymany.", pojemnosc);
        }
    }
}

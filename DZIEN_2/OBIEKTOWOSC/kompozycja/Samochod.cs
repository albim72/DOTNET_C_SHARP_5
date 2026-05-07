using System;
using System.Collections.Generic;
using System.Text;

namespace Samochod_kompozycja
{
    internal class Samochod
    {

        private string marka;
        private string model;

        private Silnik silnik;

        public Samochod(string marka, string model, int pojemnoscSilnika)
        {
            this.marka = marka;
            this.model = model;
            this.silnik = new Silnik(pojemnoscSilnika);
        }

        public void Uruchom()
        {
            Console.WriteLine("Samochód {0} {1} został uruchomiony.", marka, model);
            silnik.Uruchom();
        }

        public void Zatrzymaj()
        {
            Console.WriteLine("Samochód {0} {1} został zatrzymany.", marka, model);
            silnik.Zatrzymaj();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrzyKonstruktory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            Osoba osoba2 = new Osoba("Jan");
            Osoba osoba3 = new Osoba("Anna", "Kowalska", 30);

            Console.WriteLine("Osoba 1:");
            osoba1.WyswietlDane();

            Console.WriteLine("Osoba 2:");
            osoba2.WyswietlDane();

            Console.WriteLine("Osoba 3:");
            osoba3.WyswietlDane();

            Osoba osoba4 = new Osoba("Piotr", "Nowak");
            osoba4.WyswietlDane();

        }
    }
}

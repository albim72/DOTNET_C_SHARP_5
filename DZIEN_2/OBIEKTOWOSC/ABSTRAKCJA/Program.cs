using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstrakcja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pies pies = new Pies("Ludvik");
            Kot kot = new Kot("Astra");
            Pajak pajak = new Pajak("Black");

            pies.WyswietlImie();
            pies.WydajDzwiek();

            Console.WriteLine();

            kot.WyswietlImie();
            kot.WydajDzwiek();

            Console.WriteLine();
            pajak.WyswietlImie();
            pajak.WydajDzwiek();

        }
    }
}

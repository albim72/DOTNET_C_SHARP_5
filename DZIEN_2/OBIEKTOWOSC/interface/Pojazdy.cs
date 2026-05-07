using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdInterfejs
{
    class Samochod : IPojazd
    {
        public void Jedz()
        {
            Console.WriteLine("Samochód jedzie.");
        }
        public void ZatrzymajSie()
        {
            Console.WriteLine("Samochód zatrzymuje się.");
        }
    }

    class Rower : IPojazd
    {
        public void Jedz()
        {
            Console.WriteLine("Rower jedzie.");
        }
        public void ZatrzymajSie()
        {
            Console.WriteLine("Rower zatrzymuje się.");
        }
    }
}

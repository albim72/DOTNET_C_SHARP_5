using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdInterfejs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod samochod = new Samochod();
            Rower rower = new Rower();

            samochod.Jedz();
            samochod.ZatrzymajSie();

            rower.Jedz();
            rower.ZatrzymajSie();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple
{
    internal class SMPProgram
    {
        static void Main(string[] args)
        {
            int x,y,result;
            float floatresult;
            x = 7; y = 5;
            result = x + y;
            Console.WriteLine("Suma wartości {0} i {1} równa się {2}", x, y, result);

            result = x - y;
            Console.WriteLine("Różnica wartości {0} i {1} równa się {2}", x, y, result);

            result = x * y;
            Console.WriteLine("Iloczyn wartości {0} i {1} równa się {2}", x, y, result);

            floatresult = (float)x / y;
            Console.WriteLine("Dzielenie wartości {0} i {1} równa się {2}", x, y, floatresult);

            result = x % y;
            Console.WriteLine("Modulo wartości {0} i {1} równa się {2}", x, y, result);


            Console.WriteLine("Wartośc {0}", x);
            x += 1;
            Console.WriteLine("Inkrementacja wartości x o 1 równa się {0}", x);
            Console.WriteLine("Kolejna inkrementacja wartości x o 1 równa się {0}", ++x);
        }
    }
}

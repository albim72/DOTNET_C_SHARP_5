using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteracja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_____________________________________");
            Console.WriteLine("Pętla FOR");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Numer powtórzenia: " + i);
            }

            Console.WriteLine("_____________________________________");
            Console.WriteLine("Pętla WHILE");

            int number = 1;

            while (number <= 12)
            {
                Console.WriteLine("Numer powtórzenia: " + number);
                number++;
            }


            Console.WriteLine("_____________________________________");
            Console.WriteLine("Pętla DO WHILE");
            int nb = 10;
            do
            {
                Console.WriteLine("Numer powtórzenia: " + nb);
                nb++;
            }
            while (nb <= 15);

            Console.WriteLine("_____________________________________");
            Console.WriteLine("Pętla FOREACH");

            string[] names = { "Adam", "Ewa", "Kasia", "Marek" };
            foreach (string name in names)
            {
                Console.WriteLine("Imię: " + name);

            }
        }
    }
}

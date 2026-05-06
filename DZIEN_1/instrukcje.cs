using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace instrukcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8, b = 8, c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("Warunek jest spełniony");
            }
            else
            {
                Console.WriteLine("Warunek nie jest spełniony");
            }

            //przypadek wielokrotny
            /*
             * komentarz
             * wiele linii
             */

            string danew;
            int liczbaw;

        mojstart:
            Console.WriteLine("Podaj dane pomiędzy 1 a 3");
            danew = Console.ReadLine();
            liczbaw = Int32.Parse(danew);

            switch (liczbaw)
            {
                case 1:
                    Console.WriteLine("Wybrałeś 1");
                    break;
                case 2:
                    Console.WriteLine("Wybrałeś 2");
                    break;
                case 3:
                    Console.WriteLine("Wybrałeś 3");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowe dane, spróbuj ponownie");
                    goto mojstart;
            }

        decyzja:

            Console.WriteLine("Wpisz -> kontynuacja -> \"K\" lub -> zakończenie -> \"W\"");
            danew = Console.ReadLine();

            switch (danew)
            {
                case "K":
                    Console.WriteLine("Kontynuacja");
                    goto mojstart;
                case "W":
                    Console.WriteLine("Zakończenie");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowe dane, spróbuj ponownie");
                    goto decyzja;

            }
        }
    }
}

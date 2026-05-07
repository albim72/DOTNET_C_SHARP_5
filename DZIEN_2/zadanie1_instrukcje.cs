using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1_instrukcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programDziala = true;

            while (programDziala)
            {
                Console.Clear();

                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Sprawdź, czy liczba jest dodatnia, ujemna czy równa zero");
                Console.WriteLine("2. Sprawdź, czy liczba jest parzysta czy nieparzysta");
                Console.WriteLine("3. Wypisz liczby od 1 do N");
                Console.WriteLine("4. Wypisz tabliczkę mnożenia dla wybranej liczby");
                Console.WriteLine("0. Zakończ program");
                Console.WriteLine();
                Console.Write("Wybierz opcję: ");

                string wybor = Console.ReadLine();

                Console.WriteLine();

                switch (wybor)
                {
                    case "1":
                        SprawdzZnakLiczby();
                        break;

                    case "2":
                        SprawdzParzystosc();
                        break;

                    case "3":
                        WypiszLiczbyOd1DoN();
                        break;

                    case "4":
                        WypiszTabliczkeMnozenia();
                        break;

                    case "0":
                        programDziala = false;
                        break;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }

                if (programDziala)
                {
                    Console.WriteLine();
                    Console.WriteLine("Naciśnij dowolny klawisz, aby wrócić do menu...");
                    Console.ReadKey();
                }
            }

            Console.WriteLine("Program zakończony.");
        }

        static void SprawdzZnakLiczby()
        {
            Console.Write("Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba > 0)
            {
                Console.WriteLine("Liczba jest dodatnia.");
            }
            else if (liczba < 0)
            {
                Console.WriteLine("Liczba jest ujemna.");
            }
            else
            {
                Console.WriteLine("Liczba jest równa zero.");
            }
        }

        static void SprawdzParzystosc()
        {
            Console.Write("Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine());

            if (liczba % 2 == 0)
            {
                Console.WriteLine("Liczba jest parzysta.");
            }
            else
            {
                Console.WriteLine("Liczba jest nieparzysta.");
            }
        }

        static void WypiszLiczbyOd1DoN()
        {
            Console.Write("Podaj N: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("N musi być większe od zera.");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void WypiszTabliczkeMnozenia()
        {
            Console.Write("Podaj liczbę: ");
            int liczba = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(liczba + " x " + i + " = " + (liczba * i));
            }
        }
    }
}

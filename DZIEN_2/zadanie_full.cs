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

            int[] points = { 12, 45, 67, 23, 89, 34, 90, 56 };

            while (programDziala)
            {
                Console.Clear();

                Console.WriteLine("==============================================");
                Console.WriteLine("   PROGRAM: INSTRUKCJE WARUNKOWE, PĘTLE, TABLICE");
                Console.WriteLine("==============================================");
                Console.WriteLine();
                Console.WriteLine("CZĘŚĆ 1: INSTRUKCJE WARUNKOWE I PĘTLE");
                Console.WriteLine("1. Sprawdź, czy liczba jest dodatnia, ujemna czy równa zero");
                Console.WriteLine("2. Sprawdź, czy liczba jest parzysta czy nieparzysta");
                Console.WriteLine("3. Wypisz liczby od 1 do N");
                Console.WriteLine("4. Wypisz tabliczkę mnożenia dla wybranej liczby");
                Console.WriteLine();
                Console.WriteLine("CZĘŚĆ 2: TABLICE");
                Console.WriteLine("5. Wyświetl wszystkie elementy tablicy");
                Console.WriteLine("6. Wyświetl elementy tablicy od indeksu A do indeksu B");
                Console.WriteLine("7. Oblicz sumę punktów");
                Console.WriteLine("8. Oblicz średnią punktów");
                Console.WriteLine("9. Znajdź największą wartość w tablicy");
                Console.WriteLine("10. Policz, ile wyników jest większych lub równych 50");
                Console.WriteLine();
                Console.WriteLine("ZADANIA DODATKOWE");
                Console.WriteLine("11. Wypisz tylko liczby parzyste z tablicy");
                Console.WriteLine("12. Wypisz tylko liczby nieparzyste z tablicy");
                Console.WriteLine("13. Policz, ile elementów tablicy jest większych od średniej");
                Console.WriteLine();
                Console.WriteLine("0. Zakończ program");
                Console.WriteLine("----------------------------------------------");
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

                    case "5":
                        WyswietlTablice(points);
                        break;

                    case "6":
                        WyswietlFragmentTablicy(points);
                        break;

                    case "7":
                        ObliczSume(points);
                        break;

                    case "8":
                        ObliczSrednia(points);
                        break;

                    case "9":
                        ZnajdzNajwiekszaWartosc(points);
                        break;

                    case "10":
                        PoliczWynikiWiekszeLubRowne50(points);
                        break;

                    case "11":
                        WypiszParzyste(points);
                        break;

                    case "12":
                        WypiszNieparzyste(points);
                        break;

                    case "13":
                        PoliczElementyWiekszeOdSredniej(points);
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

        static int WczytajLiczbe(string komunikat)
        {
            int liczba;
            bool poprawnaLiczba = false;

            do
            {
                Console.Write(komunikat);
                string tekst = Console.ReadLine();

                poprawnaLiczba = int.TryParse(tekst, out liczba);

                if (!poprawnaLiczba)
                {
                    Console.WriteLine("Błąd: podaj poprawną liczbę całkowitą.");
                }

            } while (!poprawnaLiczba);

            return liczba;
        }

        static void SprawdzZnakLiczby()
        {
            int liczba = WczytajLiczbe("Podaj liczbę: ");

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
            int liczba = WczytajLiczbe("Podaj liczbę: ");

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
            int n = WczytajLiczbe("Podaj N: ");

            if (n <= 0)
            {
                Console.WriteLine("N musi być większe od zera.");
            }
            else
            {
                Console.WriteLine("Liczby od 1 do " + n + ":");

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static void WypiszTabliczkeMnozenia()
        {
            int liczba = WczytajLiczbe("Podaj liczbę: ");

            Console.WriteLine("Tabliczka mnożenia dla liczby " + liczba + ":");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(liczba + " x " + i + " = " + (liczba * i));
            }
        }

        static void WyswietlTablice(int[] points)
        {
            Console.WriteLine("Elementy tablicy:");

            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("Indeks " + i + ": " + points[i]);
            }
        }

        static void WyswietlFragmentTablicy(int[] points)
        {
            int start = WczytajLiczbe("Podaj indeks początkowy: ");
            int end = WczytajLiczbe("Podaj indeks końcowy: ");

            if (start < 0 || end >= points.Length || start > end)
            {
                Console.WriteLine("Nieprawidłowy zakres indeksów.");
                Console.WriteLine("Pamiętaj: pierwszy indeks to 0, ostatni indeks to " + (points.Length - 1) + ".");
            }
            else
            {
                Console.WriteLine("Fragment tablicy od indeksu " + start + " do indeksu " + end + ":");

                for (int i = start; i <= end; i++)
                {
                    Console.WriteLine("Indeks " + i + ": " + points[i]);
                }
            }
        }

        static void ObliczSume(int[] points)
        {
            int suma = 0;

            foreach (int point in points)
            {
                suma += point;
            }

            Console.WriteLine("Suma punktów: " + suma);
        }

        static void ObliczSrednia(int[] points)
        {
            int suma = 0;

            foreach (int point in points)
            {
                suma += point;
            }

            double srednia = (double)suma / points.Length;

            Console.WriteLine("Średnia punktów: " + srednia);
        }

        static void ZnajdzNajwiekszaWartosc(int[] points)
        {
            int max = points[0];

            for (int i = 1; i < points.Length; i++)
            {
                if (points[i] > max)
                {
                    max = points[i];
                }
            }

            Console.WriteLine("Największa wartość w tablicy: " + max);
        }

        static void PoliczWynikiWiekszeLubRowne50(int[] points)
        {
            int licznik = 0;

            foreach (int point in points)
            {
                if (point >= 50)
                {
                    licznik++;
                }
            }

            Console.WriteLine("Liczba wyników większych lub równych 50: " + licznik);
        }

        static void WypiszParzyste(int[] points)
        {
            Console.WriteLine("Liczby parzyste w tablicy:");

            bool znaleziono = false;

            foreach (int point in points)
            {
                if (point % 2 == 0)
                {
                    Console.WriteLine(point);
                    znaleziono = true;
                }
            }

            if (!znaleziono)
            {
                Console.WriteLine("Brak liczb parzystych.");
            }
        }

        static void WypiszNieparzyste(int[] points)
        {
            Console.WriteLine("Liczby nieparzyste w tablicy:");

            bool znaleziono = false;

            foreach (int point in points)
            {
                if (point % 2 != 0)
                {
                    Console.WriteLine(point);
                    znaleziono = true;
                }
            }

            if (!znaleziono)
            {
                Console.WriteLine("Brak liczb nieparzystych.");
            }
        }

        static void PoliczElementyWiekszeOdSredniej(int[] points)
        {
            int suma = 0;

            foreach (int point in points)
            {
                suma += point;
            }

            double srednia = (double)suma / points.Length;

            int licznik = 0;

            foreach (int point in points)
            {
                if (point > srednia)
                {
                    licznik++;
                }
            }

            Console.WriteLine("Średnia punktów: " + srednia);
            Console.WriteLine("Liczba elementów większych od średniej: " + licznik);
        }
    }
}

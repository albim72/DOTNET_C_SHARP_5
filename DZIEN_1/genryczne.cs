
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generyczne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1: Lista wyników zawodników...");
            List<int> scores = new List<int> { 34, 45, 55, 31, 25 };
            Console.WriteLine("Wyniki zawodników:");
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }

            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            double average = (double)sum / scores.Count;

            Console.WriteLine($"Średnia wyników: {average}");
            Console.WriteLine($"Suma punktów: {sum}");

            Console.WriteLine("Zadanie 2: Generyczna metoda wypisująca elementy...");

            List<string> names = new List<string> { "Alice", "Bob", "Charlie"};
            List<double> prices = new List<double> { 19.99, 5.49, 3.75 };
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Wypisanie imion:");
            PrintItems(names);

            Console.WriteLine("Wypisanie cen:");
            PrintItems(prices);
            Console.WriteLine("Wypisanie liczb:");
            PrintItems(numbers);

        }
       
        static void PrintItems<T>(List<T> items)
        {
            Console.WriteLine("Elementy listy:");
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        } 
    }
}

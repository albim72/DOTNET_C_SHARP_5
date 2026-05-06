using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace wnioskowanie_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("zadnie 3: zamiana typów jawnych na var");
            //String imie = "Adam";
            var name = "Anna";
            var wiek = 30;
            var wzrost = 1.75;
            var isActive = true;
            var courses = new List<string> { "C#", "Python", "Wstęp do AI" };
            //var x; Nie można użyć var bez inicjalizacji, ponieważ kompilator nie może określić typu zmiennej

            Console.WriteLine($"Imię: {name}");
            Console.WriteLine($"Wiek: {wiek}");
            Console.WriteLine($"Kusy");
            foreach (var course in courses)
            {
                Console.WriteLine($"- {course}");
            }   
        }
    }
}

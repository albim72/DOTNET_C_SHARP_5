using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osoba_student
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.UstawDaneStudenta("Jan", "Kowalski", 20, "12345", "Informatyka");
            student1.WyswietlDaneStudenta();

            Console.WriteLine("Koniec programu.... ");

        }
    }
}


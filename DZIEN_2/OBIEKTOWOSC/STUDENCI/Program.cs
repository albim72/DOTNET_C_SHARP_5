
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studenci_obiekty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obiektowy do analizy wyników zaliczeń studentów");

            //tworzenie obiektu studenta
            Student student1 = new Student("Jan", "Kowalski", 20);
            Student student2 = new Student("Nadia", "Kowal", 20);
            Student student3 = new Student("Teofil", "Ociepka", 21);
            Student student4 = new Student("Anna", "Opania", 20);
            Student student5 = new Student("Marta", "Nowak", 21);

            student1.DodajOcene(4);
            student1.DodajOcene(5);
            student1.DodajOcene(4);

            student2.DodajOcene(3);
            student2.DodajOcene(4);
            student2.DodajOcene(4);

            student3.DodajOcene(5);
            student3.DodajOcene(5);
            student3.DodajOcene(6);

            student4.DodajOcene(5);
            student4.DodajOcene(5);
            student4.DodajOcene(4);

            student5.DodajOcene(2);
            student5.DodajOcene(2);
            student5.DodajOcene(1);
        }
    }
}

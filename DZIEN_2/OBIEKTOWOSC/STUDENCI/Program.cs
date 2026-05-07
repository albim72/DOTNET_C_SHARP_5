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

            //Tworzenie listy studentów
            List<Student> studenci = new List<Student>();

            studenci.Add(student1);
            studenci.Add(student2);
            studenci.Add(student3);
            studenci.Add(student4);
            studenci.Add(student5);

            Console.WriteLine("\nLista studentów:");
            foreach (Student student in studenci)
            {
                student.WyswietlInformacje();
                Console.WriteLine();
            }

            Console.WriteLine("Najlepszy student:");

            Student najlepszyStudent = ZnajdzNajlepszegoStudenta(studenci);
            najlepszyStudent.WyswietlInformacje();

            static Student ZnajdzNajlepszegoStudenta(List<Student> studenci)
            {
                Student najlepszy = studenci[0];
                foreach (Student student in studenci)
                {
                    if (student.ObliczSrednia() > najlepszy.ObliczSrednia())
                    {
                        najlepszy = student;
                    }
                }
                return najlepszy;
            }
        }
    }
}

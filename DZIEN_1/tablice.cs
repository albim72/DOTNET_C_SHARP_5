using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosta tablica");
            int[] numbers = { 10, 22, 31, 45, 53, 67, 78, 89, 99, 101 };
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine("_____________________");
            //wypisz elementy o  indeksach od 2 do 5
            Console.WriteLine(numbers[6]);
            for (int i = 2; i <= 5; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("_____________________");
            Console.WriteLine(string.Join(" ", numbers.Skip(2).Take(5)));
            //wypisz elementy o indeksach od 2 do 5 -> Python numbers[2:6]

            //przechodzenie pętlą for po tablicy
            string[] names = { "Adam", "Ewa", "Kasia", "Tomek" };
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }

            //przechodzenie pętlą foreach po tablicy
            double[] grades = { 4.5, 3.0, 5.0, 2.5, 4.0, 2.2, 5.7, 10.2, -2.6, 0, 11.5, 53.7, 6.7 };
            foreach (double grade in grades)
            {
                Console.WriteLine(grade);
            }

            //średnia i suma temperatur

            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            double average = (double)sum / grades.Length;
            Console.WriteLine($"Suma: {sum}, Średnia: {average}");

            //jak zbudowa tablicę dwuwymiarową tablicę 3x3 i wypisz jej elementy

            int[,] matrix =
                {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            Console.WriteLine(matrix[0, 0]);
            Console.WriteLine(matrix[2, 1]);
            Console.WriteLine(matrix[2, 2]);


            //kostka Rubika
            int[,,] cube =
                {
                    {
                        {1,2,3},
                        {4,12,6},
                        {7,8,33}
                    },
                    {
                        {10,11,12},
                        {56,2,15},
                        {16,17,267}
                    },
                    {
                        {888,20,21},
                        {22,1,24},
                        {87,26,44}
                    }
                };

            Console.WriteLine(cube[0, 0, 0]);
            Console.WriteLine(cube[0, 2, 1]);
            Console.WriteLine(cube[1, 1, 1]);


        }
    }
}

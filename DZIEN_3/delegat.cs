using System;

namespace DelegateTryCatchExample
{
    // 1. Definicja delegata
    public delegate double MathOperation(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prosty kalkulator z delegatami i try-catch");
            Console.WriteLine();

            try
            {
                Console.Write("Podaj pierwszą liczbę: ");
                double number1 = double.Parse(Console.ReadLine());

                Console.Write("Podaj drugą liczbę: ");
                double number2 = double.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Wybierz działanie:");
                Console.WriteLine("1 - Dodawanie");
                Console.WriteLine("2 - Odejmowanie");
                Console.WriteLine("3 - Mnożenie");
                Console.WriteLine("4 - Dzielenie");

                Console.Write("Twój wybór: ");
                string choice = Console.ReadLine();

                MathOperation operation = null;

                if (choice == "1")
                {
                    operation = Add;
                }
                else if (choice == "2")
                {
                    operation = Subtract;
                }
                else if (choice == "3")
                {
                    operation = Multiply;
                }
                else if (choice == "4")
                {
                    operation = Divide;
                }
                else
                {
                    Console.WriteLine("Nieznana opcja.");
                    Console.ReadKey();
                    return;
                }

                // 2. Wywołanie działania przez delegat
                double result = operation(number1, number2);

                Console.WriteLine();
                Console.WriteLine("Wynik: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Błąd: wpisano niepoprawną liczbę.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine();
                Console.WriteLine("Błąd: nie można dzielić przez zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("Wystąpił nieoczekiwany błąd:");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            Console.WriteLine("Koniec programu.");
            Console.ReadKey();
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }

            return a / b;
        }
    }
}

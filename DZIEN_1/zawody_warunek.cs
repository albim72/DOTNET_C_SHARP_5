using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex_warunek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            bool hasMedicalCertificate = true;
            bool hasPaidFee = true;
            bool isBanned = false;
            int experienceYears = 2;

            bool isAdultAllowed =
                age >= 18 &&
                hasMedicalCertificate &&
                hasPaidFee &&
                !isBanned;

            bool isYoungExperiencedAllowed =
               age >= 16 &&
               experienceYears >= 2 &&
               hasMedicalCertificate &&
               hasPaidFee &&
               !isBanned;

            if (isAdultAllowed || isYoungExperiencedAllowed)
            {
                Console.WriteLine("You are allowed to participate in the event.");
            }
            else
            {
                Console.WriteLine("You are not allowed to participate in the event.");
            }

            Console.WriteLine("______________________________________");

            Console.WriteLine("Analiza problemów z zamówieniem....... ");

            int paymentStatus = 1; // 0 - unpaid, 1 - paid, 2 - refunded 
            int stockAmount = 5;
            bool customerBlocked = true;
            bool expressDelivery = true;

            if (customerBlocked)
            {
                Console.WriteLine("Zamówienie nie może być zrealizowane - klient zablokowany.");
            }
            else if (paymentStatus == 0)
            {
                Console.WriteLine("Zamówienie nie może być zrealizowane - płatność nie została dokonana.");
            }
            else if (paymentStatus == 2 || paymentStatus == 0)
            {
                Console.WriteLine("Zamówienie nie może być zrealizowane - płatność została zwrócona.");
            }
            else if (stockAmount <= 0)
            {
                Console.WriteLine("Zamówienie nie może być zrealizowane - brak towaru w magazynie.");
            }
            else if (expressDelivery && stockAmount < 3)
            {
                Console.WriteLine("Zamówienie nie może być zrealizowane - niewystarczająca ilość towaru dla ekspresowej dostawy.");
            }
            else
            {
                Console.WriteLine("Zamówienie może być zrealizowane.");
            }

            Console.WriteLine("______________________________________");
            Console.WriteLine("Analiza problemów z autoryzacją dostępu ... ");

            string login = "admin";
            string password = "abc123";
            bool accountActive = true;
            bool twoFactorEnabled = false;
            string twoFactorCode = "999999";

            if (login == "admin")
            {

                if (password == "abc123")
                {
                    Console.WriteLine("Hasło poprawne.");

                    if (accountActive)
                    {
                        Console.WriteLine("Konto jest aktywne... ");
                        if (twoFactorEnabled)
                        {
                            Console.WriteLine("Weryfikacja dwuetapowa włączona... ");
                            if (twoFactorCode == "999999")
                            {
                                Console.WriteLine("Kod dwuetapowy poprawny. Dostęp przyznany.");
                            }
                            else
                            {
                                Console.WriteLine("Kod dwuetapowy niepoprawny. Dostęp odrzucony.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Weryfikacja dwuetapowa wyłączona. Dostęp przyznany.");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Konto nie jest aktywne. Dostęp odrzucony.");

                    }


                }
                else
                {
                    Console.WriteLine("Hasło niepoprawne. Dostęp odrzucony.");
                }


            }
            else
            {
                Console.WriteLine("Login niepoprawny. Dostęp odrzucony.");

            }
        }
    }
}

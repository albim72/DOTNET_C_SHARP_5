using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wyliczenia
{
    internal class Program
    {
        enum OrderStatus
        {
            New,
            Paid,
            Shipped,
            Delivered,
            Cancelled
        }

        enum UserRole
        {
            Admin,
            User,
            Guest,
            Moderator,
            Administrator 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 5: status zamówienia");
            OrderStatus status = OrderStatus.Delivered;
            switch (status)
            {
                case OrderStatus.New:
                    Console.WriteLine("Zamówienie jest nowe.");
                    break;
                case OrderStatus.Paid:
                    Console.WriteLine("Zamówienie zostało opłacone.");
                    break;

                case OrderStatus.Shipped:
                    Console.WriteLine("Zamówienie zostało wysłane.");
                    break;
                case OrderStatus.Delivered:
                    Console.WriteLine("Zamówienie zostało dostarczone.");
                    break;
                case OrderStatus.Cancelled:
                    Console.WriteLine("Zamówienie zostało anulowane.");
                    break;
                default:
                    Console.WriteLine("Nieznany status zamówienia.");
                    break;
            }

            UserRole role = UserRole.User;
            switch(role)
            {
                case UserRole.Guest:
                    Console.WriteLine("Rola: Gość. Może przeglądac publiczne treści...");
                    break;

                case UserRole.User:
                    Console.WriteLine("Rola: Użytkownik. Może przeglądać i komentować treści...");
                    break;

                case UserRole.Moderator:
                    Console.WriteLine("Rola: Moderator. Może zarządzać treściami i użytkownikami...");
                    break;
                case UserRole.Administrator:
                    Console.WriteLine("Rola: Administrator. Ma pełne uprawnienia...");
                    break;

                default:
                    Console.WriteLine("Nieznana rola użytkownika.");
                    break;
            }



        } 
    
    }
}

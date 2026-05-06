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
        } 
    
    }
}

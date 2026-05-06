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
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace EntityFrameworkLinqExample
{
    public class Runner
    {
        public int RunnerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int StartNumber { get; set; }
        public string RaceName { get; set; }

        public int DistanceKm { get; set; }
        public int TimeInMinutes { get; set; }
    }

    public class RaceContext : DbContext
    {
        public RaceContext() : base("name=RaceContext")
        {
        }

        public DbSet<Runner> Runners { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<RaceContext>()
            );

            using (RaceContext db = new RaceContext())
            {
                if (!db.Runners.Any())
                {
                    List<Runner> runners = new List<Runner>
                    {
                        new Runner
                        {
                            FirstName = "Adam",
                            LastName = "Kowalski",
                            StartNumber = 125,
                            RaceName = "Tatra Sky Marathon",
                            DistanceKm = 45,
                            TimeInMinutes = 584
                        },
                        new Runner
                        {
                            FirstName = "Anna",
                            LastName = "Nowak",
                            StartNumber = 77,
                            RaceName = "Tatra Sky Marathon",
                            DistanceKm = 45,
                            TimeInMinutes = 560
                        },
                        new Runner
                        {
                            FirstName = "Piotr",
                            LastName = "Wiśniewski",
                            StartNumber = 301,
                            RaceName = "Bieg Górski",
                            DistanceKm = 30,
                            TimeInMinutes = 410
                        },
                        new Runner
                        {
                            FirstName = "Katarzyna",
                            LastName = "Zielińska",
                            StartNumber = 44,
                            RaceName = "Bieg Górski",
                            DistanceKm = 30,
                            TimeInMinutes = 385
                        }
                    };

                    db.Runners.AddRange(runners);
                    db.SaveChanges();

                    Console.WriteLine("Dodano przykładowe dane do bazy.");
                    Console.WriteLine();
                }

                Console.WriteLine("Wszyscy zawodnicy:");
                Console.WriteLine();

                List<Runner> allRunners = db.Runners.ToList();

                foreach (Runner runner in allRunners)
                {
                    Console.WriteLine(
                        runner.FirstName + " " +
                        runner.LastName +
                        ", numer: " + runner.StartNumber +
                        ", bieg: " + runner.RaceName +
                        ", czas: " + runner.TimeInMinutes + " min"
                    );
                }

                Console.WriteLine();
                Console.WriteLine("Zawodnicy z czasem poniżej 570 minut:");
                Console.WriteLine();

                var fastRunners =
                    from runner in db.Runners
                    where runner.TimeInMinutes < 570
                    orderby runner.TimeInMinutes
                    select runner;

                foreach (Runner runner in fastRunners)
                {
                    Console.WriteLine(
                        runner.FirstName + " " +
                        runner.LastName +
                        " - " + runner.TimeInMinutes + " min"
                    );
                }

                Console.WriteLine();
                Console.WriteLine("Średni czas zawodników:");
                Console.WriteLine();

                double averageTime = db.Runners.Average(r => r.TimeInMinutes);

                Console.WriteLine(averageTime + " minut");

                Console.WriteLine();
                Console.WriteLine("Grupowanie po nazwie biegu:");
                Console.WriteLine();

                var groupedByRace =
                    from runner in db.Runners
                    group runner by runner.RaceName into raceGroup
                    select new
                    {
                        RaceName = raceGroup.Key,
                        Count = raceGroup.Count(),
                        BestTime = raceGroup.Min(r => r.TimeInMinutes)
                    };

                foreach (var group in groupedByRace)
                {
                    Console.WriteLine("Bieg: " + group.RaceName);
                    Console.WriteLine("Liczba zawodników: " + group.Count);
                    Console.WriteLine("Najlepszy czas: " + group.BestTime + " min");
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}

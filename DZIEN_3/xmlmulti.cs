using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DeepXmlSerializationExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "race.xml";

            Race race = new Race
            {
                Name = "Tatra Sky Marathon",
                Year = 2026,
                Location = new RaceLocation
                {
                    Country = "Poland",
                    Region = "Tatry",
                    City = "Zakopane"
                },
                Runner = new Runner
                {
                    StartNumber = 125,
                    PersonalData = new PersonalData
                    {
                        FirstName = "Adam",
                        LastName = "Kowalski",
                        Address = new Address
                        {
                            Street = "Górska 12",
                            City = "Kraków",
                            PostalCode = "30-001",
                            Country = "Poland"
                        }
                    },
                    Contact = new Contact
                    {
                        Email = "adam.kowalski@example.com",
                        Phone = "500-600-700"
                    },
                    Result = new Result
                    {
                        TotalTimeInMinutes = 284,
                        Status = "FINISHED",
                        Checkpoints = new List<Checkpoint>
                        {
                            new Checkpoint
                            {
                                Name = "Dolina Kościeliska",
                                Kilometer = 10,
                                TimeInMinutes = 70
                            },
                            new Checkpoint
                            {
                                Name = "Czerwone Wierchy",
                                Kilometer = 23,
                                TimeInMinutes = 165
                            },
                            new Checkpoint
                            {
                                Name = "Meta",
                                Kilometer = 45,
                                TimeInMinutes = 284
                            }
                        }
                    }
                }
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Race));

            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                serializer.Serialize(stream, race);
            }

            Console.WriteLine("Obiekt został zapisany do pliku XML.");
            Console.WriteLine("Plik: " + filePath);

            Console.WriteLine();
            Console.WriteLine("Odczyt z XML:");

            Race loadedRace;

            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                loadedRace = (Race)serializer.Deserialize(stream);
            }

            Console.WriteLine("Nazwa biegu: " + loadedRace.Name);
            Console.WriteLine("Rok: " + loadedRace.Year);
            Console.WriteLine("Miasto: " + loadedRace.Location.City);

            Console.WriteLine();
            Console.WriteLine("Zawodnik:");
            Console.WriteLine(loadedRace.Runner.PersonalData.FirstName + " " +
                              loadedRace.Runner.PersonalData.LastName);

            Console.WriteLine("Numer startowy: " + loadedRace.Runner.StartNumber);
            Console.WriteLine("Email: " + loadedRace.Runner.Contact.Email);

            Console.WriteLine();
            Console.WriteLine("Punkty kontrolne:");

            foreach (Checkpoint checkpoint in loadedRace.Runner.Result.Checkpoints)
            {
                Console.WriteLine(checkpoint.Name + 
                                  " | km: " + checkpoint.Kilometer +
                                  " | czas: " + checkpoint.TimeInMinutes + " min");
            }

            Console.ReadKey();
        }
    }

    public class Race
    {
        public string Name { get; set; }
        public int Year { get; set; }

        public RaceLocation Location { get; set; }

        public Runner Runner { get; set; }

        public Race()
        {
        }
    }

    public class RaceLocation
    {
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }

        public RaceLocation()
        {
        }
    }

    public class Runner
    {
        public int StartNumber { get; set; }

        public PersonalData PersonalData { get; set; }

        public Contact Contact { get; set; }

        public Result Result { get; set; }

        public Runner()
        {
        }
    }

    public class PersonalData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Address Address { get; set; }

        public PersonalData()
        {
        }
    }

    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public Address()
        {
        }
    }

    public class Contact
    {
        public string Email { get; set; }
        public string Phone { get; set; }

        public Contact()
        {
        }
    }

    public class Result
    {
        public int TotalTimeInMinutes { get; set; }
        public string Status { get; set; }

        public List<Checkpoint> Checkpoints { get; set; }

        public Result()
        {
            Checkpoints = new List<Checkpoint>();
        }
    }

    public class Checkpoint
    {
        public string Name { get; set; }
        public int Kilometer { get; set; }
        public int TimeInMinutes { get; set; }

        public Checkpoint()
        {
        }
    }
}

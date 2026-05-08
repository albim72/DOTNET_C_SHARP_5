using System;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace BuildAndValidateXmlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlFilePath = "race.xml";
            string xsdFilePath = "race_schema.xsd";

            XDocument document = BuildRaceXml();

            document.Save(xmlFilePath);

            Console.WriteLine("Plik XML został zapisany.");
            Console.WriteLine();

            bool isValid = ValidateXml(xmlFilePath, xsdFilePath);

            if (isValid)
            {
                Console.WriteLine("XML jest zgodny ze schemą XSD.");
            }
            else
            {
                Console.WriteLine("XML NIE jest zgodny ze schemą XSD.");
            }

            Console.ReadKey();
        }

        static XDocument BuildRaceXml()
        {
            XDocument document = new XDocument(
                new XDeclaration("1.0", "utf-8", null),

                new XElement("Race",
                    new XElement("Name", "Tatra Sky Marathon"),
                    new XElement("Year", 2026),

                    new XElement("Location",
                        new XElement("Country", "Poland"),
                        new XElement("Region", "Tatry"),
                        new XElement("City", "Zakopane")
                    ),

                    new XElement("Runner",
                        new XElement("StartNumber", 125),

                        new XElement("PersonalData",
                            new XElement("FirstName", "Adam"),
                            new XElement("LastName", "Kowalski"),

                            new XElement("Address",
                                new XElement("Street", "Górska 12"),
                                new XElement("PostalCode", "30-001"),
                                new XElement("City", "Kraków"),
                                new XElement("Country", "Poland")
                            )
                        ),

                        new XElement("Result",
                            new XElement("TotalTimeInMinutes", 284),
                            new XElement("Status", "FINISHED"),

                            new XElement("Checkpoints",
                                new XElement("Checkpoint",
                                    new XElement("Name", "Dolina Kościeliska"),
                                    new XElement("Kilometer", 10),
                                    new XElement("TimeInMinutes", 70)
                                ),

                                new XElement("Checkpoint",
                                    new XElement("Name", "Czerwone Wierchy"),
                                    new XElement("Kilometer", 23),
                                    new XElement("TimeInMinutes", 165)
                                ),

                                new XElement("Checkpoint",
                                    new XElement("Name", "Meta"),
                                    new XElement("Kilometer", 45),
                                    new XElement("TimeInMinutes", 284)
                                )
                            )
                        )
                    )
                )
            );

            return document;
        }

        static bool ValidateXml(string xmlFilePath, string xsdFilePath)
        {
            bool isValid = true;

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", xsdFilePath);

            XDocument document = XDocument.Load(xmlFilePath);

            document.Validate(schemas, (sender, e) =>
            {
                Console.WriteLine("Błąd walidacji:");
                Console.WriteLine(e.Message);
                isValid = false;
            });

            return isValid;
        }
    }
}

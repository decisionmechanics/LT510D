namespace XmlToJson
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.Json;
    using System.Xml.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: <XML document path>");

                Environment.Exit(1);
            }

            IEnumerable<Match> matches = ImportMatchesFromXml(args[0]).ToList();

            ExportMatchesToJson(matches);
        }

        private static IEnumerable<Match> ImportMatchesFromXml(string documentPath)
        {
            ICollection<Match> matches = new List<Match>();

            XDocument document = XDocument.Load(documentPath);

            foreach (XElement matchElement in document.Root!.Elements())
            {
                var match = new Match
                {
                    Id = (int)matchElement.Attribute("id")!,
                    Kickoff = DateTime.Parse((string)matchElement.Element("Kickoff")!),
                    HomeTeam = (string)matchElement.Element("HomeTeam")!,
                    AwayTeam = (string)matchElement.Element("AwayTeam")!,
                    Score = new Score
                    {
                        HomeTeamGoals = (int)matchElement.Element("Score")!.Element("FullTime")!.Element("Home")!,
                        AwayTeamGoals = (int)matchElement.Element("Score")!.Element("FullTime")!.Element("Away")!
                    },
                    HalfTimeScore = new Score
                    {
                        HomeTeamGoals = (int)matchElement.Element("Score")!.Element("HalfTime")!.Element("Home")!,
                        AwayTeamGoals = (int)matchElement.Element("Score")!.Element("HalfTime")!.Element("Away")!,
                    },
                    Prices = new Prices
                    {
                        HomeWin = (decimal)matchElement.Element("Prices")!.Element("Home")!,
                        Draw = (decimal)matchElement.Element("Prices")!.Element("Draw")!,
                        AwayWin = (decimal)matchElement.Element("Prices")!.Element("Away")!,
                    }
                };

                matches.Add(match);
            }

            return matches;
        }

        private static void ExportMatchesToJson(IEnumerable<Match> matches)
        {
            var serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(matches, serializerOptions);

            Console.Write(json);
        }
    }
}

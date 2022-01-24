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
            XDocument document = XDocument.Load(documentPath);

            ICollection<Match> matches = new List<Match>();

            foreach (XElement matchElement in document.Root!.Elements())
            {
                var match = new Match
                {
                    Id = (int)matchElement.Attribute("id")!,
                    Kickoff = DateTime.Parse((string)matchElement.Element("Kickoff")!),
                    HomeTeam = (string)matchElement.Element("HomeTeam")!,
                    AwayTeam = (string)matchElement.Element("AwayTeam")!,
                    HomeTeamGoals = (int)matchElement.Element("Score")!.Element("FullTime")!.Element("Home")!,
                    AwayTeamGoals = (int)matchElement.Element("Score")!.Element("FullTime")!.Element("Away")!,
                    HalfTimeHomeTeamGoals = (int)matchElement.Element("Score")!.Element("HalfTime")!.Element("Home")!,
                    HalfTimeAwayTeamGoals = (int)matchElement.Element("Score")!.Element("HalfTime")!.Element("Away")!,
                    HomeWinPrice = (decimal)matchElement.Element("Prices")!.Element("Home")!,
                    DrawPrice = (decimal)matchElement.Element("Prices")!.Element("Draw")!,
                    AwayWinPrice = (decimal)matchElement.Element("Prices")!.Element("Away")!,
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

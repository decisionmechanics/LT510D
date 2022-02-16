namespace XmlToJson
{
    using System;

    public class Match
    {
        public int Id { get; set; }
        public DateTime Kickoff { get; set; }
        public string HomeTeam { get; set; } = string.Empty;
        public string AwayTeam { get; set; } = string.Empty;
        public int HomeTeamGoals { get; set; }
        public int AwayTeamGoals { get; set; }
        public int HalfTimeHomeTeamGoals { get; set; }
        public int HalfTimeAwayTeamGoals { get; set; }
        public decimal HomeWinPrice { get; set; }
        public decimal DrawPrice { get; set; }
        public decimal AwayWinPrice { get; set; }
    }
}

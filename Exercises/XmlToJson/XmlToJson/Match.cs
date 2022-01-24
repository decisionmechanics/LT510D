namespace XmlToJson
{
    using System;

    public class Match
    {
        public int Id { get; set; }
        public DateTime Kickoff { get; set; }
        public string HomeTeam { get; set; } = string.Empty;
        public string AwayTeam { get; set; } = string.Empty;
        public Score Score { get; set; } = new();
        public Score HalfTimeScore { get; set; } = new();
        public Prices Prices { get; set; } = new();
    }
}

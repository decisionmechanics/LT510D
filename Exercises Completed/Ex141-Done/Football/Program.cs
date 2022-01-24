using System.Text.Json;

string json = File.ReadAllText(@"C:\Course\510D\Data\epl_2020_2021.json");

var serializerOptions = new JsonSerializerOptions
{
    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
};

var matches = JsonSerializer.Deserialize<IEnumerable<Match>>(json, serializerOptions)!.ToList();

// Calculate the number of wins by team

var topHomeTeamWins = matches
    .Where(x => x.HomeTeamGoals > x.AwayTeamGoals)
    .GroupBy(x => x.HomeTeam)
    .Select(g => new { Team = g.Key, Wins = g.Count() })
    .OrderByDescending(x => x.Wins)
    .Take(5)
    .ToList();

foreach (var x in topHomeTeamWins)
{
    Console.WriteLine($"{x.Team} had {x.Wins} home wins");
}

var topAwayTeamWins = matches
    .Where(x => x.HomeTeamGoals < x.AwayTeamGoals)
    .GroupBy(x => x.AwayTeam)
    .Select(g => new {Team = g.Key, Wins = g.Count()})
    .OrderByDescending(x => x.Wins)
    .Take(5)
    .ToList();

foreach (var x in topAwayTeamWins)
{
    Console.WriteLine($"{x.Team} had {x.Wins} away wins");
}

foreach (string team in topHomeTeamWins.Select(h => h.Team).Intersect(topAwayTeamWins.Select(a => a.Team)))
{
    Console.WriteLine(team);
}

int numberOfDraws = matches.Count(x => x.HomeTeamGoals == x.AwayTeamGoals);

Console.WriteLine($"There were {numberOfDraws} draws");

// Analyze the betting prices

var leastFavoredAway = matches
    .OrderByDescending(x => x.AwayWinPrice)
    .First();

Console.WriteLine(
    $"{leastFavoredAway.AwayTeam} was very unfavored away against {leastFavoredAway.HomeTeam} @ {leastFavoredAway.AwayWinPrice}");

var mostLikelyDraw = matches
    .OrderBy(x => x.DrawPrice)
    .First();

Console.WriteLine($"{mostLikelyDraw.HomeTeam} vs {mostLikelyDraw.AwayTeam} was considered a likely draw @ {mostLikelyDraw.DrawPrice}");

var underdogs = matches
    .Where(x => x.AwayWinPrice > x.HomeWinPrice && x.AwayTeamGoals > x.HomeTeamGoals)
    .OrderByDescending(x => x.AwayWinPrice)
    .ToList();

foreach (var underdog in underdogs)
{
    Console.WriteLine(
        $"{underdog.AwayTeam} unexpectedly beat {underdog.HomeTeam} despite being considered a {underdog.AwayWinPrice} underdog");
}

// Recreate the final league table (i.e. point tally per team) for the season

var homeTeamPoints =
    (from x in matches
        let points = x.HomeTeamGoals > x.AwayTeamGoals ? 3 : (x.HomeTeamGoals == x.AwayTeamGoals ? 1 : 0)
        select new {Team = x.HomeTeam, Points = points}).ToList();

var awayTeamPoints =
    (from x in matches
        let points = x.AwayTeamGoals > x.HomeTeamGoals ? 3 : (x.AwayTeamGoals == x.HomeTeamGoals ? 1 : 0)
        select new {Team = x.AwayTeam, Points = points}).ToList();

var teamPoints = homeTeamPoints.Concat(awayTeamPoints).ToList();

var leagueTable = teamPoints
    .GroupBy(x => x.Team)
    .Select(g => new {Team = g.Key, Points = g.Sum(x => x.Points)})
    .OrderByDescending(x => x.Points)
    .ToList();

foreach (var team in leagueTable)
{
    Console.WriteLine($"{team.Team}: {team.Points}");
}

foreach (var team in leagueTable.Take(4))
{
    Console.WriteLine($"{team.Team} qualified for the Champions League");
}

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
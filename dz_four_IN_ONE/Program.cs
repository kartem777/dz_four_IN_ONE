using dz_four_IN_ONE;
internal class Program
{
    static void Main(string[] args)
    {
        using (ApplicationContext db = new ApplicationContext())
        {
            //dz3
            //Team team1 = new Team { Name = "Team 1", Sity = "IF", WinCount = 999, LoseCount = 0, DrawCount = 0, GoalsLose = 0, GoalsWin = 9999 };
            //Team team2 = new Team { Name = "Team 2", Sity = "Main Sity", WinCount = 9, LoseCount = 8, DrawCount = 1, GoalsLose = 3, GoalsWin = 17 };
            //Team team3 = new Team { Name = "Team 3", Sity = "FI", WinCount = 3, LoseCount = 5, DrawCount = 3, GoalsLose = 21, GoalsWin = 9 };
            //db.Tournament.Add(team1);
            //db.Tournament.Add(team2);
            //db.Tournament.Add(team3);
            //db.SaveChanges();
            var teams = db.Tournament.ToList();
            foreach (Team team in teams) { Console.WriteLine($"{team.Name} {team.Sity} -> W: {team.WinCount} L: {team.LoseCount} D: {team.DrawCount}"); }
        }
    }
}

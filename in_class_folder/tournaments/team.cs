public class Team
{
    private string _name;
    private List<Player> _roster = new List<Player>();
    private int _wins = 0;
    private int _losses = 0;

    public Team(string name)
    {
        _name = name;

    }

    public void AddPlayer(Player p)
    {
        _roster.Add(p);
    }
    
    public void AddWin()
    {
        _wins++;
    }

    public void AddLoss()
    {
        _losses++;
    }

    public string GetTeamName()
    {
        return _name;
    }

    public void DisplayRoster()
    {
        Console.WriteLine();
        Console.WriteLine(_name);
        Console.WriteLine($"Wins: {_wins} Losses: {_losses}");
        Console.WriteLine("__________________________________");
        foreach (Player p in _roster)
        {
            p.Display();
        }
        Console.WriteLine();
    }
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Player yodaddy = new Player("Johann Dandy", 2);
//ronaldo.Display();

Player mother = new Player("Josephene Mother", 1);
//mother.Display();

Player jdoe = new Player("Jonathan Doughman", 3);

Player ike = new Player("Ike Ildagai", 4);

Team team_one = new Team("team_one");
team_one.AddPlayer(mother);
team_one.AddPlayer(yodaddy);
team_one.AddPlayer(jdoe);
team_one.AddPlayer(ike);

team_one.DisplayRoster();
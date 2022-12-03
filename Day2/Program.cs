// See https://aka.ms/new-console-template for more information

using Day2;

string[] rawData = File.ReadAllLines("RawData.txt");

IRule rule1 = new Rule1();
IRule rule2 = new Rule2();
IComparer<char> round = new Round1();
IComparer<char> round2 = new Round2();

List<IGame> games = new();
foreach (var s in rawData)
{
    IGame game = new Game(rule1, rule2, round);
    game.Setup(s);
    games.Add(game);
}

Console.WriteLine("Part one");
var myScore = games.Sum(g => g.Calculate());
Console.WriteLine($"My score: {myScore}");
Console.ReadKey();

List<IGame> games1 = new();
foreach (var s in rawData)
{
    IGame game = new Game(rule1, rule2, round2);
    game.Setup(s);
    games1.Add(game);
}


Console.WriteLine("Part two");
var myNewScore = games1.Sum(g => g.Calculate1());
Console.WriteLine($"My new score: {myNewScore}");
Console.ReadKey();
// See https://aka.ms/new-console-template for more information

using Day4;

string[] rawData = File.ReadAllLines("RawData.txt");

List<IPair> list = new List<IPair>();
foreach (string line in rawData)
{
    var pairs = line.Split(',');
    var p1 = pairs[0].Split('-');
    var p2 = pairs[1].Split('-');
    Pair pair = new(int.Parse(p1[0]), int.Parse(p1[1]), int.Parse(p2[0]), int.Parse(p2[1]));
    list.Add(pair);
}

var count = list.Count(p => p.Intersect());
Console.WriteLine("Part one");
Console.WriteLine($"Count: {count}");
Console.ReadKey();

var overlap = list.Count(p => p.Overlap());
Console.WriteLine("Part two");
Console.WriteLine($"Overlap: {overlap}");
Console.ReadKey();
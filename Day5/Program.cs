// See https://aka.ms/new-console-template for more information

using Day5;
using System.Text.RegularExpressions;

string[] rawData = File.ReadAllLines("RawData.txt");
Cargo cargo = new Cargo();

foreach (var s in rawData.Take(8).Reverse())
{
    for (int i = 1; i <= 9; i++)
    {
        int index = i - 1 + (i - 1) * 3;
        var cargoItem = s.Skip(index).Take(3).ToArray();
        if (cargoItem[1] == ' ')
        {
            continue;
        }

        cargo.Add(cargoItem[1], i);
    }
}

var mask = new Regex("move (\\d+) from (\\d+) to (\\d+)");

foreach (var s in rawData.Skip(10))
{
    var match = mask.Match(s);
    cargo.Move(int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value));
}

var top = cargo.Top();
Console.WriteLine("Part one");
Console.WriteLine($"Top: {top}");
Console.ReadKey();


cargo = new Cargo();

foreach (var s in rawData.Take(8).Reverse())
{
    for (int i = 1; i <= 9; i++)
    {
        int index = i - 1 + (i - 1) * 3;
        var cargoItem = s.Skip(index).Take(3).ToArray();
        if (cargoItem[1] == ' ')
        {
            continue;
        }

        cargo.Add(cargoItem[1], i);
    }
}

foreach (var s in rawData.Skip(10))
{
    var match = mask.Match(s);
    cargo.Move1(int.Parse(match.Groups[1].Value), int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value));
}

top = cargo.Top();
Console.WriteLine("Part two");
Console.WriteLine($"Top: {top}");
Console.ReadKey();
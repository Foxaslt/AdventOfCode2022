// See https://aka.ms/new-console-template for more information

using Day1;

string[] rawData = File.ReadAllLines("RawData.txt");

List<IElf> elves = new List<IElf>();
IElf elf = null;

foreach (var line in rawData)
{
    if (string.IsNullOrEmpty(line))
    {
        elf = new Elf();
        elves.Add(elf);
    }
    else
    {
        if (elf == null)
        {
            elf = new Elf();
            elves.Add(elf);
        }

        elf.AddCalories(int.Parse(line));
    }
}

Console.WriteLine("Part one");
var maxCalories = elves.Max(e => e.GetTotalCalories());
Console.WriteLine($"Max calories: {maxCalories}");
Console.ReadLine();

Console.WriteLine("Part two");
var totalCalories = elves.OrderByDescending(e => e.GetTotalCalories()).Take(3).Sum(e=>e.GetTotalCalories());
Console.WriteLine($"Total calories carried by 3 elves: {totalCalories}");
Console.ReadLine();
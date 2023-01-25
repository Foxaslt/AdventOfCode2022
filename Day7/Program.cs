// See https://aka.ms/new-console-template for more information

using Day7;

ElfDir root = new ElfDir(null, null);

Builder builder = new Builder(root);

string line;
using StreamReader reader = new StreamReader("RawData.txt");
while ((line = reader.ReadLine()) != null)
    builder.Build(line);

Calculator calculator = new Calculator();
var size = calculator.GetSum(root);

Console.WriteLine($"Size: {size}");
Console.ReadKey();

var minSize = calculator.Check(root);
Console.WriteLine($"Min size: {minSize}");
Console.ReadKey();
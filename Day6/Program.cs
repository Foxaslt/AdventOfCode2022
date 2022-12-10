// See https://aka.ms/new-console-template for more information

string[] rawData = File.ReadAllLines("RawData.txt");
string data = rawData[0];
int packetStart = 0;
for (int i = 0; i < data.Length - 4; i++)
{
    var x = data.Skip(i).Take(4).GroupBy(c => c);
    if (x.Count() == 4)
    {
        packetStart = i + 4;
        break;
    }
}

Console.WriteLine("Part one");
Console.WriteLine($"Packet start: {packetStart}");
Console.ReadKey();


var messageStart = 0;
for (int i = 0; i < data.Length - 14; i++)
{
    var x = data.Skip(i).Take(14).GroupBy(c => c);
    if (x.Count() == 14)
    {
        messageStart = i + 14;
        break;
    }
}

Console.WriteLine("Part two");
Console.WriteLine($"Message start: {messageStart}");
Console.ReadKey();
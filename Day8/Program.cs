// See https://aka.ms/new-console-template for more information

using System.Threading.Tasks.Sources;

Console.WriteLine("Hello, World!");

string[] rawData = File.ReadAllLines("RawData.txt");

List<byte[]> data = rawData.Select(t => t.ToCharArray().Select(s => byte.Parse(s.ToString())).ToArray()).ToList();

int count = (data.Count - 1) * 2 + (data[0].Length - 1) * 2;

for (int i = 1; i < data.Count - 1; i++)
{
    for (int j = 1; j < data[i].Length - 1; j++)
    {
        byte item = data[i][j];
        if (VisibleFromLeft(data, i, j, item) ||
            VisibleFromRight(data, i, j, item) ||
            VisibleFromTop(data, i, j, item) ||
            VisibleFromBottom(data, i, j, item))
            count++;
    }
}

Console.WriteLine($@"Count: {count}");
Console.ReadKey();

var score = 0;
for (int i = 1; i < data.Count - 1; i++)
{
    for (int j = 1; j < data[i].Length - 1; j++)
    {
        byte item = data[i][j];
        var s = Score(data, i, j, item);
        if (s > score)
            score = s;
    }
}

Console.WriteLine($@"Score: {score}");
Console.ReadKey();

bool VisibleFromLeft(List<byte[]> bytesList, int i, int j, byte item1)
{
    return bytesList[i].Take(j).All(b => b < item1);
}

bool VisibleFromRight(List<byte[]> list, int i, int j, byte item)
{
    return list[i].Skip(j + 1).All(b => b < item);
}

bool VisibleFromTop(List<byte[]> data1, int i, int j, byte item)
{
    bool top1 = true;
    for (int k = 0; k < i; k++)
    {
        if (data1[k][j] < item) continue;
        top1 = false;
        break;
    }

    return top1;
}

bool VisibleFromBottom(List<byte[]> bytesList1, int i, int j, byte item)
{
    bool bottom1 = true;
    for (int k = i + 1; k < bytesList1.Count; k++)
    {
        if (bytesList1[k][j] < item) continue;
        bottom1 = false;
        break;
    }

    return bottom1;
}

int Score(List<byte[]> bytesList, int i, int j, byte item)
{
    var left = 0;
    for (int k = j - 1; k >= 0; k--)
    {
        if (bytesList[i][k] < item)
        {
            left++;
            continue;
        }

        if (bytesList[i][k] >= item)
        {
            left++;
            break;
        }
    }

    var right = 0;
    for (int k = j + 1; k < bytesList[i].Length; k++)
    {
        if (bytesList[i][k] < item)
        {
            right++;
            continue;
        }

        if (bytesList[i][k] >= item)
        {
            right++;
            break;
        }
    }

    var top = 0;
    for (int k = i - 1; k >= 0; k--)
    {
        if (bytesList[k][j] < item)
        {
            top++;
            continue;
        }

        if (bytesList[k][j] >= item)
        {
            top++;
            break;
        }
    }

    var bottom = 0;
    for (int k = i + 1; k < bytesList.Count; k++)
    {
        if (bytesList[k][j] < item)
        {
            bottom++;
            continue;
        }

        if (bytesList[k][j] >= item)
        {
            bottom++;
            break;
        }
    }

    return left * right * top * bottom;
}
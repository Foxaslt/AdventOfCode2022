// See https://aka.ms/new-console-template for more information

string[] rawData = File.ReadAllLines("RawData.txt");

const char lowerChar = 'a';
const char upperChar = 'A';
string str1;
string str2;
int len;
int sum = 0;


foreach (string s in rawData)
{
    len = s.Length;
    str1 = s.Substring(0, len / 2);
    str2 = s.Substring(len / 2);
    var commonChars = str1.ToCharArray().Intersect(str2.ToCharArray());
    
    sum += GetValue(commonChars);
}

Console.WriteLine("Part one");
Console.WriteLine($"Total sum: {sum}");
Console.ReadKey();

sum = 0;
for (int i = 0; i < rawData.Length; )
{
    var group = rawData.Skip(i).Take(3).ToList();
    var commonChars = group[0].ToCharArray().Intersect(group[1].ToCharArray()).Intersect(group[2].ToCharArray());
    
    sum += GetValue(commonChars);
    i += 3;
}

Console.WriteLine("Part two");
Console.WriteLine($"Total sum: {sum}");
Console.ReadKey();

int GetValue(IEnumerable<char> commonChars)
{
    int value;
    if (char.IsLower(commonChars.First()))
        value = commonChars.First() - lowerChar + 1;
    else
        value = commonChars.First() - upperChar + 27;
    return value;
}
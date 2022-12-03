namespace Day2
{
    internal interface IRule
    {
        int GetValue(char data);
        char ConvertToRps(char data);
    }
}

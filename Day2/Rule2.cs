namespace Day2
{
    internal class Rule2 : IRule
    {
        public int GetValue(char data)
        {
            return data switch
            {
                'X' => 1,
                'Y' => 2,
                'Z' => 3,
                _ => throw new ArgumentException()
            };
        }

        public char ConvertToRps(char data)
        {
            return data switch
            {
                'X' => 'R',
                'Y' => 'P',
                'Z' => 'S',
                _ => throw new ArgumentException()
            };
        }
    }
}

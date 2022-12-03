namespace Day2
{
    internal class Rule1 : IRule
    {
        public int GetValue(char data)
        {
            return data switch
            {
                'A' => 1,
                'B' => 2,
                'C' => 3,
                _ => throw new ArgumentException()
            };
        }

        public char ConvertToRps(char data)
        {
            return data switch
            {
                'A' => 'R',
                'B' => 'P',
                'C' => 'S',
                _ => throw new ArgumentException()
            };
        }
    }
}

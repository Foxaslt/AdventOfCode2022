namespace Day2
{
    internal class Game : IGame
    {
        private readonly IRule rule1;
        private readonly IRule rule2;
        private readonly IComparer<char> round;

        private char player1;
        private char player2;

        public Game(IRule rule1, IRule rule2, IComparer<char> round)
        {
            this.rule1 = rule1;
            this.rule2 = rule2;
            this.round = round;
        }

        public void Setup(string data)
        {
            var items = data.Split(' ');
            player1 = char.Parse(items[0]);
            player2 = char.Parse(items[1]);
        }

        public int Calculate()
        {
            int result = round.Compare(rule1.ConvertToRps(player1), rule2.ConvertToRps(player2)) + rule2.GetValue(player2);
            return result;
        }

        public int Calculate1()
        {
            int letter = round.Compare(rule1.ConvertToRps(player1), player2);
            int result = GetLetter(letter) + Get(rule1.ConvertToRps(player1), (char)letter);
            return result;
        }

        private int GetLetter(int i)
        {
            return i switch
            {
                'R' => 1,
                'P' => 2,
                'S' => 3,
                _ => throw new ArgumentException()
            };
        }

        private int Get(char x, char y)
        {
            if (x == 'R' && y == 'R') return 3;
            if (x == 'P' && y == 'P') return 3;
            if (x == 'S' && y == 'S') return 3;

            if (x == 'R' && y == 'P') return 6;
            if (x == 'R' && y == 'S') return 0;

            if (x == 'P' && y == 'R') return 0;
            if (x == 'P' && y == 'S') return 6;

            if (x == 'S' && y == 'R') return 6;
            if (x == 'S' && y == 'P') return 0;

            throw new NotImplementedException();
        }
    }
}

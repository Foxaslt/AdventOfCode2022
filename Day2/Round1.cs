namespace Day2
{
    internal class Round1 : IComparer<char>
    {
        public int Compare(char x, char y)
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

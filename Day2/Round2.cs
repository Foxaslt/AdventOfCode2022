namespace Day2
{
    internal class Round2 : IComparer<char>
    {
        public int Compare(char x, char y)
        {
            if (x == 'R' && y == 'X') return 'S'; // Loose
            if (x == 'P' && y == 'Y') return 'P'; // Draw
            if (x == 'S' && y == 'Z') return 'R'; // Win

            if (x == 'R' && y == 'Y') return 'R'; // Draw
            if (x == 'R' && y == 'Z') return 'P'; // Win

            if (x == 'P' && y == 'X') return 'R'; // Loose
            if (x == 'P' && y == 'Z') return 'S'; // Win

            if (x == 'S' && y == 'X') return 'P'; // Loose
            if (x == 'S' && y == 'Y') return 'S'; // Draw

            throw new NotImplementedException();
        }
    }
}

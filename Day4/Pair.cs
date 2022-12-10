namespace Day4
{
    internal class Pair : IPair
    {
        private int p1From;
        private int p2From;
        private int p1To;
        private int p2To;

        public Pair(int p1From, int p1To, int p2From, int p2To)
        {
            this.p1From = p1From;
            this.p2From = p2From;
            this.p1To = p1To;
            this.p2To = p2To;
        }
        public bool Intersect()
        {
            if ((p1From >= p2From && p1To <= p2To) ||
                (p2From >= p1From && p2To <= p1To))
            {
                return true;
            }

            return false;
        }

        public bool Overlap()
        {
            if ((p1From >= p2From && p1From <= p2To && p1To > p2From) ||
                (p1From < p2From && p1To >= p2From && p1To <= p2To) || Intersect())
                return true;
            return false;
        }
    }
}

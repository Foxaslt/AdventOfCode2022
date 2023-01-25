namespace Day7
{
    internal class Calculator
    {
        private readonly int topRange = 100000;
        private readonly int totalSpace = 70000000;
        private readonly int minUnusedSpace = 30000000;

        public int GetSum(IElfItem item)
        {
            return ((IElfDir)item).Calculate(topRange);
        }

        public int Check(IElfItem item)
        {
            var currentSpaceLeft = totalSpace - item.Size();
            return ((IElfDir)item).Calculate(currentSpaceLeft, minUnusedSpace, item.Size());
        }
    }
}

namespace Day7
{
    internal interface IElfDir
    {
        IElfItem GetFolderByName(string name);
        void Add(IElfItem item);
        int Calculate(int topRange);
        int Calculate(int currentSpaceLeft, int maxUnusedSpace, int minSize);
    }
}

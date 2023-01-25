namespace Day7
{
    internal interface IElfItem
    {
        string Name { get; }
        int Size();
        bool IsDir();
        IElfItem GetParent();
    }
}

namespace Day7
{
    internal interface ICommand
    {
        IElfItem Execute(IElfItem item, string line);
    }
}

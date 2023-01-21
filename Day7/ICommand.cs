namespace Day7
{
    internal interface ICommand
    {
        void Execute(string[] rawData, int index, ElfDir dir);
    }
}

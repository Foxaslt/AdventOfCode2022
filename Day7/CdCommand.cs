using System.Text.RegularExpressions;

namespace Day7
{
    internal class CdCommand : ICommand
    {
        public void Execute(string[] rawData, int index, ElfDir dir)
        {
            if (rawData[index] == "$ cd /")
            {

            }

            if (rawData[index] == "$ ls")
            {
                //dir.
            }

            Regex pattern = new Regex("\\$ cd ([a-z]+)");
            var match = pattern.Match(rawData[index]);
            if (match.Success)
            {
                ElfDir newDir = new ElfDir();
            }
        }
    }
}

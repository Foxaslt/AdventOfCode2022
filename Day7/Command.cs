using System.Text.RegularExpressions;

namespace Day7
{
    internal class Command : ICommand
    {
        public IElfItem Execute(IElfItem item, string line)
        {
            if (line == "$ cd /")
            {
                return item;
            }

            if (line == "$ cd ..")
            {
                return item.GetParent();
            }

            if (line == "$ ls")
            {
                return item;
            }

            Regex pattern = new Regex("\\$ cd ([a-z]+)");
            var match = pattern.Match(line);
            if (match.Success)
            {
                return ((IElfDir)item).GetFolderByName(match.Groups[1].Value);
            }
            return item;
        }
    }
}

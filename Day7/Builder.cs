namespace Day7
{
    internal class Builder
    {
        private readonly ICommand command = new Command();
        private IElfItem root;

        public Builder(IElfItem root)
        {
            this.root = root;
        }

        public void Build(string line)
        {
            if (IsCommand(line))
                root = command.Execute(root, line);
            else
            {
                string[] data = line.Split(' ');
                if (data[0] == "dir")
                {
                    ElfDir dir = new ElfDir(root, data[1]);
                    ((IElfDir)root).Add(dir);
                }
                else
                {
                    if (!int.TryParse(data[0], out int size)) return;
                    ElfFile file = new ElfFile(root, data[1], size);
                    ((IElfDir)root).Add(file);
                }
            }
        }


        private bool IsCommand(string line)
        {
            return line.StartsWith('$');
        }
    }
}

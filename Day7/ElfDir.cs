namespace Day7
{
    internal class ElfDir : IElfItem, IElfDir
    {
        private readonly IElfItem parent;

        private readonly List<IElfItem> items;

        public ElfDir(IElfItem parent, string name)
        {
            this.parent = parent;
            this.Name = name;
            items = new List<IElfItem>();
        }

        public string Name { get; }

        public int Size()
        {
            return items.Sum(f => f.Size());
        }

        public IElfItem GetParent()
        {
            return parent;
        }

        public IElfItem GetFolderByName(string name)
        {
            return items.First(i => i.IsDir() && i.Name.Equals(name));
        }

        public void Add(IElfItem item)
        {
            items.Add(item);
        }

        public bool IsDir()
        {
            return true;
        }

        public int Calculate(int topRange)
        {
            int sum = 0;

            if (this.Size() <= topRange)
                sum += Size();
            sum += items.Where(elfItem => elfItem.IsDir()).Sum(elfItem => ((IElfDir)elfItem).Calculate(topRange));
            return sum;
        }

        public int Calculate(int currentSpaceLeft, int maxUnusedSpace, int minSize)
        {
            foreach (var elfItem in items)
            {
                if (elfItem.IsDir())
                {
                    if (currentSpaceLeft + elfItem.Size() >= maxUnusedSpace)
                    {
                        var size = ((IElfDir)elfItem).Calculate(currentSpaceLeft, maxUnusedSpace, elfItem.Size());
                        minSize = size < minSize ? size : minSize;
                    }
                }
            }

            return minSize;
        }
    }
}

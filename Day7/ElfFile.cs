namespace Day7
{
    internal class ElfFile : IElfItem
    {
        private readonly int size;
        private readonly IElfItem parent;
        public string Name { get; }

        public ElfFile(IElfItem parent, string name, int size)
        {
            this.parent = parent;
            this.Name = name;
            this.size = size;
        }
        public int Size()
        {
            return size;
        }

        public IElfItem GetParent()
        {
            return parent;
        }

        public bool IsDir()
        {
            return false;
        }
    }
}

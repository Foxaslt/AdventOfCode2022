namespace Day1
{
    internal static class Helper
    {
        public static List<IElf> FormatData(IEnumerable<string> rawData)
        {
            List<IElf> elves = new();
            IElf elf = null;

            foreach (var line in rawData)
            {
                if (string.IsNullOrEmpty(line))
                {
                    elf = new Elf();
                    elves.Add(elf);
                }
                else
                {
                    if (elf == null)
                    {
                        elf = new Elf();
                        elves.Add(elf);
                    }

                    elf.AddCalories(int.Parse(line));
                }
            }
            return elves;
        }
    }
}

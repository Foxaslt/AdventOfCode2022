namespace Day1
{
    internal class Elf : IElf
    {
        private readonly List<int> calories = new List<int>();

        public void AddCalories(int item)
        {
            calories.Add(item);
        }

        public int GetTotalCalories()
        {
            return calories.Sum();
        }
    }
}

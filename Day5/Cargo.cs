using System.Text;

namespace Day5
{
    internal class Cargo
    {
        private Stack<char>[] cargo = new Stack<char>[9];

        public Cargo()
        {
            for (int i = 0; i < 9; i++)
            {
                cargo[i] = new Stack<char>();
            }
        }
        public void Add(char c, int stack)
        {
            cargo[stack-1].Push(c);
        }

        public void Move(int count, int from, int to)
        {
            Queue<char> temp = new Queue<char>();
            for (int i = 0; i < count; i++)
            {
                temp.Enqueue(cargo[from - 1].Pop());
            }

            for (int i = 0; i < count; i++)
            {
                cargo[to - 1].Push(temp.Dequeue());
            }
        }

        public void Move1(int count, int from, int to)
        {
            Stack<char> temp = new Stack<char>();
            for (int i = 0; i < count; i++)
            {
                temp.Push(cargo[from - 1].Pop());
            }

            for (int i = 0; i < count; i++)
            {
                cargo[to - 1].Push(temp.Pop());
            }
        }

        public string Top()
        {
            StringBuilder top = new StringBuilder();
            for (int i = 0; i < 9; i++)
            {
                top.Append(cargo[i].Peek());
            }
            return top.ToString();
        }
    }
}

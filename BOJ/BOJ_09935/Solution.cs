namespace Algorithm.BOJ.BOJ_09935
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09935/input1.txt",
            "BOJ/BOJ_09935/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string str = Console.ReadLine()!;
            string bomb = Console.ReadLine()!;

            StringStack stringStack = new(str.Length);
            foreach (char c in str)
            {
                stringStack.Push(c);
                stringStack.TryRemove(bomb);
            }

            Console.WriteLine(stringStack.Count > 0 ? stringStack.ToString() : "FRULA");
        }

        private class StringStack
        {
            private char[] m_stack;
            private int m_index;

            public int Count { get => m_index; }

            public StringStack(int capacity)
            {
                m_stack = new char[capacity];
                m_index = 0;
            }

            public void Push(char c)
            {
                m_stack[m_index++] = c;
            }

            public bool TryRemove(string s)
            {
                if (Count < s.Length) return false;

                for (int i = 1; i <= s.Length; i++)
                    if (s[^i] != m_stack[Count - i])
                        return false;

                m_index -= s.Length;
                return true;
            }

            public override string ToString()
            {
                StringBuilder sb = new();
                for (int i = 0; i < Count; i++) sb.Append(m_stack[i]);
                return sb.ToString();
            }
        }
    }
}

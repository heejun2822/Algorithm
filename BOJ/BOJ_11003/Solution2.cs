namespace Algorithm.BOJ.BOJ_11003
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11003/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), L = ReadInt(sr);

            Deque deque = new(L);
            System.Text.StringBuilder arrD = new();

            for (int i = 0; i < N; i++)
            {
                int A = ReadInt(sr);

                if (deque.Count > 0 && deque.PeekFront().idx == i - L)
                    deque.PopFront();

                while (deque.Count > 0)
                    if (deque.PeekBack().val >= A)
                        deque.PopBack();
                    else
                        break;

                deque.PushBack(i, A);

                arrD.Append(deque.PeekFront().val).Append(' ');
            }

            sw.WriteLine(arrD);

            sr.Close();
            sw.Close();
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }

        private class Deque
        {
            private int m_Capacity;
            private (int idx, int val)[] m_Deque;
            private int m_Front = 0;
            private int m_Back = 0;

            public int Count { get; private set; }

            public Deque(int capacity)
            {
                m_Capacity = capacity;
                m_Deque = new (int, int)[capacity];
            }

            public void PushBack(int idx, int val)
            {
                m_Deque[m_Back] = (idx, val);
                m_Back = (m_Back + 1) % m_Capacity;
                Count++;
            }

            public void PopFront()
            {
                m_Front = (m_Front + 1) % m_Capacity;
                Count--;
            }

            public void PopBack()
            {
                m_Back = (m_Back - 1 + m_Capacity) % m_Capacity;
                Count--;
            }

            public (int idx, int val) PeekFront()
            {
                return m_Deque[m_Front];
            }

            public (int idx, int val) PeekBack()
            {
                return m_Deque[(m_Back - 1 + m_Capacity) % m_Capacity];
            }
        }
    }
}

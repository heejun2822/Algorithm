namespace Algorithm.BOJ.BOJ_05977
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05977/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), K = ReadInt(sr);

            (long inc, long exc)[] maxTotalE = new (long, long)[N + 1];
            Deque deque = new(K);

            for (int i = 1; i <= N; i++)
            {
                int E = ReadInt(sr);

                maxTotalE[i].exc = Math.Max(maxTotalE[i - 1].inc, maxTotalE[i - 1].exc);

                if (deque.Count > 0 && deque.PeekFront().idx == i - K - 1)
                    deque.PopFront();

                while (deque.Count > 0 && deque.PeekBack().val <= maxTotalE[i - 1].exc)
                    deque.PopBack();

                deque.PushBack(i - 1, maxTotalE[i - 1].exc, E);

                maxTotalE[i].inc = deque.PeekFront().val;
            }

            sw.WriteLine(Math.Max(maxTotalE[N].inc, maxTotalE[N].exc));

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
            private (int idx, long val)[] m_Deque;
            private int m_Front = 0;
            private int m_Back = 0;
            public int Count { get; private set; }

            public Deque(int capacity)
            {
                m_Capacity = capacity;
                m_Deque = new (int, long)[capacity];
            }

            public void PushBack(int idx, long val, int E)
            {
                m_Deque[m_Back] = (idx, val);
                m_Back = (m_Back + 1) % m_Capacity;
                Count++;

                for (int i = 0; i < Count; i++)
                    m_Deque[(m_Front + i) % m_Capacity].val += E;
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

            public (int idx, long val) PeekFront()
            {
                return m_Deque[m_Front];
            }

            public (int idx, long val) PeekBack()
            {
                return m_Deque[(m_Back - 1 + m_Capacity) % m_Capacity];
            }
        }
    }
}

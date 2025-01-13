namespace Algorithm.BOJ.BOJ_11286
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11286/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            AbsHeap absHeap = new(100000);
            for (int _ = 0; _ < N; _++)
            {
                int x = int.Parse(sr.ReadLine()!);
                if (x == 0) sw.WriteLine(absHeap.TryPop(out int ele) ? ele : "0");
                else absHeap.Push(x);
            }

            sr.Close();
            sw.Close();
        }

        private class AbsHeap
        {
            int[] m_Heap;
            int m_Count;

            public AbsHeap(int capacity)
            {
                m_Heap = new int[capacity + 1];
                m_Count = 0;
            }

            private int Compare(int a, int b)
            {
                if (Math.Abs(a) == Math.Abs(b)) return a - b;
                return Math.Abs(a) - Math.Abs(b);
            }

            public void Push(int ele)
            {
                m_Heap[++m_Count] = ele;

                int cIdx = m_Count;
                while (cIdx > 1)
                {
                    int pIdx = cIdx / 2;
                    if (Compare(m_Heap[pIdx], m_Heap[cIdx]) <= 0) break;
                    (m_Heap[cIdx], m_Heap[pIdx]) = (m_Heap[pIdx], m_Heap[cIdx]);
                    cIdx = pIdx;
                }
            }

            public int Pop()
            {
                int ele = m_Heap[1];
                m_Heap[1] = m_Heap[m_Count--];

                int pIdx = 1;
                while (pIdx * 2 <= m_Count)
                {
                    int cIdx = pIdx * 2;
                    if (cIdx + 1 <= m_Count && Compare(m_Heap[cIdx + 1], m_Heap[cIdx]) < 0) cIdx++;
                    if (Compare(m_Heap[pIdx], m_Heap[cIdx]) <= 0) break;
                    (m_Heap[pIdx], m_Heap[cIdx]) = (m_Heap[cIdx], m_Heap[pIdx]);
                    pIdx = cIdx;
                }

                return ele;
            }

            public bool TryPop(out int ele)
            {
                if (m_Count == 0)
                {
                    ele = 0;
                    return false;
                }

                ele = Pop();
                return true;
            }
        }
    }
}

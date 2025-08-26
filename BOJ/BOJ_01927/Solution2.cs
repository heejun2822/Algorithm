namespace Algorithm.BOJ.BOJ_01927
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01927/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            MinHeap minHeap = new();
            for (int _ = 0; _ < N; _++)
            {
                int x = int.Parse(sr.ReadLine()!);
                if (x == 0) sw.WriteLine(minHeap.TryPop(out int ele) ? ele : "0");
                else minHeap.Push(x);
            }

            sr.Close();
            sw.Close();
        }

        private class MinHeap
        {
            List<int> m_List = new() {0};

            public int Count { get => m_List.Count - 1; }

            public void Push(int ele)
            {
                m_List.Add(ele);

                int cIdx = Count;
                while (cIdx > 1)
                {
                    int pIdx = cIdx / 2;
                    if (m_List[cIdx] >= m_List[pIdx]) break;
                    (m_List[cIdx], m_List[pIdx]) = (m_List[pIdx], m_List[cIdx]);
                    cIdx = pIdx;
                }
            }

            public int Pop()
            {
                int ele = m_List[1];
                m_List[1] = m_List[Count];
                m_List.RemoveAt(Count);

                int pIdx = 1;
                while (pIdx * 2 <= Count)
                {
                    int cIdx = pIdx * 2;
                    if (cIdx + 1 <= Count && m_List[cIdx + 1] < m_List[cIdx]) cIdx++;
                    if (m_List[pIdx] < m_List[cIdx]) break;
                    (m_List[pIdx], m_List[cIdx]) = (m_List[cIdx], m_List[pIdx]);
                    pIdx = cIdx;
                }

                return ele;
            }

            public bool TryPop(out int ele)
            {
                if (Count == 0)
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

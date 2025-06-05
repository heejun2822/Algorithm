namespace Algorithm.BOJ.BOJ_11003
{
    public class Solution
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

            MinHeap minHeap = new(L);
            System.Text.StringBuilder arrD = new();

            for (int _ = 0; _ < N; _++)
            {
                int A = ReadInt(sr);
                minHeap.Push(A);
                arrD.Append(minHeap.Peek()).Append(' ');
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

        private class MinHeap
        {
            private int m_Capacity;
            private Node[] m_Nodes;
            private Node[] m_Heap;
            private int m_Count = 0;
            private int m_Index = 0;

            public MinHeap(int capacity)
            {
                m_Capacity = capacity;
                m_Nodes = new Node[capacity];
                m_Heap = new Node[capacity];
            }

            public void Push(int ele)
            {
                Node node = new(ele);
                node.HeapIdx = m_Count < m_Capacity ? m_Index : m_Nodes[m_Index].HeapIdx;

                m_Nodes[m_Index] = node;
                m_Heap[node.HeapIdx] = node;
                Heapify(node.HeapIdx);

                m_Count = Math.Min(m_Count + 1, m_Capacity);
                m_Index = (m_Index + 1) % m_Capacity;
            }

            public int Peek()
            {
                return m_Heap[0].Value;
            }

            private void Heapify(int idx)
            {
                while (idx > 0)
                {
                    int pIdx = (idx - 1) / 2;

                    if (m_Heap[idx].Value >= m_Heap[pIdx].Value) break;

                    Switch(idx, pIdx);
                    idx = pIdx;
                }

                while (idx < m_Count)
                {
                    int cIdx = idx * 2 + 1;
                    if (cIdx >= m_Count) break;
                    if (cIdx + 1 < m_Count && m_Heap[cIdx + 1].Value < m_Heap[cIdx].Value) cIdx++;

                    if (m_Heap[idx].Value <= m_Heap[cIdx].Value) break;

                    Switch(idx, cIdx);
                    idx = cIdx;
                }
            }

            private void Switch(int idx1, int idx2)
            {
                (m_Heap[idx1], m_Heap[idx2]) = (m_Heap[idx2], m_Heap[idx1]);
                m_Heap[idx1].HeapIdx = idx1;
                m_Heap[idx2].HeapIdx = idx2;
            }
        }

        private class Node
        {
            public int Value { get; private set; }
            public int HeapIdx { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }
    }
}

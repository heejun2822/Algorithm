namespace Algorithm.BOJ.BOJ_28279
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28279/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            Deque<int> deque = new(N - 1);

            for (int _ = 0; _ < N; _++)
            {
                string[] commands = sr.ReadLine()!.Split();
                switch (commands[0])
                {
                    case "1":
                        deque.PushFront(int.Parse(commands[1]));
                        break;
                    case "2":
                        deque.PushRear(int.Parse(commands[1]));
                        break;
                    case "3":
                        sw.WriteLine(deque.TryPopFront(out int poppedF) ? poppedF : "-1");
                        break;
                    case "4":
                        sw.WriteLine(deque.TryPopRear(out int poppedR) ? poppedR : "-1");
                        break;
                    case "5":
                        sw.WriteLine(deque.Count);
                        break;
                    case "6":
                        sw.WriteLine(deque.Count == 0 ? "1" : "0");
                        break;
                    case "7":
                        sw.WriteLine(deque.TryPeekFront(out int peekedF) ? peekedF : "-1");
                        break;
                    case "8":
                        sw.WriteLine(deque.TryPeekRear(out int peekedR) ? peekedR : "-1");
                        break;
                    default:
                        break;
                }
            }

            sr.Close();
            sw.Close();
        }

        // 덱 (Deque)
        private class Deque<T>
        {
            private readonly int m_size;
            private readonly T[] m_deque;
            private int m_front;
            private int m_rear;

            public Deque(int size)
            {
                m_size = size;
                m_deque = new T[size + 1];
                m_front = 0;
                m_rear = m_deque.Length - 1;
            }

            private int FrontIdx
            {
                get => m_front;
                set => m_front = (value + m_deque.Length) % m_deque.Length;
            }

            private int RearIdx
            {
                get => m_rear;
                set => m_rear = (value + m_deque.Length) % m_deque.Length;
            }

            public int Count
            {
                get => (m_deque.Length - m_front + m_rear + 1) % m_deque.Length;
            }

            public bool PushFront(T ele)
            {
                if (Count == m_size) return false;
                FrontIdx--;
                m_deque[FrontIdx] = ele;
                return true;
            }

            public bool PushRear(T ele)
            {
                if (Count == m_size) return false;
                RearIdx++;
                m_deque[RearIdx] = ele;
                return true;
            }

            private bool TryPeek(int idx, out T ele)
            {
                ele = default!;
                if (Count == 0) return false;
                ele = m_deque[idx];
                return true;
            }

            public bool TryPeekFront(out T ele)
            {
                return TryPeek(FrontIdx, out ele);
            }

            public bool TryPeekRear(out T ele)
            {
                return TryPeek(RearIdx, out ele);
            }

            public bool TryPopFront(out T ele)
            {
                if (!TryPeek(FrontIdx, out ele)) return false;
                FrontIdx++;
                return true;
            }

            public bool TryPopRear(out T ele)
            {
                if (!TryPeek(RearIdx, out ele)) return false;
                RearIdx--;
                return true;
            }
        }
    }
}

namespace Algorithm.BOJ.BOJ_01202
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01202/input1.txt",
            "BOJ/BOJ_01202/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int K = ReadInt(sr);

            (int M, int V)[] jewels = new (int, int)[N];
            for (int i = 0; i < N; i++)
                jewels[i] = (ReadInt(sr), ReadInt(sr));
            Array.Sort(jewels);

            int[] bags = new int[K];
            for (int i = 0; i < K; i++)
                bags[i] = ReadInt(sr);
            Array.Sort(bags);

            PriorityQueue<int, int> priorityQueue = new();
            long maxValue = 0;

            int jIdx = 0;
            foreach (int C in bags)
            {
                while (jIdx < N && jewels[jIdx].M <= C)
                {
                    int V = jewels[jIdx++].V;
                    priorityQueue.Enqueue(V, -V);
                }
                if (priorityQueue.Count > 0)
                    maxValue += priorityQueue.Dequeue();
            }

            sw.WriteLine(maxValue);

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
    }
}

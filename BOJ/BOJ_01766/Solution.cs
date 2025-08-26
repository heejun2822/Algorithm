namespace Algorithm.BOJ.BOJ_01766
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01766/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int M = ReadInt(sr);

            List<int>[] outLists = new List<int>[N + 1];
            int[] inDegrees = new int[N + 1];

            for (int p = 1; p <= N; p++) outLists[p] = new();
            for (int _ = 0; _ < M; _++)
            {
                int A = ReadInt(sr), B = ReadInt(sr);
                outLists[A].Add(B);
                inDegrees[B]++;
            }

            PriorityQueue<int, int> priorityQueue = new();

            for (int p = 1; p <= N; p++)
            {
                if (inDegrees[p] == 0) priorityQueue.Enqueue(p, p);
            }

            StringBuilder sequence = new();

            while (priorityQueue.Count > 0)
            {
                int p = priorityQueue.Dequeue();

                sequence.Append(p).Append(' ');

                foreach (int op in outLists[p])
                {
                    if (--inDegrees[op] == 0) priorityQueue.Enqueue(op, op);
                }
            }

            sw.WriteLine(sequence);

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

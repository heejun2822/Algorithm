namespace Algorithm.BOJ.BOJ_02252
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02252/input1.txt",
            "BOJ/BOJ_02252/input2.txt",
        ];

        // 위상 정렬 (Topological Sort)
        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int M = ReadInt(sr);

            List<int>[] edgeLists = new List<int>[N + 1];
            int[] inDegrees = new int[N + 1];

            for (int i = 1; i <= N; i++) edgeLists[i] = new();
            for (int _ = 0; _ < M; _++)
            {
                int f = ReadInt(sr);
                int t = ReadInt(sr);
                edgeLists[f].Add(t);
                inDegrees[t]++;
            }

            Queue<int> queue = new();

            for (int node = 1; node <= N; node++)
            {
                if (inDegrees[node] == 0) queue.Enqueue(node);
            }

            StringBuilder sequence = new();

            while (queue.Count > 0)
            {
                int node = queue.Dequeue();

                sequence.Append(node).Append(' ');

                foreach (int nextNode in edgeLists[node])
                {
                    if (--inDegrees[nextNode] == 0) queue.Enqueue(nextNode);
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

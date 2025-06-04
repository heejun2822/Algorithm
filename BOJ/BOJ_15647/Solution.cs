namespace Algorithm.BOJ.BOJ_15647
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_15647/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            Dictionary<int, int>[] edgeLengths = new Dictionary<int, int>[N + 1];

            for (int i = 1; i <= N; i++) edgeLengths[i] = new();
            for (int _ = 0; _ < N - 1; _++)
            {
                int u = ReadInt(sr), v = ReadInt(sr), d = ReadInt(sr);
                edgeLengths[u].Add(v, d);
                edgeLengths[v].Add(u, d);
            }

            int[] subTreeSizes = new int[N + 1];
            long[] minDistanceSums = new long[N + 1];

            int root = 1;
            MeasureSubTreeSizes(root);
            MeasureMinDistanceSums(root);

            System.Text.StringBuilder answer = new();

            for (int i = 1; i <= N; i++)
                answer.AppendLine(minDistanceSums[i].ToString());

            sw.Write(answer);

            sr.Close();
            sw.Close();

            void MeasureSubTreeSizes(int node)
            {
                subTreeSizes[node] = 1;

                foreach (int child in edgeLengths[node].Keys)
                {
                    if (subTreeSizes[child] > 0) continue;

                    MeasureSubTreeSizes(child);
                    subTreeSizes[node] += subTreeSizes[child];
                    minDistanceSums[root] += subTreeSizes[child] * edgeLengths[node][child];
                }
            }

            void MeasureMinDistanceSums(int node)
            {
                foreach (int child in edgeLengths[node].Keys)
                {
                    if (minDistanceSums[child] > 0) continue;

                    minDistanceSums[child] = minDistanceSums[node] - (subTreeSizes[child] - (N - subTreeSizes[child])) * edgeLengths[node][child];
                    MeasureMinDistanceSums(child);
                }
            }
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

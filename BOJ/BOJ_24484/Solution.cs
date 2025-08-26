namespace Algorithm.BOJ.BOJ_24484
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24484/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr), R = ReadInt(sr);

            List<int>[] edgeLists = new List<int>[N + 1];

            for (int i = 1; i <= N; i++) edgeLists[i] = new();
            for (int _ = 0; _ < M; _++)
            {
                int u = ReadInt(sr), v = ReadInt(sr);
                edgeLists[u].Add(v);
                edgeLists[v].Add(u);
            }

            bool[] visited = new bool[N + 1];
            long sum = 0;

            DFS(R, 0, 1);

            sw.WriteLine(sum);

            sr.Close();
            sw.Close();

            long DFS(int v, long d, long t)
            {
                visited[v] = true;

                sum += d * t++;

                edgeLists[v].Sort((a, b) => b - a);

                foreach (int u in edgeLists[v])
                    if (!visited[u])
                        t = DFS(u, d + 1, t);

                return t;
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

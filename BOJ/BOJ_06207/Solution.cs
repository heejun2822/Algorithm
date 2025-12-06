namespace Algorithm.BOJ.BOJ_06207
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06207/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int K = ReadInt(sr), N = ReadInt(sr), M = ReadInt(sr);
            int[] grazingPastures = new int[K];
            List<int>[] pathList = new List<int>[N + 1];

            for (int i = 0; i < K; i++)
                grazingPastures[i] = ReadInt(sr);

            for (int i = 1; i <= N; i++)
                pathList[i] = new();

            for (int _ = 0; _ < M; _++)
            {
                int A = ReadInt(sr), B = ReadInt(sr);
                pathList[A].Add(B);
            }

            int[] reachableCows = new int[N + 1];
            bool[] visited = new bool[N + 1];

            foreach (int p in grazingPastures)
            {
                Array.Fill(visited, false);
                DFS(p);
            }

            int cnt = 0;

            for (int p = 1; p <= N; p++)
                if (reachableCows[p] == K)
                    cnt++;

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();

            void DFS(int p)
            {
                if (visited[p]) return;

                reachableCows[p]++;
                visited[p] = true;

                foreach (int nextP in pathList[p])
                    DFS(nextP);
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

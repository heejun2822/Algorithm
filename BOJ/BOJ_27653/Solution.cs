namespace Algorithm.BOJ.BOJ_27653
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27653/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] A = new int[N + 1];
            List<int>[] edgeLists = new List<int>[N + 1];

            for (int i = 1; i <= N; i++)
            {
                A[i] = ReadInt(sr);
                edgeLists[i] = new();
            }

            for (int _ = 0; _ < N - 1; _++)
            {
                int u = ReadInt(sr), v = ReadInt(sr);
                edgeLists[u].Add(v);
                edgeLists[v].Add(u);
            }

            long cnt = 0;
            Traverse(1, 0);

            sw.WriteLine(cnt);

            sr.Close();
            sw.Close();

            void Traverse(int node, int prevNode)
            {
                cnt += Math.Max(A[node] - A[prevNode], 0);

                foreach (int nextNode in edgeLists[node])
                    if (nextNode != prevNode)
                        Traverse(nextNode, node);
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

namespace Algorithm.BOJ.BOJ_01778
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01778/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int caseNum = 1;
            List<int>[] edgeList;
            bool[] visited;
            System.Text.StringBuilder output = new();

            while (true)
            {
                int n = ReadInt(sr), m = ReadInt(sr);

                if (n == 0 && m == 0) break;

                edgeList = new List<int>[n + 1];
                visited = new bool[n + 1];

                for (int i = 1; i <= n; i++)
                    edgeList[i] = new();

                for (int _ = 0; _ < m; _++)
                {
                    int i = ReadInt(sr), j = ReadInt(sr);
                    edgeList[i].Add(j);
                    edgeList[j].Add(i);
                }

                int cnt = 0;

                for (int i = 1; i <= n; i++)
                    if (DFS(i))
                        cnt++;

                output.AppendLine($"Case {caseNum++}: {cnt}");
            }

            sw.Write(output);

            sr.Close();
            sw.Close();

            bool DFS(int a)
            {
                if (visited[a])
                    return false;

                visited[a] = true;

                foreach (int b  in edgeList[a])
                    DFS(b);

                return true;
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

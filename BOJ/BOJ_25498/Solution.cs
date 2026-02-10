namespace Algorithm.BOJ.BOJ_25498
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25498/input1.txt",
            "BOJ/BOJ_25498/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            string str = ' ' + sr.ReadLine()!;
            List<int>[] edgeLists = new List<int>[N + 1];

            for (int i = 1; i <= N; i++)
                edgeLists[i] = new();

            for (int _ = 0; _ < N - 1; _++)
            {
                int u = ReadInt(sr), v = ReadInt(sr);
                edgeLists[u].Add(v);
                edgeLists[v].Add(u);
            }

            List<int> currNodes = new();
            List<int> nextNodes = new();
            bool[] visited = new bool[N + 1];
            System.Text.StringBuilder handle = new();

            currNodes.Add(1);

            while (currNodes.Count > 0)
            {
                handle.Append(str[currNodes[0]]);

                nextNodes.Clear();
                char c = 'a';

                foreach (int u in currNodes)
                {
                    visited[u] = true;

                    foreach (int v in edgeLists[u])
                    {
                        if (visited[v] || str[v] < c) continue;

                        if (str[v] > c)
                        {
                            nextNodes.Clear();
                            c = str[v];
                        }
                        nextNodes.Add(v);
                    }
                }

                (currNodes, nextNodes) = (nextNodes, currNodes);
            }

            sw.WriteLine(handle);

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

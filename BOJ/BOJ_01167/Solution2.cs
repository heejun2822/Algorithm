namespace Algorithm.BOJ.BOJ_01167
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01167/input.txt",
        ];

        private static List<(int n, int d)>[] edgeLists = {};
        private static bool[] visited = {};
        private static int maxDis;
        private static int maxDisNode;

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int V = int.Parse(sr.ReadLine()!);

            edgeLists = new List<(int, int)>[V + 1];
            for (int _ = 0; _ < V; _++)
            {
                int[] info = Array.ConvertAll(sr.ReadLine()!.Split(), int.Parse);

                edgeLists[info[0]] = new();
                int edgeCnt = (info.Length - 2) / 2;

                for (int i = 0; i < edgeCnt; i++)
                    edgeLists[info[0]].Add((info[2 * i + 1], info[2 * i + 2]));
            }

            visited = new bool[V + 1];
            maxDis = 0;
            DFS(1, 0);

            Array.Fill(visited, false);
            maxDis = 0;
            DFS(maxDisNode, 0);

            sw.WriteLine(maxDis);

            sr.Close();
            sw.Close();
        }

        private static void DFS(int node, int dis)
        {
            visited[node] = true;

            if (dis > maxDis)
            {
                maxDis = dis;
                maxDisNode = node;
            }

            foreach ((int n, int d) in edgeLists[node])
            {
                if (visited[n]) continue;

                DFS(n, dis + d);
            }
        }
    }
}

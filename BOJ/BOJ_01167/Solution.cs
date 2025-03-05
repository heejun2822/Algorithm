namespace Algorithm.BOJ.BOJ_01167
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01167/input.txt",
        ];

        private static List<(int n, int d)>[] edgeLists = {};
        private static bool[] visited = {};

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

            int diameter = 0;
            DFS(1, ref diameter);

            sw.WriteLine(diameter);

            sr.Close();
            sw.Close();
        }

        private static int DFS(int node, ref int diameter)
        {
            visited[node] = true;

            int maxDis = 0;
            foreach ((int n, int d) in edgeLists[node])
            {
                if (visited[n]) continue;

                int dis = d + DFS(n, ref diameter);
                diameter = Math.Max(diameter, maxDis + dis);
                maxDis = Math.Max(maxDis, dis);
            }

            return maxDis;
        }
    }
}

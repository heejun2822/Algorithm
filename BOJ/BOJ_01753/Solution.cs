namespace Algorithm.BOJ.BOJ_01753
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01753/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            const int INF = 200_000;

            string[] ve = sr.ReadLine()!.Split();
            int V = int.Parse(ve[0]);
            int E = int.Parse(ve[1]);
            int K = int.Parse(sr.ReadLine()!);

            Dictionary<int, int>[] edges = new Dictionary<int, int>[V + 1];
            for (int i = 1; i <= V; i++) edges[i] = new();

            for (int _ = 0; _ < E; _++)
            {
                string[] edge = sr.ReadLine()!.Split();
                int u = int.Parse(edge[0]);
                int v = int.Parse(edge[1]);
                int w = int.Parse(edge[2]);

                if (!edges[u].TryAdd(v, w))
                    edges[u][v] = Math.Min(edges[u][v], w);
            }

            // 다익스트라 (Dijkstra)
            int[] dist = new int[V + 1];
            bool[] visited = new bool[V + 1];
            PriorityQueue<int, int> connected = new();

            for (int v = 1; v <= V; v++)
                dist[v] = v == K ? 0 : INF;

            connected.Enqueue(K, dist[K]);

            while (connected.Count > 0)
            {
                int u = connected.Dequeue();
                if (visited[u]) continue;

                visited[u] = true;

                foreach (int v in edges[u].Keys)
                {
                    if (visited[v]) continue;

                    dist[v] = Math.Min(dist[v], dist[u] + edges[u][v]);
                    connected.Enqueue(v, dist[v]);
                }
            }

            for (int i = 1; i <= V; i++)
                sw.WriteLine(dist[i] == INF ? "INF" : dist[i]);

            sr.Close();
            sw.Close();
        }
    }
}

namespace Algorithm.BOJ.BOJ_01504
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01504/input.txt",
        ];

        private static readonly int INF = 800_000;

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] ne = sr.ReadLine()!.Split();
            int N = int.Parse(ne[0]);
            int E = int.Parse(ne[1]);

            List<(int v, int d)>[] edgeLists = new List<(int, int)>[N + 1];
            for (int i = 1; i <= N; i++) edgeLists[i] = new();

            for (int _ = 0; _ < E; _++)
            {
                string[] abc = sr.ReadLine()!.Split();
                int a = int.Parse(abc[0]);
                int b = int.Parse(abc[1]);
                int c = int.Parse(abc[2]);
                edgeLists[a].Add((b, c));
                edgeLists[b].Add((a, c));
            }

            string[] v1v2 = sr.ReadLine()!.Split();
            int v1 = int.Parse(v1v2[0]);
            int v2 = int.Parse(v1v2[1]);

            sw.WriteLine(SearchMinDistance(N, edgeLists, v1, v2));

            sr.Close();
            sw.Close();
        }

        private static int SearchMinDistance(int N, List<(int, int)>[] edgeLists, int v1, int v2)
        {
            int[] dist = Dijkstra(N, edgeLists, 1);

            if (v1 == 1 && v2 == N)
            {
                return dist[N] == INF ? -1 : dist[N];
            }
            else if (v1 == 1 && v2 != N)
            {
                if (dist[v2] == INF) return -1;

                int minD = dist[v2];
                dist = Dijkstra(N, edgeLists, v2);

                return dist[N] == INF ? -1 : minD + dist[N];
            }
            else if (v1 != 1 && v2 == N)
            {
                if (dist[v1] == INF) return -1;

                int minD = dist[v1];
                dist = Dijkstra(N, edgeLists, v1);

                return dist[N] == INF ? -1 : minD + dist[N];
            }
            else
            {
                if (dist[v1] == INF || dist[v2] == INF) return -1;

                int minD1 = dist[v1];
                int minD2 = dist[v2];
                dist = Dijkstra(N, edgeLists, N);

                if (dist[v1] == INF || dist[v2] == INF) return -1;

                minD1 += dist[v2];
                minD2 += dist[v1];

                dist = Dijkstra(N, edgeLists, v1);

                return Math.Min(minD1 + dist[v2], minD2 + dist[v2]);
            }
        }

        private static int[] Dijkstra(int N, List<(int, int)>[] edgeLists, int s)
        {
            int[] dist = new int[N + 1];
            Array.Fill(dist, INF);
            bool[] visited = new bool[N + 1];
            PriorityQueue<int, int> connected = new();

            connected.Enqueue(s, dist[s] = 0);

            while (connected.Count > 0)
            {
                int u = connected.Dequeue();
                if (visited[u]) continue;

                visited[u] = true;

                foreach ((int v, int d) in edgeLists[u])
                {
                    if (visited[v]) continue;
                    dist[v] = Math.Min(dist[v], dist[u] + d);
                    connected.Enqueue(v, dist[v]);
                }
            }

            return dist;
        }
    }
}

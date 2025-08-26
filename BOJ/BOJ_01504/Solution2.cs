namespace Algorithm.BOJ.BOJ_01504
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
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

            int[] dist1 = Dijkstra(N, edgeLists, 1, new int[] { v1, v2 });
            if (dist1[0] == -1 || dist1[1] == -1)
            {
                sw.WriteLine("-1");
                goto End;
            }
            int[] distV = Dijkstra(N, edgeLists, v1, new int[] { v2 });
            if (distV[0] == -1)
            {
                sw.WriteLine("-1");
                goto End;
            }
            int[] distN = Dijkstra(N, edgeLists, N, new int[] { v1, v2 });
            if (distN[0] == -1 || distN[1] == -1)
            {
                sw.WriteLine("-1");
                goto End;
            }
            sw.WriteLine(Math.Min(dist1[0] + distV[0] + distN[1], dist1[1] + distV[0] + distN[0]));

            End:
            sr.Close();
            sw.Close();
        }

        private static int[] Dijkstra(int N, List<(int, int)>[] edgeLists, int s, int[] targets)
        {
            int[] minD = new int[targets.Length];
            Array.Fill(minD, -1);

            int[] dist = new int[N + 1];
            Array.Fill(dist, INF);
            PriorityQueue<int, int> connected = new();

            connected.Enqueue(s, dist[s] = 0);

            while (connected.Count > 0)
            {
                int u = connected.Dequeue();

                for (int i = 0; i < targets.Length; i++)
                    if (targets[i] == u)
                    {
                        minD[i] = dist[u];
                        if (Array.IndexOf(minD, -1) == -1) return minD;
                    }

                foreach ((int v, int d) in edgeLists[u])
                    if (dist[u] + d < dist[v])
                        connected.Enqueue(v, dist[v] = dist[u] + d);
            }

            return minD;
        }
    }
}

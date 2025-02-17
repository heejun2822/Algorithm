namespace Algorithm.BOJ.BOJ_09370
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_09370/input.txt",
        ];

        private static readonly int INF = 2_000_000;

        private static int n;
        private static List<(int b, int d)>[] roadLists = {};

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string[] nmt = sr.ReadLine()!.Split();
                n = int.Parse(nmt[0]);
                int m = int.Parse(nmt[1]);
                int t = int.Parse(nmt[2]);
                string[] sgh = sr.ReadLine()!.Split();
                int s = int.Parse(sgh[0]);
                int g = int.Parse(sgh[1]);
                int h = int.Parse(sgh[2]);

                roadLists = new List<(int, int)>[n + 1];
                for (int i = 1; i <= n; i++) roadLists[i] = new();
                for (int r = 0; r < m; r++)
                {
                    string[] abd = sr.ReadLine()!.Split();
                    int a = int.Parse(abd[0]);
                    int b = int.Parse(abd[1]);
                    int d = int.Parse(abd[2]);
                    roadLists[a].Add((b, d));
                    roadLists[b].Add((a, d));
                }

                int[] destinations = new int[t];
                for (int i = 0; i < t; i++) destinations[i] = int.Parse(sr.ReadLine()!);
                Array.Sort(destinations);

                Dictionary<int, int> minDistsFromS = new() { {g, -1}, {h, -1} };
                Dictionary<int, int> minDistsFromG = new();
                Dictionary<int, int> minDistsFromH = new();
                foreach (int x in destinations)
                {
                    minDistsFromS.TryAdd(x, -1);
                    minDistsFromG.Add(x, -1);
                    minDistsFromH.Add(x, -1);
                }

                Dijkstra(s, minDistsFromS);
                Dijkstra(g, minDistsFromG);
                Dijkstra(h, minDistsFromH);

                int distGH = roadLists[g].Find(r => r.b == h).d;
                foreach (int x in destinations)
                {
                    if (minDistsFromS[g] == -1 || minDistsFromS[x] == -1) continue;
                    if (
                        minDistsFromS[g] + distGH + minDistsFromH[x] == minDistsFromS[x] ||
                        minDistsFromS[h] + distGH + minDistsFromG[x] == minDistsFromS[x]
                    )
                        sw.Write($"{x} ");
                }
                sw.Write("\n");
            }

            sr.Close();
            sw.Close();
        }

        private static void Dijkstra(int s, Dictionary<int, int> minDists)
        {
            int cnt = 0;

            int[] dist = new int[n + 1];
            Array.Fill(dist, INF);
            PriorityQueue<int, int> connected = new();

            connected.Enqueue(s, dist[s] = 0);

            while (connected.Count > 0)
            {
                int a = connected.Dequeue();

                if (minDists.TryGetValue(a, out int minD) && minD == -1)
                {
                    minDists[a] = dist[a];
                    if (++cnt == minDists.Count) return;
                }

                foreach ((int b, int d) in roadLists[a])
                    if (dist[a] + d < dist[b])
                        connected.Enqueue(b, dist[b] = dist[a] + d);
            }
        }
    }
}

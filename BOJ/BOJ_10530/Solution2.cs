namespace Algorithm.BOJ.BOJ_10530
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10530/input1.txt",
            "BOJ/BOJ_10530/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int P = ReadInt(sr), T = ReadInt(sr);

            (int p1, int p2, int l)[] trails = new (int, int, int)[T];
            List<(int p, int l)>[] trailLists = new List<(int, int)>[P];
            for (int i = 0; i < P; i++)
                trailLists[i] = new();

            for (int i = 0; i < T; i++)
            {
                int p1 = ReadInt(sr), p2 = ReadInt(sr), l = ReadInt(sr);
                trails[i] = (p1, p2, l);
                trailLists[p1].Add((p2, l));
                trailLists[p2].Add((p1, l));
            }

            int[] minLengthE = Dijkstra(0);
            int[] minLengthP = Dijkstra(P - 1);

            int minL = minLengthE[P - 1];
            int totalLength = 0;

            foreach ((int p1, int p2, int l) in trails)
                if (minLengthE[p1] + l + minLengthP[p2] == minL || minLengthE[p2] + l + minLengthP[p1] == minL)
                    totalLength += l;

            sw.WriteLine(totalLength * 2);

            sr.Close();
            sw.Close();

            int[] Dijkstra(int sp)
            {
                PriorityQueue<int, int> prQueue = new();
                int[] minLength = new int[P];
                Array.Fill(minLength, int.MaxValue);
                bool[] visited = new bool[P];

                prQueue.Enqueue(sp, minLength[sp] = 0);

                while (prQueue.Count > 0)
                {
                    int cp = prQueue.Dequeue();

                    if (visited[cp]) continue;

                    visited[cp] = true;

                    foreach ((int np, int l) in trailLists[cp])
                    {
                        if (visited[np]) continue;

                        int len = minLength[cp] + l;
                        if (len < minLength[np])
                            prQueue.Enqueue(np, minLength[np] = len);
                    }
                }

                return minLength;
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

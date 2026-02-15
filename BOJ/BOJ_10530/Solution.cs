namespace Algorithm.BOJ.BOJ_10530
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
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

            List<(int p, int l)>[] trailLists = new List<(int, int)>[P];
            for (int i = 0; i < P; i++)
                trailLists[i] = new();

            for (int _ = 0; _ < T; _++)
            {
                int p1 = ReadInt(sr), p2 = ReadInt(sr), l = ReadInt(sr);
                trailLists[p1].Add((p2, l));
                trailLists[p2].Add((p1, l));
            }

            PriorityQueue<int, int> prQueue = new();
            int[] minLength = new int[P];
            Array.Fill(minLength, int.MaxValue);
            bool[] visited = new bool[P];

            List<(int p, int l)>[] trace = new List<(int, int)>[P];
            for (int i = 0; i < P; i++)
                trace[i] = new();

            prQueue.Enqueue(0, minLength[0] = 0);

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
                    {
                        prQueue.Enqueue(np, minLength[np] = len);
                        trace[np].Clear();
                        trace[np].Add((cp, l));
                    }
                    else if (len == minLength[np])
                    {
                        trace[np].Add((cp, l));
                    }
                }
            }

            Queue<int> queue = new();
            Array.Fill(visited, false);
            int totalLength = 0;

            queue.Enqueue(P - 1);

            while (queue.Count > 0)
            {
                int cp = queue.Dequeue();

                if (visited[cp]) continue;

                visited[cp] = true;

                foreach ((int pp, int l) in trace[cp])
                {
                    totalLength += l;
                    queue.Enqueue(pp);
                }
            }

            sw.WriteLine(totalLength * 2);

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

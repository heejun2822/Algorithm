namespace Algorithm.BOJ.BOJ_14618
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14618/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);
            int J = ReadInt(sr);
            int K = ReadInt(sr);
            int[] A = new int[K];
            int[] B = new int[K];

            for (int i = 0; i < K; i++)
                A[i] = ReadInt(sr);
            for (int i = 0; i < K; i++)
                B[i] = ReadInt(sr);

            List<(int h, int l)>[] roadLists = new List<(int, int)>[N + 1];
            for (int i = 1; i <= N; i++)
                roadLists[i] = new();

            for (int _ = 0; _ < M; _++)
            {
                int X = ReadInt(sr), Y = ReadInt(sr), Z = ReadInt(sr);
                roadLists[X].Add((Y, Z));
                roadLists[Y].Add((X, Z));
            }

            PriorityQueue<int, int> prQueue = new();
            int[] minDist = new int[N + 1];
            Array.Fill(minDist, int.MaxValue);
            bool[] visited = new bool[N + 1];

            prQueue.Enqueue(J, minDist[J] = 0);

            while (prQueue.Count > 0)
            {
                int ch = prQueue.Dequeue();

                if (visited[ch]) continue;

                visited[ch] = true;

                foreach ((int nh, int l) in roadLists[ch])
                {
                    if (visited[nh]) continue;

                    int dist = minDist[ch] + l;
                    if (dist < minDist[nh])
                        prQueue.Enqueue(nh, minDist[nh] = dist);
                }
            }

            int minDistA = int.MaxValue;
            int minDistB = int.MaxValue;

            foreach (int h in A)
                minDistA = Math.Min(minDistA, minDist[h]);
            foreach (int h in B)
                minDistB = Math.Min(minDistB, minDist[h]);

            if (minDistA == int.MaxValue && minDistB == int.MaxValue)
                sw.WriteLine(-1);
            else
                sw.WriteLine(minDistA <= minDistB ? $"A\n{minDistA}" : $"B\n{minDistB}");

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

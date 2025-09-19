namespace Algorithm.BOJ.BOJ_05972
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_05972/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr);

            Dictionary<int, int>[] cows = new Dictionary<int, int>[N + 1];
            for (int i = 1; i <= N; i++)
                cows[i] = new();

            for (int _ = 0; _ < M; _++)
            {
                int A = ReadInt(sr), B = ReadInt(sr), C = ReadInt(sr);
                if (!cows[A].TryAdd(B, C))
                    cows[A][B] = Math.Min(cows[A][B], C);
                if (!cows[B].TryAdd(A, C))
                    cows[B][A] = Math.Min(cows[B][A], C);
            }

            int[] minCows = new int[N + 1];
            Array.Fill(minCows, int.MaxValue);

            bool[] visited = new bool[N + 1];

            PriorityQueue<int, int> priorityQueue = new();
            priorityQueue.Enqueue(1, minCows[1] = 0);

            while (priorityQueue.Count > 0)
            {
                int barn = priorityQueue.Dequeue();

                if (visited[barn]) continue;

                visited[barn] = true;

                foreach (int neighborBarn in cows[barn].Keys)
                {
                    if (visited[neighborBarn]) continue;
                    if (minCows[barn] + cows[barn][neighborBarn] < minCows[neighborBarn])
                        priorityQueue.Enqueue(neighborBarn, minCows[neighborBarn] = minCows[barn] + cows[barn][neighborBarn]);
                }
            }

            sw.WriteLine(minCows[N]);

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

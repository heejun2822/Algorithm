namespace Algorithm.BOJ.BOJ_01238
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01238/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr), X = ReadInt(sr);
            List<(int, int)>[] roadListFrom = new List<(int, int)>[N + 1];
            List<(int, int)>[] roadListTo = new List<(int, int)>[N + 1];

            for (int i = 1; i <= N; i++)
            {
                roadListFrom[i] = new();
                roadListTo[i] = new();
            }

            for (int _ = 0; _ < M; _++)
            {
                int from = ReadInt(sr), to = ReadInt(sr), T = ReadInt(sr);
                roadListFrom[from].Add((to, T));
                roadListTo[to].Add((from, T));
            }

            int[] minTimeToX = Dijkstra(roadListTo, N, X);
            int[] minTimeFromX = Dijkstra(roadListFrom, N, X);
            int maxTime = 0;

            for (int i = 1; i <= N; i++)
                maxTime = Math.Max(maxTime, minTimeToX[i] + minTimeFromX[i]);

            sw.WriteLine(maxTime);

            sr.Close();
            sw.Close();
        }

        private static int[] Dijkstra(List<(int, int)>[] roadList, int N, int X)
        {
            int[] minTime = new int[N + 1];
            Array.Fill(minTime, int.MaxValue);

            bool[] visited = new bool[N + 1];

            PriorityQueue<int, int> priorityQueue = new();
            priorityQueue.Enqueue(X, minTime[X] = 0);

            while (priorityQueue.Count > 0)
            {
                int A = priorityQueue.Dequeue();

                if (!visited[A])
                    foreach ((int B, int T) in roadList[A])
                        if (!visited[B] && minTime[B] > minTime[A] + T)
                            priorityQueue.Enqueue(B, minTime[B] = minTime[A] + T);

                visited[A] = true;
            }

            return minTime;
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

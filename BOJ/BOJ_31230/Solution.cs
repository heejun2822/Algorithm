namespace Algorithm.BOJ.BOJ_31230
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31230/input1.txt",
            "BOJ/BOJ_31230/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr), A = ReadInt(sr), B = ReadInt(sr);

            List<(int D, int T)>[] roadLists = new List<(int, int)>[N + 1];

            for (int i = 1; i <= N; i++)
                roadLists[i] = new();

            for (int _ = 0; _ < M; _++)
            {
                int a = ReadInt(sr), b = ReadInt(sr), c = ReadInt(sr);
                roadLists[a].Add((b, c));
                roadLists[b].Add((a, c));
            }

            long[] minTime = new long[N + 1];
            Array.Fill(minTime, long.MaxValue);

            PriorityQueue<int, long> priorityQueue = new();
            priorityQueue.Enqueue(A, minTime[A] = 0);

            bool[] visited = new bool[N + 1];

            List<int>[] trace = new List<int>[N + 1];

            for (int i = 1; i <= N; i++)
                trace[i] = new();

            while (priorityQueue.Count > 0)
            {
                int V = priorityQueue.Dequeue();

                if (visited[V]) continue;

                visited[V] = true;

                foreach ((int D, int T) in roadLists[V])
                {
                    if (visited[D]) continue;

                    long time = minTime[V] + T;

                    if (time < minTime[D])
                    {
                        priorityQueue.Enqueue(D, minTime[D] = time);
                        trace[D].Clear();
                        trace[D].Add(V);
                    }
                    else if (time == minTime[D])
                    {
                        trace[D].Add(V);
                    }
                }
            }

            int cnt = 0;
            Array.Fill(visited, false);

            Queue<int> queue = new();
            queue.Enqueue(B);

            while (queue.Count > 0)
            {
                int V = queue.Dequeue();

                if (visited[V]) continue;

                visited[V] = true;
                cnt++;

                foreach (int U in trace[V])
                {
                    if (visited[U]) continue;

                    queue.Enqueue(U);
                }
            }

            sw.WriteLine(cnt);
            for (int i = 1; i <= N; i++)
                if (visited[i])
                    sw.Write(i + " ");
            sw.WriteLine();

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

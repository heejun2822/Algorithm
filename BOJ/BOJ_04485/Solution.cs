namespace Algorithm.BOJ.BOJ_04485
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04485/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int[] dr = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, -1, 1 };

            int tc = 1;
            int N;

            while ((N = ReadInt(sr)) != 0)
            {
                int[,] rupee = new int[N, N];
                int[,] minCost = new int[N, N];
                bool[,] visited = new bool[N, N];

                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        rupee[i, j] = ReadInt(sr);
                        minCost[i, j] = int.MaxValue;
                    }
                }

                PriorityQueue<(int r, int c), int> priorityQueue = new();

                priorityQueue.Enqueue((0, 0), minCost[0, 0] = rupee[0, 0]);

                while (priorityQueue.Count > 0)
                {
                    (int r, int c) = priorityQueue.Dequeue();

                    if (r == N - 1 && c == N - 1) break;
                    if (visited[r, c]) continue;

                    visited[r, c] = true;

                    for (int i = 0; i < 4; i++)
                    {
                        int nr = r + dr[i], nc = c + dc[i];

                        if (nr < 0 || nr >= N || nc < 0 || nc >= N) continue;
                        if (visited[nr, nc]) continue;

                        int newCost = minCost[r, c] + rupee[nr, nc];
                        if (newCost < minCost[nr, nc])
                            priorityQueue.Enqueue((nr, nc), minCost[nr, nc] = newCost);
                    }
                }

                sw.WriteLine($"Problem {tc++}: {minCost[N - 1, N - 1]}");
            }

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

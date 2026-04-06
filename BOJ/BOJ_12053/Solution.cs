namespace Algorithm.BOJ.BOJ_12053
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12053/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            const int INF = 10001;

            int T = ReadInt(sr);

            for (int x = 1; x <= T; x++)
            {
                int N = ReadInt(sr), M = ReadInt(sr), Q = ReadInt(sr);
                int[] V = new int[M];
                PriorityQueue<(int P, int H, int time, int energy), int> balloonQueue = new(N);

                for (int i = 0; i < M; i++)
                    V[i] = ReadInt(sr);

                for (int _ = 0; _ < N; _++)
                {
                    int P = ReadInt(sr), H = ReadInt(sr);
                    int time = CalcTime(P, V[H]);
                    balloonQueue.Enqueue((P, H, time, 0), -time);
                }

                int minTime = INF;

                while (true)
                {
                    (int P, int H, int time, int energy) = balloonQueue.Dequeue();
                    minTime = Math.Min(minTime, time);

                    Q += energy;

                    int newTime = INF;
                    int e = energy;
                    int lim = Math.Min(Q, Math.Max(H, M - H - 1));

                    while (newTime >= time && ++e <= lim)
                    {
                        if (H - e >= 0)
                            newTime = Math.Min(newTime, CalcTime(P, V[H - e]));
                        if (H + e < M)
                            newTime = Math.Min(newTime, CalcTime(P, V[H + e]));
                    }

                    if (newTime >= time) break;

                    Q -= e;
                    balloonQueue.Enqueue((P, H, newTime, e), -newTime);
                }

                sw.Write($"Case #{x}: ");
                sw.WriteLine(minTime == INF ? "IMPOSSIBLE" : minTime);
            }

            sr.Close();
            sw.Close();

            int CalcTime(int pos, int vel)
            {
                if (pos * vel >= 0)
                    return INF;
                return (Math.Abs(pos) + Math.Abs(vel) - 1) / Math.Abs(vel);
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

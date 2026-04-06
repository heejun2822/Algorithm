namespace Algorithm.BOJ.BOJ_12053
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
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

            int N, M, Q;
            int[] V;
            (int P, int H)[] balloons;

            int T = ReadInt(sr);

            for (int x = 1; x <= T; x++)
            {
                N = ReadInt(sr);
                M = ReadInt(sr);
                Q = ReadInt(sr);
                V = new int[M];
                balloons = new (int, int)[N];

                for (int i = 0; i < M; i++)
                    V[i] = ReadInt(sr);

                for (int i = 0; i < N; i++)
                    balloons[i] = (ReadInt(sr), ReadInt(sr));

                int minTime = INF;

                if (CanMakeItInTime(10000))
                {
                    int l = 0, r = 10000;

                    while (l < r)
                    {
                        int m = (l + r) / 2;

                        if (CanMakeItInTime(m))
                            r = m;
                        else
                            l = m + 1;
                    }

                    minTime = r;
                }

                sw.Write($"Case #{x}: ");
                sw.WriteLine(minTime == INF ? "IMPOSSIBLE" : minTime);
            }

            sr.Close();
            sw.Close();

            bool CanMakeItInTime(int timeLimit)
            {
                int totalEnergy = 0;

                foreach ((int P, int H) in balloons)
                {
                    int minEnergy = INF;

                    for (int h = 0; h < M; h++)
                        if (CalcTime(P, V[h]) <= timeLimit)
                            minEnergy = Math.Min(minEnergy, Math.Abs(H - h));

                    if ((totalEnergy += minEnergy) > Q)
                        return false;
                }

                return true;
            }

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

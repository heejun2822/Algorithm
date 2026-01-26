namespace Algorithm.BOJ.BOJ_25579
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_25579/input1.txt",
            "BOJ/BOJ_25579/input2.txt",
            "BOJ/BOJ_25579/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);
            int[] B = new int[N + 1];
            int[] P = new int[N];

            for (int i = 1; i <= N; i++)
                B[i] = ReadInt(sr);
            for (int i = 0; i < N; i++)
                P[i] = ReadInt(sr);

            int[] roots = new int[N + 1];
            Array.Fill(roots, -1);
            (long score, int size)[] segments = new (long, int)[N + 1];

            long score = 0;
            long maxScore = 0;

            for (int i = N - 1; i > 0; i--)
            {
                roots[P[i]] = 0;
                segments[P[i]] = (B[P[i]], 1);
                score += B[P[i]];

                if (P[i] - 1 >= 1)
                    score += Union(P[i], P[i] - 1);
                if (P[i] + 1 <= N)
                    score += Union(P[i], P[i] + 1);

                maxScore = Math.Max(maxScore, score);
            }

            sw.WriteLine(maxScore);

            sr.Close();
            sw.Close();

            long Union(int a, int b)
            {
                a = Find(a);
                b = Find(b);

                if (a == -1 || b == -1 || a == b) return 0;

                long ds = 0;
                ds -= segments[a].score * segments[a].size;
                ds -= segments[b].score * segments[b].size;

                if (a < b)
                {
                    roots[b] = a;
                    segments[a].score += segments[b].score;
                    segments[a].size += segments[b].size;
                    ds += segments[a].score * segments[a].size;
                }
                else
                {
                    roots[a] = b;
                    segments[b].score += segments[a].score;
                    segments[b].size += segments[a].size;
                    ds += segments[b].score * segments[b].size;
                }

                return ds;
            }

            int Find(int a)
            {
                if (roots[a] == -1)
                    return -1;
                if (roots[a] == 0)
                    return a;
                return roots[a] = Find(roots[a]);
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

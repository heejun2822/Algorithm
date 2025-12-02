namespace Algorithm.BOJ.BOJ_20943
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20943/input1.txt",
            "BOJ/BOJ_20943/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            Dictionary<(int, int), int> slopeCounts = new();

            int N = ReadInt(sr);

            for (int _ = 0; _ < N; _++)
            {
                int a = ReadInt(sr), b = ReadInt(sr), c = ReadInt(sr);

                if (a == 0)
                {
                    if (!slopeCounts.TryAdd((0, 1), 1))
                        slopeCounts[(0, 1)]++;
                }
                else if (b == 0)
                {
                    if (!slopeCounts.TryAdd((1, 0), 1))
                        slopeCounts[(1, 0)]++;
                }
                else
                {
                    int gcd = GCD(Math.Abs(a), Math.Abs(b));
                    a /= gcd;
                    b /= gcd;
                    if (a < 0)
                    {
                        a = -a;
                        b = -b;
                    }
                    if (!slopeCounts.TryAdd((a, b), 1))
                        slopeCounts[(a, b)]++;
                }
            }

            long pairCnt = N * (N - 1L) / 2;
            foreach (int cnt in slopeCounts.Values)
                pairCnt -= cnt * (cnt - 1L) / 2;

            sw.WriteLine(pairCnt);

            sr.Close();
            sw.Close();

            int GCD(int a, int b) => a % b == 0 ? b : GCD(b, a % b);
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

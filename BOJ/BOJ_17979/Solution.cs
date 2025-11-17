namespace Algorithm.BOJ.BOJ_17979
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17979/input1.txt",
            "BOJ/BOJ_17979/input2.txt",
            "BOJ/BOJ_17979/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int m = ReadInt(sr), n = ReadInt(sr);

            int[] prices = new int[m + 1];
            (int s, int e, int t)[] occurrences = new (int, int, int)[n];

            for (int i = 1; i <= m; i++)
                prices[i] = ReadInt(sr);

            for (int i = 0; i < n; i++)
                occurrences[i] = (ReadInt(sr), ReadInt(sr), ReadInt(sr));

            Array.Sort(occurrences, (a, b) => a.e - b.e);

            List<(int e, int maxEarning)> dp = new(n) { (0, 0) };

            foreach ((int s, int e, int t) in occurrences)
            {
                int l = 0, r = dp.Count - 1;
                while (l < r)
                {
                    int c = (l + r + 1) / 2;
                    if (dp[c].e <= s)
                        l = c;
                    else
                        r = c - 1;
                }

                int maxEarning = Math.Max(dp[l].maxEarning + (e - s) * prices[t], dp[^1].maxEarning);

                if (dp[^1].e == e)
                    dp[^1] = (e, maxEarning);
                else
                    dp.Add((e, maxEarning));
            }

            sw.WriteLine(dp[^1].maxEarning);

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

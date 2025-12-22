namespace Algorithm.BOJ.BOJ_28129
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_28129/input1.txt",
            "BOJ/BOJ_28129/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int mod = 1_000_000_007;

            int N = ReadInt(sr), K = ReadInt(sr);

            int[,] dp = new int[N + 1, 3002];

            int a = ReadInt(sr), b = ReadInt(sr);

            for (int D = a; D <= b; D++)
                dp[1, D] = 1;

            for (int i = 1; i < N; i++)
            {
                for (int D = a; D <= b; D++)
                {
                    int l = Math.Max(D - K, 1);
                    int r = Math.Min(D + K, 3000);

                    dp[i + 1, l] = (dp[i + 1, l] + dp[i, D]) % mod;
                    dp[i + 1, r + 1] = (dp[i + 1, r + 1] - dp[i, D] + mod) % mod;
                }

                for (int j = 1; j <= 3000; j++)
                    dp[i + 1, j] = (dp[i + 1, j] + dp[i + 1, j - 1]) % mod;

                a = ReadInt(sr);
                b = ReadInt(sr);
            }

            int cnt = 0;

            for (int D = a; D <= b; D++)
                cnt = (cnt + dp[N, D]) % mod;

            sw.WriteLine(cnt);

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

namespace Algorithm.BOJ.BOJ_30460
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30460/input1.txt",
            "BOJ/BOJ_30460/input2.txt",
            "BOJ/BOJ_30460/input3.txt",
            "BOJ/BOJ_30460/input4.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int[] A = new int[N + 1];
            int[,] dp = new int[N + 1, 3];

            for (int i = 1; i <= N; i++)
            {
                A[i] = ReadInt(sr);
                dp[i, 0] = dp[i - 1, 0] + A[i];
                dp[i, 1] = dp[i - 1, 0] + 2 * A[i];
                if (i >= 2)
                    dp[i, 2] = dp[i - 1, 1] + 2 * A[i];
                if (i >= 3)
                    dp[i, 0] = Math.Max(dp[i, 0], dp[i - 1, 2] + 2 * A[i]);
            }

            sw.WriteLine(Math.Max(dp[N, 0], Math.Max(dp[N, 1], dp[N, 2])));

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

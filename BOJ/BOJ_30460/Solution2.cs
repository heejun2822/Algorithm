namespace Algorithm.BOJ.BOJ_30460
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
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

            int[] A = new int[N + 3];
            int[] dp = new int[N + 3];

            for (int i = 1; i < N + 3; i++)
            {
                if (i <= N)
                    A[i] = ReadInt(sr);
                dp[i] = dp[i - 1] + A[i];
                if (i >= 3)
                    dp[i] = Math.Max(dp[i], dp[i - 3] + (A[i - 2] + A[i - 1] + A[i]) * 2);
            }

            sw.WriteLine(dp[N + 2]);

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

namespace Algorithm.BOJ.BOJ_11985
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11985/input1.txt",
            "BOJ/BOJ_11985/input2.txt",
            "BOJ/BOJ_11985/input3.txt",
            "BOJ/BOJ_11985/input4.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr), M = ReadInt(sr), K = ReadInt(sr);

            int[] A = new int[N + 1];
            long[] dp = new long[N + 1];

            for (int i = 1; i <= N; i++)
            {
                A[i] = ReadInt(sr);
                dp[i] = long.MaxValue;

                long s = 1, a = A[i], b = A[i];

                while (s <= i && s <= M)
                {
                    a = Math.Max(a, A[i - s + 1]);
                    b = Math.Min(b, A[i - s + 1]);
                    dp[i] = Math.Min(dp[i], dp[i - s] + K + s * (a - b));
                    s++;
                }
            }

            sw.WriteLine(dp[N]);

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

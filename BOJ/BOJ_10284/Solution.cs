namespace Algorithm.BOJ.BOJ_10284
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10284/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int tc = ReadInt(sr);

            while (tc-- > 0)
            {
                int n = ReadInt(sr);
                int[] accSum = new int[n + 1];
                int[] weightedAccSum = new int[n + 1];

                for (int i = 1; i <= n; i++)
                {
                    int s = ReadInt(sr);
                    accSum[i] = accSum[i - 1] + s;
                    weightedAccSum[i] = weightedAccSum[i - 1] + s * i;
                }

                int[] dp = new int[n + 1];

                for (int i = 1; i <= n; i++)
                {
                    dp[i] = int.MaxValue;

                    for (int j = 0; j < i; j++)
                    {
                        int angerByStop = j == 0 ? 0 : accSum[n] - accSum[j];
                        int angerBySkip = (accSum[i - 1] - accSum[j]) * i - (weightedAccSum[i - 1] - weightedAccSum[j]);
                        dp[i] = Math.Min(dp[i], dp[j] + angerByStop + angerBySkip);
                    }
                }

                sw.WriteLine(dp[n]);
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

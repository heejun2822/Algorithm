namespace Algorithm.BOJ.BOJ_12905
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12905/input1.txt",
            "BOJ/BOJ_12905/input2.txt",
            "BOJ/BOJ_12905/input3.txt",
            "BOJ/BOJ_12905/input4.txt",
            "BOJ/BOJ_12905/input5.txt",
        ];

        public static void Run(string[] args)
        {
            const int INF = 100;

            int N = int.Parse(Console.ReadLine()!);
            string answers = Console.ReadLine()!;

            int[,] dp = new int[N + 1, 2];

            int minCnt = INF;

            for (int first = 0; first <= 1; first++)
            {
                if (first == 0)
                {
                    dp[0, 0] = 1;
                    dp[0, 1] = INF;
                }
                else
                {
                    dp[0, 0] = INF;
                    dp[0, 1] = 0;
                }

                for (int i = 0; i < N; i++)
                {
                    if (answers[i] == 'L')
                    {
                        dp[i + 1, 0] = dp[i, 1];
                        dp[i + 1, 1] = dp[i, 0];
                    }
                    else if (answers[i] == 'H')
                    {
                        dp[i + 1, 0] = dp[i, 0];
                        dp[i + 1, 1] = dp[i, 1];
                    }
                    else
                    {
                        dp[i + 1, 0] = Math.Min(dp[i, 0], dp[i, 1]);
                        dp[i + 1, 1] = Math.Min(dp[i, 0], dp[i, 1]);
                    }

                    if (i < N - 1 && dp[i + 1, 0] != INF)
                        dp[i + 1, 0]++;
                }

                minCnt = Math.Min(minCnt, dp[N, first]);
            }

            Console.WriteLine(minCnt == INF ? -1 : minCnt);
        }
    }
}

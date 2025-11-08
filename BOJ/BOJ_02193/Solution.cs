namespace Algorithm.BOJ.BOJ_02193
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02193/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            long[] dp = new long[Math.Max(N + 1, 3)];
            dp[1] = 1;
            dp[2] = 1;

            for (int i = 3; i <= N; i++)
                dp[i] = dp[i - 2] + dp[i - 1];

            Console.WriteLine(dp[N]);
        }
    }
}

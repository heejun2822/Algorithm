namespace Algorithm.BOJ.BOJ_14855
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14855/input1.txt",
            "BOJ/BOJ_14855/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int c0 = int.Parse(input[2]);
            int d0 = int.Parse(input[3]);

            int[] dp = new int[n + 1];

            for (int i = c0; i <= n; i++)
                dp[i] = i / c0 * d0;

            for (int _ = 0; _ < m; _++)
            {
                input = Console.ReadLine()!.Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                int c = int.Parse(input[2]);
                int d = int.Parse(input[3]);

                for (int i = n; i >= c; i--)
                {
                    int maxCnt = Math.Min(a / b, i / c);

                    for (int cnt = 1; cnt <= maxCnt; cnt++)
                        dp[i] = Math.Max(dp[i], dp[i - c * cnt] + d * cnt);
                }
            }

            Console.WriteLine(dp[n]);
        }
    }
}

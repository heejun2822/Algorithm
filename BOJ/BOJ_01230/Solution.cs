namespace Algorithm.BOJ.BOJ_01230
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01230/input1.txt",
            "BOJ/BOJ_01230/input2.txt",
            "BOJ/BOJ_01230/input3.txt",
            "BOJ/BOJ_01230/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string O = Console.ReadLine()!;
            string N = Console.ReadLine()!;

            int[,,] dp = new int[O.Length + 1, N.Length + 1, 2];

            for (int i = 1; i <= O.Length; i++)
            {
                dp[i, 0, 0] = -1;
                dp[i, 0, 1] = -1;
            }
            for (int i = 1; i <= N.Length; i++)
            {
                dp[0, i, 0] = -1;
                dp[0, i, 1] = 1;
            }

            for (int i = 1; i <= O.Length; i++)
            {
                for (int j = 1; j <= N.Length; j++)
                {
                    if (O[i - 1] == N[j - 1])
                        dp[i, j, 0] = Min(dp[i - 1, j - 1, 0], dp[i - 1, j - 1, 1]);
                    else
                        dp[i, j, 0] = -1;

                    dp[i, j, 1] = Min(dp[i, j - 1, 0] == -1 ? -1 : dp[i, j - 1, 0] + 1, dp[i, j - 1, 1]);
                }
            }

            int ans = Min(dp[O.Length, N.Length, 0], dp[O.Length, N.Length, 1]);

            Console.WriteLine(ans);

            int Min(int a, int b)
            {
                int min = int.MaxValue;
                if (a != -1 && a < min)
                    min = a;
                if (b != -1 && b < min)
                    min = b;
                if (min == int.MaxValue)
                    min = -1;
                return min;
            }
        }
    }
}

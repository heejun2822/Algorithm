namespace Algorithm.BOJ.BOJ_30025
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_30025/input1.txt",
            "BOJ/BOJ_30025/input2.txt",
            "BOJ/BOJ_30025/input3.txt",
            "BOJ/BOJ_30025/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);
            int K = int.Parse(input[2]);
            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int[,] dp = new int[M + 1, K];

            foreach (int d in a)
                if (d != 0)
                    dp[1, d % K]++;

            for (int i = 1; i < M; i++)
            {
                for (int j = 0; j < K; j++)
                {
                    foreach (int d in a)
                    {
                        int r = (j * 10 + d) % K;
                        dp[i + 1, r] += dp[i, j];
                        dp[i + 1, r] %= 1_000_000_007;
                    }
                }
            }

            Console.WriteLine(dp[M, 0]);
        }
    }
}

namespace Algorithm.BOJ.BOJ_14613
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14613/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            double W = double.Parse(input[0]), L = double.Parse(input[1]), D = double.Parse(input[2]);

            double[,] dp = new double[21, 41];
            dp[0, 20] = 1;

            for (int i = 0; i < 20; i++)
            {
                for (int j = 20 - i; j <= 20 + i; j++)
                {
                    dp[i + 1, j - 1] += dp[i, j] * L;
                    dp[i + 1, j] += dp[i, j] * D;
                    dp[i + 1, j + 1] += dp[i, j] * W;
                }
            }

            double[] tierProb = new double[5];

            for (int i = 0; i <= 40; i++)
            {
                int score = 2000 + 50 * (i - 20);

                int tier;
                if (score < 1500)
                    tier = 0;
                else if (score < 2000)
                    tier = 1;
                else if (score < 2500)
                    tier = 2;
                else if (score < 3000)
                    tier = 3;
                else
                    tier = 4;

                tierProb[tier] += dp[20, i];
            }

            foreach (double prob in tierProb)
                Console.WriteLine(prob.ToString("F8"));
        }
    }
}

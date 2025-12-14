namespace Algorithm.BOJ.BOJ_27980
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27980/input1.txt",
            "BOJ/BOJ_27980/input2.txt",
            "BOJ/BOJ_27980/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int M = int.Parse(input[1]);

            string text = Console.ReadLine()!;
            string str = Console.ReadLine()!;

            int[] dp = new int[N + 1];

            for (int i = 0; i < M; i++)
            {
                int prev = 0;

                for (int j = 0; j < N; j++)
                {
                    (dp[j], prev) = (Math.Max(prev, dp[j + 1]), dp[j]);

                    if (text[j] == str[i])
                        dp[j]++;
                }
            }

            int maxScore = 0;

            for (int i = 0; i < N; i++)
                maxScore = Math.Max(maxScore, dp[i]);

            Console.WriteLine(maxScore);
        }
    }
}

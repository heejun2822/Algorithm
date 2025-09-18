namespace Algorithm.BOJ.BOJ_15989
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15989/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[T];

            int maxN = 0;

            for (int i = 0; i < T; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine()!);
                maxN = Math.Max(maxN, numbers[i]);
            }

            int[] dp = new int[maxN + 1];
            Array.Fill(dp, 1);

            for (int i = 2; i <= maxN; i++)
                dp[i] += dp[i - 2];

            for (int i = 3; i <= maxN; i++)
                dp[i] += dp[i - 3];

            System.Text.StringBuilder output = new();

            foreach (int n in numbers)
                output.AppendLine(dp[n].ToString());

            Console.Write(output);
        }
    }
}

namespace Algorithm.BOJ.BOJ_15011
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15011/input1.txt",
            "BOJ/BOJ_15011/input2.txt",
            "BOJ/BOJ_15011/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int p = int.Parse(input[0]), q = int.Parse(input[1]);

            int[,] dp = new int[101, 101];

            for (int r = 1; r <= 100; r++)
                for (int c = 1; c <= 100; c++)
                    dp[r, c] = int.MinValue;

            Console.WriteLine(GetMaxDiff(p, q));

            int GetMaxDiff(int r, int c)
            {
                if (dp[r, c] == int.MinValue)
                {
                    for (int i = 1; i <= c; i++)
                    {
                        int happiness = r * i % 2 == 0 ? 0 : (q - c) % 2 == 0 ? 1 : -1;
                        dp[r, c] = Math.Max(dp[r, c], happiness - GetMaxDiff(c - i, r));
                    }
                }

                return dp[r, c];
            }
        }
    }
}

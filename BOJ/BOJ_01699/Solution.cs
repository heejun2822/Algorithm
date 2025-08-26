namespace Algorithm.BOJ.BOJ_01699
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01699/input1.txt",
            "BOJ/BOJ_01699/input2.txt",
            "BOJ/BOJ_01699/input3.txt",
            "BOJ/BOJ_01699/input4.txt",
            "BOJ/BOJ_01699/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            int[] squares = new int[(int)Math.Sqrt(N)];

            for (int i = 0; i < squares.Length; i++)
                squares[i] = (i + 1) * (i + 1);

            int[] dp = new int[N + 1];

            for (int num = 1; num <= N; num++)
            {
                dp[num] = int.MaxValue;
                foreach (int sqr in squares)
                {
                    if (num - sqr < 0) break;
                    dp[num] = Math.Min(dp[num], dp[num - sqr] + 1);
                }
            }

            Console.WriteLine(dp[N]);
        }
    }
}

namespace Algorithm.BOJ.BOJ_32892
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_32892/input1.txt",
            "BOJ/BOJ_32892/input2.txt",
            "BOJ/BOJ_32892/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[] p = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            Array.Sort(p, (a, b) => b - a);

            int half = p.Sum() / 2;
            long[] dp = new long[half + 1];
            dp[0] = 1;

            int lim = 0;
            long cnt = 0;

            for (int i = 0; i < n; i++)
            {
                for (int s = lim; s >= 0; s--)
                {
                    if (s + p[i] > half)
                        cnt += dp[s];
                    else
                        dp[s + p[i]] += dp[s];
                }

                lim += p[i];
                lim = Math.Min(lim, half);
            }

            Console.WriteLine(cnt);
        }
    }
}

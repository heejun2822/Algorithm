namespace Algorithm.BOJ.BOJ_13747
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13747/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            long n = long.Parse(input[0]);
            int k = int.Parse(input[1]);

            (long a, long b)[] ranges = new (long, long)[k];

            for (int i = 0; i < k; i++)
            {
                input = Console.ReadLine()!.Split();
                ranges[i] = (long.Parse(input[0]), long.Parse(input[1]));
            }

            Array.Sort(ranges, (x, y) => x.b.CompareTo(y.b));

            (long idx, long max)[] dp = new (long, long)[k + 1];
            int cnt = 0;
            dp[cnt++] = (0, 0);

            foreach ((long a, long b) in ranges)
            {
                int l = 0, r = cnt - 1;
                while (l < r)
                {
                    int m = (l + r + 1) / 2;
                    if (dp[m].idx < a)
                        l = m;
                    else
                        r = m - 1;
                }

                if (b > dp[cnt - 1].idx)
                {
                    dp[cnt] = (b, dp[cnt - 1].max);
                    cnt++;
                }

                dp[cnt - 1].max = Math.Max(dp[cnt - 1].max, dp[l].max + b - a + 1);
            }

            Console.WriteLine(n - dp[cnt - 1].max);
        }
    }
}

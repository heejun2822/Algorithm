namespace Algorithm.BOJ.BOJ_13270
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13270/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            (int min, int max)[] dp = new (int, int)[N + 1];

            for (int i = 1; i <= N; i++)
                dp[i] = (int.MaxValue, 0);

            int serves = 2;
            int chickens = 1;

            while (serves <= N)
            {
                for (int i = serves; i <= N; i++)
                {
                    if (dp[i - serves].min == int.MaxValue) continue;

                    dp[i].min = Math.Min(dp[i].min, dp[i - serves].min + chickens);
                    dp[i].max = Math.Max(dp[i].max, dp[i - serves].max + chickens);
                }

                (serves, chickens) = (serves + chickens, serves);
            }

            Console.WriteLine($"{dp[N].min} {dp[N].max}");
        }
    }
}

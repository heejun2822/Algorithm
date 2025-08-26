namespace Algorithm.BOJ.BOJ_27065
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_27065/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < T; _++)
            {
                int n = int.Parse(Console.ReadLine()!);
                Console.WriteLine(IsBeautiful(n) ? "Good Bye" : "BOJ 2022");
            }
        }

        private static bool IsBeautiful(int n)
        {
            if (n == 1) return false;

            int sum = 1;
            int limit = (int)Math.Sqrt(n);
            int pair;
            for (int i = 2; i <= limit; i++)
            {
                if (n % i != 0) continue;

                if (SumDivisors(i) > i) return false;
                sum += i;

                if ((pair = n / i) == i) continue;
                if (SumDivisors(pair) > pair) return false;
                sum += pair;
            }

            return sum > n;
        }

        private static int SumDivisors(int n)
        {
            if (n == 1) return 0;

            int sum = 1;
            int limit = (int)Math.Sqrt(n);
            int pair;
            for (int i = 2; i <= limit; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                    if ((pair = n / i) != i) sum += pair;
                }
            }

            return sum;
        }
    }
}

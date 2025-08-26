namespace Algorithm.BOJ.BOJ_11401
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11401/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), K = int.Parse(input[1]);

            Console.WriteLine(ModBinomialCoefficient(N, K, 1000000007));
        }

        private static long ModBinomialCoefficient(int n, int k, int d)
        {
            long r_n = ModFactorial(n, d);
            // 페르마의 소정리
            long r_d = ModPower(ModFactorial(n - k, d) * ModFactorial(k, d) % d, d - 2, d);

            return r_n * r_d % d;
        }

        private static long ModFactorial(int n, int d)
        {
            long f = 1;
            for (int i = 2; i <= n; i++) f = f * i % d;
            return f;
        }

        private static long ModPower(long x, int y, int d)
        {
            if (y == 1) return x % d;

            if (y % 2 == 1) return x * ModPower(x, y - 1, d) % d;

            long powered = ModPower(x, y / 2, d);
            return powered * powered % d;
        }
    }
}

namespace Algorithm.BOJ.BOJ_11050
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11050/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int N = int.Parse(nk[0]);
            int K = int.Parse(nk[1]);
            Console.WriteLine(Factorial(N) / Factorial(K) / Factorial(N - K));
        }

        private static int Factorial(int n)
        {
            int f = 1;
            for (int i = n; i > 1; i--) f *= i;
            return f;
        }
    }
}

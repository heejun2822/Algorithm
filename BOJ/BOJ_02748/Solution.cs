namespace Algorithm.BOJ.BOJ_02748
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02748/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            long[] F = new long[n + 1];
            F[0] = 0;
            F[1] = 1;

            for (int i = 2; i <= n; i++) F[i] = F[i - 2] + F[i - 1];

            Console.WriteLine(F[n]);
        }
    }
}

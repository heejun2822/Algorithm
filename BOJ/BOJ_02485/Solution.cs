namespace Algorithm.BOJ.BOJ_02485
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02485/input1.txt",
            "BOJ/BOJ_02485/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] trees = new int[N];
            for (int i = 0; i < N; i++) trees[i] = int.Parse(Console.ReadLine()!);
            int gap = trees[1] - trees[0];
            for (int i = 2; i < N; i++) gap = Gcd(trees[i] - trees[i - 1], gap);
            int cnt = 0;
            for (int i = 1; i < N; i++) cnt += (trees[i] - trees[i - 1]) / gap - 1;
            Console.WriteLine(cnt);
        }

        private static int Gcd(int a, int b)
        {
            return a % b == 0 ? b : Gcd(b, a % b);
        }
    }
}

namespace Algorithm.BOJ.BOJ_16395
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16395/input1.txt",
            "BOJ/BOJ_16395/input2.txt",
        ];

        private static int[][] pascals = new int[1][];

        public static void Run(string[] args)
        {
            string[] nk = Console.ReadLine()!.Split();
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            pascals = new int[n][];
            for (int i = 0; i < n; i++) pascals[i] = new int[i + 1];
            Console.WriteLine(GetPascal(n, k));
        }

        private static int GetPascal(int n, int k)
        {
            if (pascals[n - 1][k - 1] == 0)
            {
                pascals[n - 1][k - 1] = (k == 1 || k == n) ? 1 : GetPascal(n - 1, k - 1) + GetPascal(n - 1, k);
            }
            return pascals[n - 1][k - 1];
        }
    }
}

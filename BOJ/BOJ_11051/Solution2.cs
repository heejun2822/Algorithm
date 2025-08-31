namespace Algorithm.BOJ.BOJ_11051
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11051/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]);
            int K = int.Parse(input[1]);

            int[][] binomialCoefficients = new int[N + 1][];

            for (int i = 0; i <= N; i++)
                binomialCoefficients[i] = new int[i + 1];

            Console.WriteLine(GetBC(N, K));

            int GetBC(int n, int k)
            {
                if (binomialCoefficients[n][k] == 0)
                {
                    if (k == 0 || k == n)
                        binomialCoefficients[n][k] = 1;
                    else
                        binomialCoefficients[n][k] = (GetBC(n - 1, k - 1) + GetBC(n - 1, k)) % 10007;
                }
                return binomialCoefficients[n][k];
            }
        }
    }
}

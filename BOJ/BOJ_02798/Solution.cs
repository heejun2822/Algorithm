namespace Algorithm.BOJ.BOJ_02798
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02798/input1.txt",
            "BOJ/BOJ_02798/input2.txt",
        ];

        private static int N;
        private static int M;
        private static int[] cards = {};

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            N = int.Parse(nm[0]);
            M = int.Parse(nm[1]);
            cards = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
            Console.WriteLine(ComputeMaxSum());
        }

        private static int ComputeMaxSum()
        {
            int maxSum = 0;
            for (int i = 0; i < N - 2; i++)
            {
                for (int j = i + 1; j < N - 1; j++)
                {
                    for (int k = j + 1; k < N; k++)
                    {
                        int sum = cards[i] + cards[j] + cards[k];
                        if (sum > M) continue;
                        if (sum == M) return M;
                        if (sum > maxSum) maxSum = sum;
                    }
                }
            }
            return maxSum;
        }
    }
}

namespace Algorithm.BOJ.BOJ_11053
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11053/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            // LIS (Longest Increasing Subsequence)
            int[] LIS = Enumerable.Repeat(1, N).ToArray();
            for (int i = 0; i < N; i++)
            for (int j = 0; j < i; j++)
                if (A[i] > A[j]) LIS[i] = Math.Max(LIS[i], LIS[j] + 1);

            Console.WriteLine(LIS.Max());
        }
    }
}

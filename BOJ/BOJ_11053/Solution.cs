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

            int[] len = Enumerable.Repeat(1, N).ToArray();
            for (int i = 0; i < N; i++)
            for (int j = 0; j < i; j++)
                if (A[i] > A[j]) len[i] = Math.Max(len[i], len[j] + 1);

            Console.WriteLine(len.Max());
        }
    }
}

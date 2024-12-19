namespace Algorithm.BOJ.BOJ_11054
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_11054/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int[,] len = new int[N, 2];
            for (int i = 0; i < N; i++)
            {
                len[i, 0] = 1;
                for (int j = 0; j < i; j++)
                    if (A[i] > A[j]) len[i, 0] = Math.Max(len[i, 0], len[j, 0] + 1);

                int r = N - 1 - i;
                len[r, 1] = 1;
                for (int s = r + 1; s < N; s++)
                    if (A[r] > A[s]) len[r, 1] = Math.Max(len[r, 1], len[s, 1] + 1);
            }

            int maxBitonicLength = 1;
            for (int i = 0; i < N; i++)
            {
                int bitonicLength = len[i, 0] + len[i, 1] - 1;
                maxBitonicLength = Math.Max(maxBitonicLength, bitonicLength);
            }

            Console.WriteLine(maxBitonicLength);
        }
    }
}

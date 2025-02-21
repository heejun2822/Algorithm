namespace Algorithm.BOJ.BOJ_14002
{
    using System.Text;

    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_14002/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] A = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            (int len, int nextIdx)[] memo = new (int, int)[N];
            int maxIdx = N - 1;

            for (int i = N - 1; i >= 0; i--)
            {
                memo[i] = (1, N);

                for (int j = i + 1; j < N; j++)
                    if (A[i] < A[j] && memo[i].len < memo[j].len + 1)
                        memo[i] = (memo[j].len + 1, j);

                if (memo[i].len > memo[maxIdx].len) maxIdx = i;
            }

            StringBuilder LIS = new();
            int idx = maxIdx;
            while (idx < N)
            {
                LIS.Append(A[idx]);
                LIS.Append(' ');
                idx = memo[idx].nextIdx;
            }

            Console.WriteLine(memo[maxIdx].len);
            Console.WriteLine(LIS);
        }
    }
}

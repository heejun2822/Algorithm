namespace Algorithm.BOJ.BOJ_01311
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01311/input.txt",
        ];

        // 비트마스크 DP (BitMask DP)
        public static void Run(string[] args)
        {
            int N = ReadInt();
            int[,] D = new int[N, N];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    D[i, j] = ReadInt();

            int[] minCost = new int[1 << N];

            Console.WriteLine(GetMinCost(0, 0));

            int GetMinCost(int i, int visitedMask)
            {
                if (i == N) return 0;

                if (minCost[visitedMask] == 0)
                {
                    minCost[visitedMask] = int.MaxValue;

                    for (int j = 0; j < N; j++)
                    {
                        if ((visitedMask & (1 << j)) != 0) continue;

                        minCost[visitedMask] = Math.Min
                        (
                            minCost[visitedMask],
                            D[i, j] + GetMinCost(i + 1, visitedMask | (1 << j))
                        );
                    }
                }

                return minCost[visitedMask];
            }
        }

        private static int ReadInt()
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = Console.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { Console.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}

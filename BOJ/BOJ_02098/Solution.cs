namespace Algorithm.BOJ.BOJ_02098
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02098/input.txt",
        ];

        // 비트마스크 DP (BitMask DP)
        public static void Run(string[] args)
        {
            const int INF = 16_000_000;

            int N = ReadInt();
            int[,] W = new int[N, N];

            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    W[i, j] = ReadInt();

            int[,] minCost = new int[N, 1 << N];

            Console.WriteLine(GetMinCost(0, 1));

            int GetMinCost(int i, int visitedMask)
            {
                if (visitedMask == ((1 << N) - 1))
                    return W[i, 0] == 0 ? INF : W[i, 0];

                if (minCost[i, visitedMask] == 0)
                {
                    minCost[i, visitedMask] = INF;

                    for (int j = 0; j < N; j++)
                    {
                        if ((visitedMask & (1 << j)) != 0 || W[i, j] == 0) continue;

                        minCost[i, visitedMask] = Math.Min
                        (
                            minCost[i, visitedMask],
                            W[i, j] + GetMinCost(j, visitedMask | (1 << j))
                        );
                    }
                }

                return minCost[i, visitedMask];
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

namespace Algorithm.BOJ.BOJ_20992
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_20992/input1.txt",
            "BOJ/BOJ_20992/input2.txt",
            "BOJ/BOJ_20992/input3.txt",
        ];

        public static void Run(string[] args)
        {
            const int INF = 2000;

            string[] input = Console.ReadLine()!.Split();
            int X = int.Parse(input[0]), Y = int.Parse(input[1]);

            string key = Console.ReadLine()!;
            int K = key.Length;
            int[] codeKey = new int[K + 1];

            for (int i = 1; i <= K; i++)
                codeKey[i] = key[i - 1] - '0';

            int[,] grid = new int[Y + 1, X + 1];

            for (int i = Y; i >= 1; i--)
            {
                string row = Console.ReadLine()!;
                for (int j = 1; j <= X; j++)
                    grid[i, j] = row[j - 1] - '0';
            }

            int[,,] dp = new int[Y + 1, X + 1, K + 1];

            for (int i = 1; i <= Y; i++)
                for (int j = 1; j <= X; j++)
                    for (int k = 0; k <= K; k++)
                        dp[i, j, k] = -1;
            dp[1, 1, 0] = grid[1, 1];

            int minPath = INF;
            for (int k = 0; k <= K; k++)
                minPath = Math.Min(minPath, GetMinPath(Y, X, k));

            Console.WriteLine(minPath);

            int GetMinPath(int y, int x, int keyIdx)
            {
                if (y <= 0 || x <= 0 || keyIdx < 0)
                    return INF;

                if (dp[y, x, keyIdx] == -1)
                {
                    int min = INF;
                    min = Math.Min(min, GetMinPath(y - 1, x, keyIdx));
                    min = Math.Min(min, GetMinPath(y, x - 1, keyIdx));
                    min = Math.Min(min, GetMinPath(y - 1 - codeKey[keyIdx], x, keyIdx - 1));
                    min = Math.Min(min, GetMinPath(y, x - 1 - codeKey[keyIdx], keyIdx - 1));

                    dp[y, x, keyIdx] = min == INF ? INF : min + grid[y, x];
                }

                return dp[y, x, keyIdx];
            }
        }
    }
}

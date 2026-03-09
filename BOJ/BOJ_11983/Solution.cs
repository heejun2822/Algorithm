namespace Algorithm.BOJ.BOJ_11983
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11983/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]);

            input = Console.ReadLine()!.Split();
            int fx = int.Parse(input[0]), fy = int.Parse(input[1]);

            input = Console.ReadLine()!.Split();
            int bx = int.Parse(input[0]), by = int.Parse(input[1]);

            string pathF = Console.ReadLine()!;
            string pathB = Console.ReadLine()!;

            Dictionary<char, int> dx = new() { {'N', 0}, {'E', 1}, {'S', 0}, {'W', -1} };
            Dictionary<char, int> dy = new() { {'N', 1}, {'E', 0}, {'S', -1}, {'W', 0} };

            (int x, int y)[] locationF = new (int, int)[N + 1];
            (int x, int y)[] locationB = new (int, int)[M + 1];

            locationF[0] = (fx, fy);
            for (int i = 0; i < N; i++)
                locationF[i + 1] = (locationF[i].x + dx[pathF[i]], locationF[i].y + dy[pathF[i]]);

            locationB[0] = (bx, by);
            for (int i = 0; i < M; i++)
                locationB[i + 1] = (locationB[i].x + dx[pathB[i]], locationB[i].y + dy[pathB[i]]);

            int[,] dp = new int[N + 1, M + 1];

            for (int i = 1; i <= N; i++)
                dp[i, 0] = dp[i - 1, 0] + SquareDistance(locationF[i], locationB[0]);
            for (int i = 1; i <= M; i++)
                dp[0, i] = dp[0, i - 1] + SquareDistance(locationF[0], locationB[i]);

            for (int i = 1; i <= N; i++)
                for (int j = 1; j <= M; j++)
                    dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + SquareDistance(locationF[i], locationB[j]);

            Console.WriteLine(dp[N, M]);

            int SquareDistance((int x, int y) A, (int x, int y) B)
            {
                int dx = B.x - A.x;
                int dy = B.y - A.y;
                return dx * dx + dy * dy;
            }
        }
    }
}

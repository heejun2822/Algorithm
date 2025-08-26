namespace Algorithm.BOJ.BOJ_12155
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12155/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int x = 1; x <= T; x++)
            {
                string[] input = sr.ReadLine()!.Split();
                int R = int.Parse(input[0]);
                int C = int.Parse(input[1]);
                int N = int.Parse(input[2]);

                bool[,] grid = new bool[R, C];
                int y = int.MaxValue;

                Combination(grid, R, C, N, 0, 0, ref y);

                sw.WriteLine($"Case #{x}: {y}");
            }

            sr.Close();
            sw.Close();

            void Combination(bool[,] grid, int R, int C, int N, int idx, int cnt, ref int minScore)
            {
                if (cnt == N)
                {
                    minScore = Math.Min(minScore, CalculateScore(grid, R, C));
                    return;
                }

                if (idx == R * C) return;

                int row = idx / C, col = idx % C;

                grid[row, col] = true;
                Combination(grid, R, C, N, idx + 1, cnt + 1, ref minScore);
                grid[row, col] = false;
                Combination(grid, R, C, N, idx + 1, cnt, ref minScore);
            }

            int CalculateScore(bool[,] grid, int R, int C)
            {
                int score = 0;

                for (int i = 0; i < R; i++)
                {
                    for (int j = 0; j < C; j++)
                    {
                        if (!grid[i, j]) continue;
                        if (i > 0 && grid[i - 1, j]) score++;
                        if (j > 0 && grid[i, j - 1]) score++;
                    }
                }

                return score;
            }
        }
    }
}

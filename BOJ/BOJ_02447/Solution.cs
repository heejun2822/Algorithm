namespace Algorithm.BOJ.BOJ_02447
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02447/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            int N = int.Parse(sr.ReadLine()!);
            bool[,] pattern = new bool[N, N];
            DrawPattern(pattern, N, 0, 0);

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                    sw.Write(pattern[r, c] ? "*" : " ");
                sw.Write('\n');
            }

            sr.Close();
            sw.Close();
        }

        private static void DrawPattern(bool[,] pattern, int n, int r, int c)
        {
            if (n == 1)
            {
                pattern[r, c] = true;
                return;
            }

            for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                if (i == 1 && j == 1) continue;
                DrawPattern(pattern, n / 3, r + n / 3 * i, c + n / 3 * j);
            }
        }
    }
}

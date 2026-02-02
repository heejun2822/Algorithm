namespace Algorithm.BOJ.BOJ_23353
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23353/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int N = ReadInt(sr);

            int[,,,] scoreDP = new int[N + 2, N + 2, 4, 2];
            int maxScore = 0;

            int[] dr = { 0, -1, -1, -1 };
            int[] dc = { -1, 1, 0, -1 };

            for (int r = 1; r <= N; r++)
            {
                for (int c = 1; c <= N; c++)
                {
                    int status = ReadInt(sr);

                    if (status == 1)
                    {
                        for (int d = 0; d < 4; d++)
                        {
                            int pr = r + dr[d], pc = c + dc[d];
                            scoreDP[r, c, d, 0] = scoreDP[pr, pc, d, 0] + 1;
                            maxScore = Math.Max(maxScore, scoreDP[r, c, d, 0]);
                            scoreDP[r, c, d, 1] = scoreDP[pr, pc, d, 1] + 1;
                            maxScore = Math.Max(maxScore, scoreDP[r, c, d, 1]);
                        }
                    }
                    else if (status == 2)
                    {
                        for (int d = 0; d < 4; d++)
                        {
                            int pr = r + dr[d], pc = c + dc[d];
                            scoreDP[r, c, d, 1] = scoreDP[pr, pc, d, 0] + 1;
                            maxScore = Math.Max(maxScore, scoreDP[r, c, d, 1]);
                        }
                    }
                }
            }

            sw.WriteLine(maxScore);

            sr.Close();
            sw.Close();
        }

        private static int ReadInt(StreamReader sr)
        {
            int c, val = 0, sign = 1;
            while (true)
            {
                c = sr.Read();
                if (c == ' ' || c == '\n' || c == -1) break;
                if (c == '\r') { sr.Read(); break; }
                if (c == '-') { sign = -1; continue; }
                val = val * 10 + c - '0';
            }
            return val * sign;
        }
    }
}

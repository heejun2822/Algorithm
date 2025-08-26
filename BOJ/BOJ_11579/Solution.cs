namespace Algorithm.BOJ.BOJ_11579
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11579/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            int T = int.Parse(sr.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                int n = int.Parse(sr.ReadLine()!);

                int[][] unitMoves = new int[n][];

                for (int i = 0; i < n; i++)
                {
                    string[] x = sr.ReadLine()!.Split();
                    unitMoves[i] = new int[n];
                    for (int j = 0; j < n; j++)
                        unitMoves[i][j] = int.Parse(x[j]);
                }

                long[] pos = new long[n];

                string[] y = sr.ReadLine()!.Split();
                for (int i = 0; i < n; i++)
                    pos[i] = long.Parse(y[i]);

                bool isReachable = true;
                long moveCnt = 0;

                for (int i = 0; i < n; i++)
                {
                    long cnt = pos[i];
                    moveCnt += cnt;

                    if (cnt < 0 || moveCnt > 2_000_000_000)
                    {
                        isReachable = false;
                        break;
                    }

                    for (int j = i; j < n; j++)
                        pos[j] -= unitMoves[i][j] * cnt;
                }

                sw.WriteLine(isReachable ? $"1 {moveCnt}" : "0");
            }

            sr.Close();
            sw.Close();
        }
    }
}

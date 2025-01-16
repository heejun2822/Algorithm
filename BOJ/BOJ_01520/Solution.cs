namespace Algorithm.BOJ.BOJ_01520
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01520/input.txt",
        ];

        private static int M;
        private static int N;
        private static int[,] map = new int[M, N];

        private static readonly int[] dr = { -1, 0, 1, 0 };
        private static readonly int[] dc = { 0, 1, 0, -1 };

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(Console.OpenStandardInput());
            StreamWriter sw = new(Console.OpenStandardOutput());

            string[] mn = sr.ReadLine()!.Split();
            M = int.Parse(mn[0]);
            N = int.Parse(mn[1]);
            map = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                string[] row = sr.ReadLine()!.Split();
                for (int j = 0; j < N; j++) map[i, j] = int.Parse(row[j]);
            }

            int[,] pathCnt = new int[M, N];
            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    pathCnt[i, j] = -1;

            SearchPath(pathCnt, 0, 0);

            sw.WriteLine(pathCnt[0, 0]);

            sr.Close();
            sw.Close();
        }

        private static void SearchPath(int[,] pathCnt, int r, int c)
        {
            if (pathCnt[r, c] != -1) return;

            if (r == M - 1 && c == N - 1)
            {
                pathCnt[r, c] = 1;
                return;
            }

            pathCnt[r, c] = 0;
            for (int i = 0; i < 4; i++)
            {
                int nr = r + dr[i];
                int nc = c + dc[i];
                if (nr < 0 || nr >= M || nc < 0 || nc >= N) continue;
                if (map[nr, nc] >= map[r, c]) continue;

                SearchPath(pathCnt, nr, nc);
                pathCnt[r, c] += pathCnt[nr, nc];
            }
        }
    }
}

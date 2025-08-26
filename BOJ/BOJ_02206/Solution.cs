namespace Algorithm.BOJ.BOJ_02206
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02206/input1.txt",
            "BOJ/BOJ_02206/input2.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] nm = sr.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            bool[,] map = new bool[N, M];
            for (int r = 0; r < N; r++)
            {
                string row = sr.ReadLine()!;
                for (int c = 0; c < M; c++) map[r, c] = row[c] == '1';
            }

            if (N == 1 && M == 1)
            {
                sw.WriteLine("1");
                goto End;
            }

            int[] dr = { 0, 0, 1, -1 };
            int[] dc = { 1, -1, 0, 0 };

            bool[,] visited = new bool[N, M];
            bool[,] visitedWithWall = new bool[N, M];
            Queue<(int r, int c, bool w)> queue = new();

            visited[0, 0] = true;
            queue.Enqueue((0, 0, false));

            int queueCount;
            int distance = 1;

            while ((queueCount = queue.Count) > 0)
            {
                distance++;

                for (int _ = 0; _ < queueCount; _++)
                {
                    (int r, int c, bool w) = queue.Dequeue();

                    for (int d = 0; d < 4; d++)
                    {
                        int nr = r + dr[d], nc = c + dc[d];

                        if (nr == N - 1 && nc == M - 1)
                        {
                            sw.WriteLine(distance);
                            goto End;
                        }

                        if (nr == -1 || nr == N || nc == -1 || nc == M) continue;

                        if (w)
                        {
                            if (!visitedWithWall[nr, nc] && !map[nr, nc])
                            {
                                visitedWithWall[nr, nc] = true;
                                queue.Enqueue((nr, nc, w));
                            }
                        }
                        else
                        {
                            if (!visited[nr, nc] && !map[nr, nc])
                            {
                                visited[nr, nc] = true;
                                queue.Enqueue((nr, nc, w));
                            }
                            else if (!visitedWithWall[nr, nc] && map[nr, nc])
                            {
                                visitedWithWall[nr, nc] = true;
                                queue.Enqueue((nr, nc, true));
                            }
                        }
                    }
                }
            }

            sw.WriteLine("-1");

            End:
            sr.Close();
            sw.Close();
        }
    }
}

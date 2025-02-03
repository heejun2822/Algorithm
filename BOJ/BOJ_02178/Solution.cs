namespace Algorithm.BOJ.BOJ_02178
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02178/input1.txt",
            "BOJ/BOJ_02178/input2.txt",
            "BOJ/BOJ_02178/input3.txt",
            "BOJ/BOJ_02178/input4.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);

            bool[,] maze = new bool[N, M];
            for (int r = 0; r < N; r++)
            {
                string row = Console.ReadLine()!;
                for (int c = 0; c < M; c++) maze[r, c] = row[c] == '1';
            }

            int[] dr = { 0, 0, 1, -1 };
            int[] dc = { 1, -1, 0, 0 };

            Queue<(int r, int c, int d)> queue = new();

            maze[0, 0] = false;
            queue.Enqueue((0, 0, 1));

            while (queue.Count > 0)
            {
                (int r, int c, int d) = queue.Dequeue();

                for (int i = 0; i < 4; i++)
                {
                    int nr = r + dr[i], nc = c + dc[i];
                    if (nr == -1 || nr == N || nc == -1 || nc == M) continue;
                    if (!maze[nr, nc]) continue;

                    if (nr == N - 1 && nc == M - 1)
                    {
                        Console.WriteLine(d + 1);
                        return;
                    }

                    maze[nr, nc] = false;
                    queue.Enqueue((nr, nc, d + 1));
                }
            }
        }
    }
}

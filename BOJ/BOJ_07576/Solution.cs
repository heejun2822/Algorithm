namespace Algorithm.BOJ.BOJ_07576
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_07576/input1.txt",
            "BOJ/BOJ_07576/input2.txt",
            "BOJ/BOJ_07576/input3.txt",
            "BOJ/BOJ_07576/input4.txt",
            "BOJ/BOJ_07576/input5.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] mn = sr.ReadLine()!.Split();
            int M = int.Parse(mn[0]);
            int N = int.Parse(mn[1]);

            int[,] tomatoes = new int[N, M];
            int totalCnt = N * M;
            int ripeCnt = 0;

            Queue<(int r, int c)> queue = new();

            for (int r = 0; r < N; r++)
            {
                string[] row = sr.ReadLine()!.Split();
                for (int c = 0; c < M; c++)
                {
                    tomatoes[r, c] = int.Parse(row[c]);

                    if (tomatoes[r, c] == -1)
                        totalCnt--;
                    else if (tomatoes[r, c] == 1)
                    {
                        queue.Enqueue((r, c));
                        ripeCnt++;
                    }
                }
            }

            int[] dr = { 0, 0, 1, -1 };
            int[] dc = { 1, -1, 0, 0 };

            int queueCount = queue.Count;
            int day = 0;

            while (queueCount > 0)
            {
                for (int _ = 0; _ < queueCount; _++)
                {
                    (int r, int c) = queue.Dequeue();

                    for (int d = 0; d < 4; d++)
                    {
                        int nr = r + dr[d], nc = c + dc[d];
                        if (nr == -1 || nr == N || nc == -1 || nc == M) continue;

                        if (tomatoes[nr, nc] == 0)
                        {
                            tomatoes[nr, nc] = 1;
                            queue.Enqueue((nr, nc));
                            ripeCnt++;
                        }
                    }
                }

                if ((queueCount = queue.Count) > 0) day++;
            }

            sw.WriteLine(ripeCnt == totalCnt ? day : "-1");

            sr.Close();
            sw.Close();
        }
    }
}

namespace Algorithm.BOJ.BOJ_07569
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_07569/input1.txt",
            "BOJ/BOJ_07569/input2.txt",
            "BOJ/BOJ_07569/input3.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] mnh = sr.ReadLine()!.Split();
            int M = int.Parse(mnh[0]);
            int N = int.Parse(mnh[1]);
            int H = int.Parse(mnh[2]);

            bool[,,] visited = new bool[H, N, M];
            Queue<(int f, int r, int c)> queue = new();
            int totalCnt = H * N * M;
            int ripeCnt = 0;

            for (int f = 0; f < H; f++)
            {
                for (int r = 0; r < N; r++)
                {
                    string[] row = sr.ReadLine()!.Split();

                    for (int c = 0; c < M; c++)
                    {
                        int tomato = int.Parse(row[c]);

                        if (tomato == -1)
                        {
                            visited[f, r, c] = true;
                            totalCnt--;
                        }
                        else if (tomato == 1)
                        {
                            visited[f, r, c] = true;
                            queue.Enqueue((f, r, c));
                            ripeCnt++;
                        }
                    }
                }
            }

            int[] df = { 1, -1, 0, 0, 0, 0 };
            int[] dr = { 0, 0, 1, -1, 0, 0 };
            int[] dc = { 0, 0, 0, 0, 1, -1 };

            int queueCount = queue.Count;
            int day = 0;

            while (queueCount > 0)
            {
                for (int _ = 0; _ < queueCount; _++)
                {
                    (int f, int r, int c) = queue.Dequeue();

                    for (int d = 0; d < 6; d++)
                    {
                        int nf = f + df[d], nr = r + dr[d], nc = c + dc[d];
                        if (nf == -1 || nf == H || nr == -1 || nr == N || nc == -1 || nc == M) continue;
                        if (visited[nf, nr, nc]) continue;

                        visited[nf, nr, nc] = true;
                        queue.Enqueue((nf, nr, nc));
                        ripeCnt++;
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

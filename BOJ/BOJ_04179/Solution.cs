namespace Algorithm.BOJ.BOJ_04179
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_04179/input.txt",
        ];

        public static void Run(string[] args)
        {
            StreamReader sr = Program.InputReader;
            // StreamReader sr = new(new BufferedStream(Console.OpenStandardInput()));
            StreamWriter sw = new(new BufferedStream(Console.OpenStandardOutput()));

            string[] input = sr.ReadLine()!.Split();
            int R = int.Parse(input[0]);
            int C = int.Parse(input[1]);

            bool[,] maze = new bool[R, C];
            Queue<(int r, int c)> queueJ = new();
            Queue<(int r, int c)> queueF = new();

            for (int r = 0; r < R; r++)
            {
                string row = sr.ReadLine()!;

                for (int c = 0; c < C; c++)
                {
                    if (row[c] == '.')
                        maze[r, c] = true;
                    else if (row[c] == 'J')
                        queueJ.Enqueue((r, c));
                    else if (row[c] == 'F')
                        queueF.Enqueue((r, c));
                }
            }

            int[] dr = { -1, 1, 0, 0 };
            int[] dc = { 0, 0, -1, 1 };

            bool escaped = false;
            int time = 0;

            while (queueJ.Count > 0 && !escaped)
            {
                int queueCnt = queueF.Count;

                while (queueCnt-- > 0)
                {
                    (int r, int c) = queueF.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        int nr = r + dr[i], nc = c + dc[i];
                        if (nr < 0 || nr >= R || nc < 0 || nc >= C)
                            continue;
                        if (maze[nr, nc])
                        {
                            maze[nr, nc] = false;
                            queueF.Enqueue((nr, nc));
                        }
                    }
                }

                queueCnt = queueJ.Count;

                while (queueCnt-- > 0 && !escaped)
                {
                    (int r, int c) = queueJ.Dequeue();
                    for (int i = 0; i < 4; i++)
                    {
                        int nr = r + dr[i], nc = c + dc[i];
                        if (nr < 0 || nr >= R || nc < 0 || nc >= C)
                        {
                            escaped = true;
                            break;
                        }
                        if (maze[nr, nc])
                        {
                            maze[nr, nc] = false;
                            queueJ.Enqueue((nr, nc));
                        }
                    }
                }

                time++;
            }

            sw.WriteLine(escaped ? time : "IMPOSSIBLE");

            sr.Close();
            sw.Close();
        }
    }
}

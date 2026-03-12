namespace Algorithm.BOJ.BOJ_14503
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14503/input1.txt",
            "BOJ/BOJ_14503/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]);

            input = Console.ReadLine()!.Split();
            int r = int.Parse(input[0]), c = int.Parse(input[1]), d = int.Parse(input[2]);

            int[,] room = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                input = Console.ReadLine()!.Split();
                for (int j = 0; j < M; j++)
                    room[i, j] = int.Parse(input[j]);
            }

            int[] dr = { -1, 0, 1, 0 };
            int[] dc = { 0, 1, 0, -1 };

            int cnt = 0;

            while (room[r, c] != 1)
            {
                if (room[r, c] == 0)
                {
                    room[r, c] = 2;
                    cnt++;
                }

                int nr = r - dr[d], nc = c - dc[d];

                for (int _ = 0; _ < 4; _++)
                {
                    d = (d + 3) % 4;
                    if (room[r + dr[d], c + dc[d]] == 0)
                    {
                        nr = r + dr[d];
                        nc = c + dc[d];
                        break;
                    }
                }

                r = nr;
                c = nc;
            }

            Console.WriteLine(cnt);
        }
    }
}

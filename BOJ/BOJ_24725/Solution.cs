namespace Algorithm.BOJ.BOJ_24725
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24725/input1.txt",
            "BOJ/BOJ_24725/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            char[,] board = new char[N, M];
            for (int i = 0; i < N; i++)
            {
                string row = Console.ReadLine()!;
                for (int j = 0; j < M; j++) board[i, j] = row[j];
            }

            char alphabet;
            int cnt = 0;
            for (int r = 0; r < N; r++)
                for (int c = 0; c < M; c++)
                {
                    alphabet = board[r, c];
                    if (alphabet != 'E' && alphabet != 'I') continue;

                    for (int dr = -1; dr <= 1; dr++)
                        for (int dc = -1; dc <= 1; dc++)
                        {
                            if (dr == 0 && dc == 0) continue;

                            int lr = r + 3 * dr, lc = c + 3 * dc;
                            if (lr < 0 || lr >= N || lc < 0 || lc >= M) continue;

                            alphabet = board[r + dr, c + dc];
                            if (alphabet != 'N' && alphabet != 'S') continue;
                            alphabet = board[r + 2 * dr, c + 2 * dc];
                            if (alphabet != 'F' && alphabet != 'T') continue;
                            alphabet = board[r + 3 * dr, c + 3 * dc];
                            if (alphabet != 'P' && alphabet != 'J') continue;

                            cnt++;
                        }
                }

            Console.WriteLine(cnt);
        }
    }
}

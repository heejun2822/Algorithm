namespace Algorithm.BOJ.BOJ_26169
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_26169/input1.txt",
            "BOJ/BOJ_26169/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int[,] board = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                string[] row = Console.ReadLine()!.Split();
                for (int j = 0; j < 5; j++)
                    board[i, j] = int.Parse(row[j]);
            }

            string[] rc = Console.ReadLine()!.Split();
            int r = int.Parse(rc[0]), c = int.Parse(rc[1]);

            Console.WriteLine(DFS(r, c, 3, 2) ? "1" : "0");

            bool DFS(int r, int c, int m, int a)
            {
                if (r < 0 || r >= 5 || c < 0 || c >= 5) return false;
                if (board[r, c] == -1) return false;

                if (board[r, c] == 1 && --a == 0) return true;
                if (m == 0) return false;

                int p = board[r, c];
                board[r, c] = -1;

                if (DFS(r + 1, c, m - 1, a)) return true;
                if (DFS(r - 1, c, m - 1, a)) return true;
                if (DFS(r, c + 1, m - 1, a)) return true;
                if (DFS(r, c - 1, m - 1, a)) return true;

                board[r, c] = p;

                return false;
            }
        }
    }
}

namespace Algorithm.BOJ.BOJ_02580
{
    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02580/input.txt",
        ];

        // 시간 초과
        public static void Run(string[] args)
        {
            int[,] board = new int[9, 9];
            HashSet<int>[,] memo = new HashSet<int>[9, 9];
            int cntEmpty = 0;
            for (int i = 0; i < 9; i++)
            {
                string[] numbers = Console.ReadLine()!.Split();
                for (int j = 0; j < 9; j++)
                {
                    board[i, j] = int.Parse(numbers[j]);
                    if (board[i, j] == 0) cntEmpty++;
                    memo[i, j] = new();
                }
            }

            for (int r = 0; r < 9; r++)
            for (int c = 0; c < 9; c++)
            {
                if (board[r, c] != 0) continue;
                for (int n = 1; n <= 9; n++)
                {
                    if (IsValid(board, r, c, n)) memo[r, c].Add(n);
                }
            }

            while (cntEmpty > 0)
            {
                int cnt = 0;
                for (int r = 0; r < 9; r++)
                for (int c = 0; c < 9; c++)
                {
                    if (memo[r, c].Count != 1) continue;
                    Fill(board, memo, r, c);
                    cnt++;
                }
                cntEmpty -= cnt;

                if (cnt > 0) continue;

                for (int r = 0; r < 9; r++)
                for (int c = 0; c < 9; c++)
                {
                    if (memo[r, c].Count == 0) continue;
                    Fill(board, memo, r, c);
                    goto Next;
                }
                Next:;
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++) Console.Write(board[i, j] + " ");
                Console.Write('\n');
            }
        }

        private static bool IsValid(int[,] board, int r, int c, int n)
        {
            int sr = r / 3 * 3, sc = c / 3 * 3;
            for (int i = 0; i < 9; i++)
            {
                if (board[i, c] == n) return false;
                if (board[r, i] == n) return false;
                if (board[sr + i / 3, sc + i % 3] == n) return false;
            }
            return true;
        }

        private static void Fill(int[,] board, HashSet<int>[,] memo, int r, int c)
        {
            board[r, c] = memo[r, c].First();
            memo[r, c].Clear();
            int sr = r / 3 * 3, sc = c / 3 * 3;
            for (int i = 0; i < 9; i++)
            {
                memo[i, c].Remove(board[r, c]);
                memo[r, i].Remove(board[r, c]);
                memo[sr + i / 3, sc + i % 3].Remove(board[r, c]);
            }
        }
    }
}

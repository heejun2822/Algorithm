namespace Algorithm.BOJ.BOJ_02580
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_02580/input.txt",
        ];

        public static void Run(string[] args)
        {
            int[,] board = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                string[] numbers = Console.ReadLine()!.Split();
                for (int j = 0; j < 9; j++) board[i, j] = int.Parse(numbers[j]);
            }

            Sudoku(board, 0);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++) Console.Write(board[i, j] + " ");
                Console.Write('\n');
            }
        }

        private static bool Sudoku(int[,] board, int idx)
        {
            if (idx == 81) return true;

            int r = idx / 9, c = idx % 9;
            if (board[r, c] == 0)
            {
                for (int i = 1; i <= 9; i++)
                {
                    if (!IsValid(board, r, c, i)) continue;
                    board[r, c] = i;
                    if (Sudoku(board, idx + 1)) return true;
                    board[r, c] = 0;
                }
                return false;
            }
            else
            {
                return Sudoku(board, idx + 1);
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
    }
}

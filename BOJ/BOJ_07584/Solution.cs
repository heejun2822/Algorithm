namespace Algorithm.BOJ.BOJ_07584
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07584/input.txt",
        ];

        public static void Run(string[] args)
        {
            while (true)
            {
                string[] input = Console.ReadLine()!.Split();
                if (input[0] == "#") break;

                char[,] board = new char[3, 3];

                char symbol = char.Parse(input[0]);
                int r = 0, c = 0;

                for (int i = 1; i < input.Length; i++)
                {
                    int num = int.Parse(input[i]);
                    r = (num - 1) / 3;
                    c = (num - 1) % 3;
                    board[r, c] = symbol;
                    if (i != input.Length - 1) symbol = symbol == 'X' ? 'O' : 'X';
                }

                if (
                    (board[r, 0] == symbol && board[r, 1] == symbol && board[r, 2] == symbol) ||
                    (board[0, c] == symbol && board[1, c] == symbol && board[2, c] == symbol) ||
                    (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol) ||
                    (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
                )
                    Console.WriteLine(symbol);
                else
                    Console.WriteLine("Draw");
            }
        }
    }
}

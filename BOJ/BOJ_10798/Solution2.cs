namespace Algorithm.BOJ.BOJ_10798
{
    using System.Text;

    public class Solution2
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_10798/input1.txt",
            "BOJ/BOJ_10798/input2.txt",
        ];

        public static void Run(string[] args)
        {
            char[][] board = new char[5][];
            for (int i = 0; i < 5; i++)
            {
                string letters = Console.ReadLine()!;
                board[i] = new char[letters.Length];
                for (int j = 0; j < letters.Length; j++)
                {
                    board[i][j] = letters[j];
                }
            }
            StringBuilder answer = new();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= board[j].Length) continue;
                    answer.Append(board[j][i]);
                }
            }
            Console.WriteLine(answer);
        }
    }
}

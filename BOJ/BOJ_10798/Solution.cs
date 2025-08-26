namespace Algorithm.BOJ.BOJ_10798
{
    using System.Text;

    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_10798/input1.txt",
            "BOJ/BOJ_10798/input2.txt",
        ];

        public static void Run(string[] args)
        {
            char[,] board = new char[5, 15];
            for (int i = 0; i < 5; i++)
            {
                string letters = Console.ReadLine()!;
                for (int j = 0; j < letters.Length; j++)
                {
                    board[i, j] = letters[j];
                }
            }
            StringBuilder answer = new();
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (board[j, i] == '\0') continue;
                    answer.Append(board[j, i]);
                }
            }
            Console.WriteLine(answer);
        }
    }
}

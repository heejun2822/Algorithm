namespace Algorithm.BOJ.BOJ_07682
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_07682/input.txt",
        ];

        public static void Run(string[] args)
        {
            string input;
            char[,] board = new char[3, 3];
            int cntX, cntO;
            bool winX, winO;

            System.Text.StringBuilder output = new();

            while ((input = Console.ReadLine()!) != "end")
            {
                cntX = cntO = 0;
                winX = winO = false;

                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        UpdateCnt(board[i, j] = input[3 * i + j]);

                if ((cntX != cntO) && (cntX != cntO + 1))
                {
                    output.AppendLine("invalid");
                    continue;
                }

                for (int i = 0; i < 3; i++)
                {
                    if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                        UpdateWin(board[i, 0]);
                    if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
                        UpdateWin(board[0, i]);
                }
                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                    UpdateWin(board[0, 0]);
                if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
                    UpdateWin(board[2, 0]);

                if (winX && winO)
                    output.AppendLine("invalid");
                else if (winX && !winO)
                    output.AppendLine(cntX == cntO + 1 ? "valid" : "invalid");
                else if (!winX && winO)
                    output.AppendLine(cntX == cntO ? "valid" : "invalid");
                else
                    output.AppendLine(cntX == 5 && cntO == 4 ? "valid" : "invalid");
            }

            Console.Write(output);

            void UpdateCnt(char c)
            {
                if (c == 'X') cntX++;
                else if (c == 'O') cntO++;
            }

            void UpdateWin(char c)
            {
                if (c == 'X') winX = true;
                else if (c == 'O') winO = true;
            }
        }
    }
}

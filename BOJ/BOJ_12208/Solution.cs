namespace Algorithm.BOJ.BOJ_12208
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12208/input.txt",
        ];

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            System.Text.StringBuilder output = new();

            for (int x = 1; x <= T; x++)
            {
                string[] input = Console.ReadLine()!.Split();
                int N = int.Parse(input[0]);
                string DIR = input[1];
                int[,] board = new int[N, N];

                Func<int, int, int, (int, int)> ConvertCoord = ConvertCoordLeft;
                if (DIR == "left")
                    ConvertCoord = ConvertCoordLeft;
                else if (DIR == "right")
                    ConvertCoord = ConvertCoordRight;
                else if (DIR == "up")
                    ConvertCoord = ConvertCoordUp;
                else if (DIR == "down")
                    ConvertCoord = ConvertCoordDown;

                for (int i = 0; i < N; i++)
                {
                    input = Console.ReadLine()!.Split();
                    for (int j = 0; j < N; j++)
                    {
                        (int r, int c) = ConvertCoord(i, j, N);
                        board[r, c] = int.Parse(input[j]);
                    }
                }

                for (int r = 0; r < N; r++)
                {
                    bool merged = false;

                    for (int c = 0; c < N; c++)
                    {
                        if (board[r, c] == 0) continue;

                        int nc = c;
                        while (nc - 1 >= 0 && board[r, nc - 1] == 0)
                            nc--;

                        if (nc - 1 >= 0 && board[r, nc - 1] == board[r, c] && !merged)
                        {
                            board[r, nc - 1] *= 2;
                            board[r, c] = 0;
                            merged = true;
                        }
                        else if (nc != c)
                        {
                            board[r, nc] = board[r, c];
                            board[r, c] = 0;
                            merged = false;
                        }
                    }
                }

                output.AppendLine($"Case #{x}:");
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        (int r, int c) = ConvertCoord(i, j, N);
                        output.Append(board[r, c]).Append(' ');
                    }
                    output.AppendLine();
                }
            }

            Console.Write(output);

            (int, int) ConvertCoordLeft(int i, int j, int N) => (i, j);
            (int, int) ConvertCoordRight(int i, int j, int N) => (i, N - 1 - j);
            (int, int) ConvertCoordUp(int i, int j, int N) => (j, i);
            (int, int) ConvertCoordDown(int i, int j, int N) => (j, N - 1 - i);
        }
    }
}

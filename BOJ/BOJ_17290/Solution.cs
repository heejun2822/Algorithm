namespace Algorithm.BOJ.BOJ_17290
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_17290/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int r = int.Parse(input[0]) - 1;
            int c = int.Parse(input[1]) - 1;

            bool[] boomR = new bool[10];
            bool[] boomC = new bool[10];

            for (int row = 0; row < 10; row++)
            {
                string board = Console.ReadLine()!;
                for (int col = 0; col < 10; col++)
                {
                    if (board[col] == 'o')
                    {
                        boomR[row] = true;
                        boomC[col] = true;
                    }
                }
            }

            int movementR = 10;
            int movementC = 10;

            for (int i = 0; i < 10; i++)
            {
                if (!boomR[i])
                    movementR = Math.Min(movementR, Math.Abs(i - r));
                if (!boomC[i])
                    movementC = Math.Min(movementC, Math.Abs(i - c));
            }

            Console.WriteLine(movementR + movementC);
        }
    }
}

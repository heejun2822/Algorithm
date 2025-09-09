namespace Algorithm.BOJ.BOJ_29634
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_29634/input1.txt",
            "BOJ/BOJ_29634/input2.txt",
            "BOJ/BOJ_29634/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            bool[,] room = new bool[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    room[i, j] = Console.Read() == '.';
                Console.ReadLine();
            }

            int maxRoomArea = -1;

            for (int r = 1; r < n - 1; r++)
            {
                for (int c = 1; c < m - 1; c++)
                {
                    if (!room[r, c]) continue;

                    int h = 1, w = 1;

                    while (room[r + h, c]) h++;
                    while (room[r, c + w]) w++;

                    for (int i = 0; i < h; i++)
                        for (int j = 0; j < w; j++)
                            room[r + i, c + j] = false;

                    maxRoomArea = Math.Max(maxRoomArea, h * w);
                }
            }

            Console.WriteLine(maxRoomArea);
        }
    }
}

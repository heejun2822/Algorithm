namespace Algorithm.BOJ.BOJ_02567
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02567/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);

            bool[,] paper = new bool[100, 100];

            for (int _ = 0; _ < N; _++)
            {
                string[] xy = Console.ReadLine()!.Split();
                int x = int.Parse(xy[0]);
                int y = int.Parse(xy[1]);

                for (int i = 0; i < 10; i++)
                    for (int j = 0; j < 10; j++)
                        paper[x + i, y + j] = true;
            }

            int perimeter = 0;

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (!paper[i, j]) continue;

                    if (i - 1 < 0 || !paper[i - 1, j]) perimeter++;
                    if (i + 1 >= 100 || !paper[i + 1, j]) perimeter++;
                    if (j - 1 < 0 || !paper[i, j - 1]) perimeter++;
                    if (j + 1 >= 100 || !paper[i, j + 1]) perimeter++;
                }
            }

            Console.WriteLine(perimeter);
        }
    }
}

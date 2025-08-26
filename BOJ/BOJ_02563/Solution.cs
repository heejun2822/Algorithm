namespace Algorithm.BOJ.BOJ_02563
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02563/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            bool[,] paper = new bool[100, 100];
            for (int _ = 0; _ < N; _++)
            {
                string[] offsets = Console.ReadLine()!.Split();
                int x = int.Parse(offsets[0]);
                int y = int.Parse(offsets[1]);
                for (int i = 90 - y; i < 100 - y; i++)
                {
                    for (int j = x; j < x + 10; j++)
                    {
                        paper[i, j] = true;
                    }
                }
            }
            int area = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    if (paper[i, j]) area++;
                }
            }
            Console.WriteLine(area);
        }
    }
}

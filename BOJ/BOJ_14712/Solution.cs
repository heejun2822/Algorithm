namespace Algorithm.BOJ.BOJ_14712
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_14712/input1.txt",
            "BOJ/BOJ_14712/input2.txt",
            "BOJ/BOJ_14712/input3.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), M = int.Parse(input[1]);

            bool[,] grid = new bool[N + 1, M + 1];
            int cnt = 0;

            FillGrid(0);

            Console.WriteLine(cnt);

            void FillGrid(int idx)
            {
                if (idx == N * M)
                {
                    cnt++;
                    return;
                }

                int r = idx / M + 1;
                int c = idx % M + 1;

                grid[r, c] = false;
                FillGrid(idx + 1);

                if (!grid[r - 1, c] || !grid[r, c - 1] || !grid[r - 1, c - 1])
                {
                    grid[r, c] = true;
                    FillGrid(idx + 1);
                }
            }
        }
    }
}

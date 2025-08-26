namespace Algorithm.BOJ.BOJ_02630
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02630/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[,] paper = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine()!.Split();
                for (int j = 0; j < N; j++) paper[i, j] = int.Parse(row[j]);
            }

            int[] cnt = new int[2];
            CutPaper(paper, 0, 0, N, cnt);

            Console.WriteLine(cnt[0]);
            Console.WriteLine(cnt[1]);
        }

        private static void CutPaper(int[,] paper, int r, int c, int n, int[] cnt)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (paper[r + i, c + j] == paper[r, c]) continue;
                    int h = n / 2;
                    CutPaper(paper, r, c, h, cnt);
                    CutPaper(paper, r, c + h, h, cnt);
                    CutPaper(paper, r + h, c, h, cnt);
                    CutPaper(paper, r + h, c + h, h, cnt);
                    return;
                }
            }

            cnt[paper[r, c]]++;
        }
    }
}

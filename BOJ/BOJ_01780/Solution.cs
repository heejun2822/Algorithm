namespace Algorithm.BOJ.BOJ_01780
{
    public class Solution
    {
        public static string[] InputPaths { get; private set; } =
        [
            "BOJ/BOJ_01780/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[,] paper = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                string[] row = Console.ReadLine()!.Split();
                for (int j = 0; j < N; j++) paper[i, j] = int.Parse(row[j]) + 1;
            }

            int[] cnt = new int[3];
            CutPaper(paper, 0, 0, N, cnt);
            foreach (int c in cnt) Console.WriteLine(c);
        }

        private static void CutPaper(int[,] paper, int r, int c, int n, int[] cnt)
        {
            if (IsSinglePaper(paper, r, c, n))
            {
                cnt[paper[r, c]]++;
                return;
            }

            int t = n / 3;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    CutPaper(paper, r + t * i, c + t * j, t, cnt);
        }

        private static bool IsSinglePaper(int[,] paper, int r, int c, int n)
        {
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    if (paper[r + i, c + j] != paper[r, c]) return false;
            return true;
        }
    }
}

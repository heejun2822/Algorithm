namespace Algorithm.BOJ.BOJ_01012
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01012/input1.txt",
            "BOJ/BOJ_01012/input2.txt",
        ];

        private static int M;
        private static int N;
        private static bool[,] field = {};

        public static void Run(string[] args)
        {
            int T = int.Parse(Console.ReadLine()!);

            for (int _ = 0; _ < T; _++)
            {
                string[] mnk = Console.ReadLine()!.Split();
                M = int.Parse(mnk[0]);
                N = int.Parse(mnk[1]);
                int K = int.Parse(mnk[2]);

                field = new bool[M, N];
                for (int i = 0; i < K; i++)
                {
                    string[] xy = Console.ReadLine()!.Split();
                    field[int.Parse(xy[0]), int.Parse(xy[1])] = true;
                }

                int cnt = 0;

                for (int x = 0; x < M; x++)
                    for (int y = 0; y < N; y++)
                        if (CheckCabbages(x, y)) cnt++;

                Console.WriteLine(cnt);
            }
        }

        private static bool CheckCabbages(int x, int y)
        {
            if (!field[x, y]) return false;

            field[x, y] = false;

            if (x > 0) CheckCabbages(x - 1, y);
            if (x < M - 1) CheckCabbages(x + 1, y);
            if (y > 0) CheckCabbages(x, y - 1);
            if (y < N - 1) CheckCabbages(x, y + 1);

            return true;
        }
    }
}

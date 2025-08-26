namespace Algorithm.BOJ.BOJ_02667
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02667/input.txt",
        ];

        private static readonly int[] dr = { 0, 0, 1, -1 };
        private static readonly int[] dc = { 1, -1, 0, 0 };

        private static int N;
        private static bool[,] map = {};

        public static void Run(string[] args)
        {
            N = int.Parse(Console.ReadLine()!);
            map = new bool[N, N];
            for (int i = 0; i < N; i++)
            {
                string line = Console.ReadLine()!;
                for (int j = 0; j < N; j++) map[i, j] = line[j] == '1';
            }

            List<int> complexes = new();

            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    if (!map[r, c]) continue;
                    complexes.Add(CountHouses(r, c));
                }
            }

            complexes.Sort();

            Console.WriteLine(complexes.Count);
            foreach (int cnt in complexes) Console.WriteLine(cnt);
        }

        private static int CountHouses(int r, int c)
        {
            if (r == -1 || r == N || c == -1 || c == N) return 0;
            if (!map[r, c]) return 0;

            map[r, c] = false;
            int cnt = 1;

            for (int i = 0; i < 4; i++)
                cnt += CountHouses(r + dr[i], c + dc[i]);

            return cnt;
        }
    }
}

namespace Algorithm.BOJ.BOJ_09663
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09663/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Dictionary<string, bool[]> visited = new()
            {
                { "col", new bool[N] },
                { "mainD", new bool[2 * N - 1] },
                { "subD", new bool[2 * N - 1] },
            };

            Console.WriteLine(NQueen(N, visited, 0));
        }

        private static int NQueen(int N, Dictionary<string, bool[]> visited, int r)
        {
            if (r == N) return 1;

            int cnt = 0;
            for (int c = 0; c < N; c++)
            {
                int md = r - c + N - 1, sd = r + c;
                if (visited["col"][c] || visited["mainD"][md] || visited["subD"][sd]) continue;
                visited["col"][c] = visited["mainD"][md] = visited["subD"][sd] = true;
                cnt += NQueen(N, visited, r + 1);
                visited["col"][c] = visited["mainD"][md] = visited["subD"][sd] = false;
            }
            return cnt;
        }
    }
}

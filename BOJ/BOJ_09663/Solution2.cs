namespace Algorithm.BOJ.BOJ_09663
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09663/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            bool[] visitedCol = new bool[N];
            bool[] visitedMainD = new bool[2 * N - 1];
            bool[] visitedSubD = new bool[2 * N - 1];

            Console.WriteLine(NQueen(N, visitedCol, visitedMainD, visitedSubD, 0));
        }

        private static int NQueen(int N, bool[] visitedCol, bool[] visitedMainD, bool[] visitedSubD, int r)
        {
            if (r == N) return 1;

            int cnt = 0;
            for (int c = 0; c < N; c++)
            {
                int md = r - c + N - 1, sd = r + c;
                if (visitedCol[c] || visitedMainD[md] || visitedSubD[sd]) continue;
                visitedCol[c] = visitedMainD[md] = visitedSubD[sd] = true;
                cnt += NQueen(N, visitedCol, visitedMainD, visitedSubD, r + 1);
                visitedCol[c] = visitedMainD[md] = visitedSubD[sd] = false;
            }
            return cnt;
        }
    }
}

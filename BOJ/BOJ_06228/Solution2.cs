namespace Algorithm.BOJ.BOJ_06228
{
    public class Solution2 : SolutionBOJ<Solution2>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06228/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int N = int.Parse(input[0]), S = int.Parse(input[1]), E = int.Parse(input[2]);

            (int W, int R)[][] expressions = new (int, int)[E][];

            for (int i = 0; i < E; i++)
            {
                input = Console.ReadLine()!.Split('+');
                expressions[i] = new (int, int)[input.Length];
                for (int j = 0; j < input.Length; j++)
                {
                    string[] exp = input[j].Split('x');
                    expressions[i][j] = (int.Parse(exp[0]), int.Parse(exp[1]));
                }
            }

            long[] factorial = new long[N + 1];
            factorial[0] = 1;
            for (int i = 1; i <= N; i++)
                factorial[i] = factorial[i - 1] * i;

            int[] diceCounts = new int[S + 1];
            int cnt = 0;

            Search(1, N);

            Console.WriteLine(cnt);

            void Search(int dice, int maxCnt)
            {
                if (dice == S)
                {
                    diceCounts[dice] = maxCnt;
                    if (SatisfyAnyExpressions())
                        cnt += GetCaseCnt();
                    return;
                }

                for (int i = 0; i <= maxCnt; i++)
                {
                    diceCounts[dice] = i;
                    Search(dice + 1, maxCnt - i);
                }
            }

            bool SatisfyAnyExpressions()
            {
                for (int i = 0; i < E; i++)
                    if (SatisfyExpression(i))
                        return true;
                return false;
            }

            bool SatisfyExpression(int idx)
            {
                foreach ((int W, int R) in expressions[idx])
                    if (diceCounts[R] < W)
                        return false;
                return true;
            }

            int GetCaseCnt()
            {
                long cnt = factorial[N];
                for (int i = 1; i <= S; i++)
                    cnt /= factorial[diceCounts[i]];
                return (int)cnt;
            }
        }
    }
}

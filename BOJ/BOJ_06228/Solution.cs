namespace Algorithm.BOJ.BOJ_06228
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
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

            int[] diceCounts = new int[S + 1];
            int cnt = 0;

            Search(0);

            Console.WriteLine(cnt);

            void Search(int itr)
            {
                if (itr == N)
                {
                    if (SatisfyAnyExpressions())
                        cnt++;
                    return;
                }

                for (int i = 1; i <= S; i++)
                {
                    diceCounts[i]++;
                    Search(itr + 1);
                    diceCounts[i]--;
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
        }
    }
}

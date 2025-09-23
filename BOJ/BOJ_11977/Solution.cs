namespace Algorithm.BOJ.BOJ_11977
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_11977/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] x = new int[N];

            for (int i = 0; i < N; i++)
                x[i] = int.Parse(Console.ReadLine()!);

            Array.Sort(x);

            int maxCnt = 0;

            for (int idx = 0; idx < N; idx++)
            {
                int cnt = 1;

                int radius = 1;
                int lastIdx = idx;

                while (lastIdx != -1)
                {
                    int leftMostX = x[lastIdx] - radius++;
                    int nextIdx = lastIdx;
                    lastIdx = -1;

                    while (--nextIdx >= 0)
                    {
                        if (x[nextIdx] < leftMostX) break;
                        lastIdx = nextIdx;
                        cnt++;
                    }
                }

                radius = 1;
                lastIdx = idx;

                while (lastIdx != -1)
                {
                    int rightMostX = x[lastIdx] + radius++;
                    int nextIdx = lastIdx;
                    lastIdx = -1;

                    while (++nextIdx < N)
                    {
                        if (x[nextIdx] > rightMostX) break;
                        lastIdx = nextIdx;
                        cnt++;
                    }
                }

                maxCnt = Math.Max(maxCnt, cnt);
            }

            Console.WriteLine(maxCnt);
        }
    }
}

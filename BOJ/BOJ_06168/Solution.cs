namespace Algorithm.BOJ.BOJ_06168
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_06168/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] D = new int[N];

            int cnt = 0;

            for (int i = 0; i < N; i++)
            {
                D[i] = int.Parse(Console.ReadLine()!);
                if (D[i] == 1) cnt++;
            }

            int minCnt = cnt;

            for (int i = 0; i < N; i++)
            {
                if (D[i] == 2) cnt++;
                else cnt--;
                minCnt = Math.Min(minCnt, cnt);
            }

            Console.WriteLine(minCnt);
        }
    }
}

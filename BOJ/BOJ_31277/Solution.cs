namespace Algorithm.BOJ.BOJ_31277
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31277/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] a = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int sameCnt = 1;
            int maxSameCnt = 1;

            for (int i = 1; i < N; i++)
            {
                if (a[i] == a[i - 1])
                    maxSameCnt = Math.Max(maxSameCnt, ++sameCnt);
                else
                    sameCnt = 1;
            }

            int allCnt = 0;

            for (int i = 3; i < N; i++)
            {
                if ((a[i - 3] | a[i - 2] | a[i - 1] | a[i]) == 15)
                    allCnt++;
            }

            Console.WriteLine($"{maxSameCnt} {allCnt}");
        }
    }
}

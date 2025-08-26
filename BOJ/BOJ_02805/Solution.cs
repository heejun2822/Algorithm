namespace Algorithm.BOJ.BOJ_02805
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02805/input1.txt",
            "BOJ/BOJ_02805/input2.txt",
        ];

        public static void Run(string[] args)
        {
            string[] nm = Console.ReadLine()!.Split();
            int N = int.Parse(nm[0]);
            int M = int.Parse(nm[1]);
            int[] treeHeights = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int low = 0, high = treeHeights.Max();
            while (low < high)
            {
                int H = (low + high + 1) / 2;
                long cutted = 0;
                for (int i = 0; i < N; i++)
                {
                    cutted += Math.Max(treeHeights[i] - H, 0);
                    if (cutted >= M) break;
                }
                if (cutted >= M) low = H;
                else high = H - 1;
            }

            Console.WriteLine(high);
        }
    }
}

namespace Algorithm.BOJ.BOJ_01027
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01027/input1.txt",
            "BOJ/BOJ_01027/input2.txt",
            "BOJ/BOJ_01027/input3.txt",
            "BOJ/BOJ_01027/input4.txt",
            "BOJ/BOJ_01027/input5.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] heights = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int[] counts = new int[N];
            int maxCnt = 0;

            for (int i = 0; i < N; i++)
            {
                double slope = -1_000_000_000;

                for (int j = i + 1; j < N; j++)
                {
                    if (heights[j] > heights[i] + slope * (j - i))
                    {
                        counts[i]++;
                        counts[j]++;
                        slope = (double)(heights[j] - heights[i]) / (j - i);
                    }
                }

                maxCnt = Math.Max(maxCnt, counts[i]);
            }

            Console.WriteLine(maxCnt);
        }
    }
}

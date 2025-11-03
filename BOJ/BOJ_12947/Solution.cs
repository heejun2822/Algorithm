namespace Algorithm.BOJ.BOJ_12947
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12947/input1.txt",
            "BOJ/BOJ_12947/input2.txt",
            "BOJ/BOJ_12947/input3.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int[] cnt = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            int maxDiameter = 0;
            int diameter = N;

            for (int i = 0; i < N; i++)
            {
                if (cnt[i] == 1)
                {
                    maxDiameter = Math.Max(maxDiameter, diameter);
                    diameter = N - (i + 1);
                    continue;
                }
                diameter++;
            }
            maxDiameter = Math.Max(maxDiameter, diameter);

            Console.WriteLine(maxDiameter);
        }
    }
}

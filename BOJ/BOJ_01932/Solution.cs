namespace Algorithm.BOJ.BOJ_01932
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_01932/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int[][] triangle = new int[n][];
            for (int i = 0; i < n; i++)
                triangle[i] = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);

            for (int i = 1; i < n; i++)
            for (int j = 0; j <= i; j++)
                triangle[i][j] += j == 0
                    ? triangle[i - 1][0]
                    : j == i
                    ? triangle[i - 1][i - 1]
                    : Math.Max(triangle[i - 1][j - 1], triangle[i - 1][j]);

            Console.WriteLine(triangle[n - 1].Max());
        }
    }
}

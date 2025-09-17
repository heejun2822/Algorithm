namespace Algorithm.BOJ.BOJ_23971
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_23971/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            int H = int.Parse(input[0]);
            int W = int.Parse(input[1]);
            int N = int.Parse(input[2]);
            int M = int.Parse(input[3]);

            int r = (H + N) / (N + 1);
            int c = (W + M) / (M + 1);

            Console.WriteLine(r * c);
        }
    }
}

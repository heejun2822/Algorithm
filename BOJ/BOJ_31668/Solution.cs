namespace Algorithm.BOJ.BOJ_31668
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_31668/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int M = int.Parse(Console.ReadLine()!);
            int K = int.Parse(Console.ReadLine()!);
            Console.WriteLine(M / N * K);
        }
    }
}

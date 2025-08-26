namespace Algorithm.BOJ.BOJ_24265
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24265/input.txt",
        ];

        public static void Run(string[] args)
        {
            long n = long.Parse(Console.ReadLine()!);
            Console.WriteLine(n * (n - 1) / 2);
            Console.WriteLine(2);
        }
    }
}

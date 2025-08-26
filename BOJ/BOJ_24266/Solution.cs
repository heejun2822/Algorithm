namespace Algorithm.BOJ.BOJ_24266
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24266/input.txt",
        ];

        public static void Run(string[] args)
        {
            long n = long.Parse(Console.ReadLine()!);
            Console.WriteLine(n * n * n);
            Console.WriteLine(3);
        }
    }
}

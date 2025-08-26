namespace Algorithm.BOJ.BOJ_24267
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24267/input.txt",
        ];

        public static void Run(string[] args)
        {
            long n = long.Parse(Console.ReadLine()!);
            Console.WriteLine(n * (n - 1) * (n - 2) / 6);
            Console.WriteLine(3);
        }
    }
}

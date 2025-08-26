namespace Algorithm.BOJ.BOJ_24263
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_24263/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine(n);
            Console.WriteLine(1);
        }
    }
}

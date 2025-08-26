namespace Algorithm.BOJ.BOJ_15727
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_15727/input.txt",
        ];

        public static void Run(string[] args)
        {
            int L = int.Parse(Console.ReadLine()!);
            Console.WriteLine(Math.Ceiling(L / 5.0));
        }
    }
}

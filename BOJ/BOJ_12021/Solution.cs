namespace Algorithm.BOJ.BOJ_12021
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_12021/input.txt",
        ];

        public static void Run(string[] args)
        {
            string[] input = Console.ReadLine()!.Split();
            long a = long.Parse(input[0]), b = long.Parse(input[1]);

            double limit = Math.Sqrt((double)a * b);

            Console.WriteLine($"{limit:F6} {limit:F6}");
        }
    }
}

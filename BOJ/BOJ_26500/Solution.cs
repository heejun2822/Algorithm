namespace Algorithm.BOJ.BOJ_26500
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_26500/input.txt",
        ];

        public static void Run(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);

            while (n-- > 0)
            {
                string[] input = Console.ReadLine()!.Split();
                double dist = Math.Abs(double.Parse(input[0]) - double.Parse(input[1]));
                Console.WriteLine(dist.ToString("F1"));
            }
        }
    }
}

namespace Algorithm.BOJ.BOJ_09546
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_09546/input.txt",
        ];

        public static void Run(string[] args)
        {
            int t = int.Parse(Console.ReadLine()!);
            for (int _ = 0; _ < t; _++)
            {
                int k = int.Parse(Console.ReadLine()!);
                Console.WriteLine((1 << k) - 1);
            }
        }
    }
}

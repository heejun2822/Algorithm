namespace Algorithm.BOJ.BOJ_02292
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_02292/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int layer = 1;
            int rooms = 1;
            while (rooms < N) rooms += layer++ * 6;
            Console.WriteLine(layer);
        }
    }
}

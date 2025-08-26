namespace Algorithm.BOJ.BOJ_16676
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_16676/input.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            int cnt = 1, max = 10;
            while (max < N) max += (int)Math.Pow(10, ++cnt);
            Console.WriteLine(cnt);
        }
    }
}

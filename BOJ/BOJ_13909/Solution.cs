namespace Algorithm.BOJ.BOJ_13909
{
    public class Solution : SolutionBOJ<Solution>, ISolutionBOJ
    {
        public static string[] InputPaths { get; set; } =
        [
            "BOJ/BOJ_13909/input1.txt",
            "BOJ/BOJ_13909/input2.txt",
        ];

        public static void Run(string[] args)
        {
            int N = int.Parse(Console.ReadLine()!);
            Console.WriteLine((int)Math.Sqrt(N));
        }
    }
}
